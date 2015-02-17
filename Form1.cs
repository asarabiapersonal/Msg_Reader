using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using iwantedue;



namespace Msg_Reader
{

    public partial class Form1 : Form
    {
        string currentWorkspace = "";
        public List<messageNodeInfo> nodeList = new List<messageNodeInfo>();

        public Form1()
        {
            InitializeComponent();
            if (File.Exists("settings.txt"))
            {
                StreamReader sr = new StreamReader("settings.txt");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Show();
        }

        private void load_files(string msgfile, string holder, ref int TabCount,string ruleTxt = "",bool fromNode = false)
        {
            myTab = new TabPage(holder);
            myTab.Text = holder;
            TextBox HeaderBox = new TextBox();
            HeaderBox.Multiline = true;
            HeaderBox.Width = 500;
            HeaderBox.Height = 975;
            HeaderBox.Location = new Point(600, 0);
            HeaderBox.ScrollBars = ScrollBars.Both;
            HeaderBox.ReadOnly = true;
            myTab.Controls.Add(HeaderBox);

            TextBox BodyBox = new TextBox();
            BodyBox.Multiline = true;
            BodyBox.Width = 600;
            BodyBox.Height = 975;
            BodyBox.ScrollBars = ScrollBars.Both;
            BodyBox.ReadOnly = true;
            myTab.Controls.Add(BodyBox);

            TextBox ruleBox = new TextBox();
            ruleBox.Multiline = true;
            ruleBox.Width = 300;
            ruleBox.Height = 500;
            ruleBox.Location = new Point(1100, 20);
            ruleBox.Font = new Font(ruleBox.Font.FontFamily, 9);
            ruleBox.Text = ruleTxt;
            ruleBox.Name = "rB";
            myTab.Controls.Add(ruleBox);

            Regex regex_txt = new Regex(@"\.txt$");
            Regex regex_msg = new Regex(@"\.msg$");
            Regex regex_eml = new Regex(@"\.eml$");
            Match match_txt = regex_txt.Match(msgfile);
            Match match_msg = regex_msg.Match(msgfile);
            Match match_eml = regex_eml.Match(msgfile);

            TabCount = TabCount + 1;
            if (match_msg.Success)
            {
                Stream messageStream;
                try { messageStream = File.Open(msgfile, FileMode.Open, FileAccess.Read); }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "File Error", MessageBoxButtons.OK);
                    return;
                }
                OutlookStorage.Message message = new OutlookStorage.Message(messageStream);
                messageStream.Close();

                HeaderBox.Text = message.GetMapiPropertyString("007D");
                BodyBox.Text = message.BodyText;
                message.Dispose();
            }
            else if (match_eml.Success || match_txt.Success)
            {
                StreamReader mStream;
                try { mStream = new StreamReader(msgfile); }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "File Error", MessageBoxButtons.OK);
                    return;
                }
                
                bool reachedBody = false;
                bool firstLine = true;
                string header = "";
                string body = "";

                while (mStream.Peek() >= 0)
                {
                    string lineTest = mStream.ReadLine();
                    if (lineTest != "" && reachedBody == false)
                    {
                        if (!firstLine)
                        {
                            header = header + "\r\n" + lineTest;
                        }
                        else { header = lineTest; firstLine = false; }
                        reachedBody = false;
                    }

                    else if (lineTest == "" && reachedBody == false)
                    {
                        reachedBody = true;
                        firstLine = true;
                        HeaderBox.Text = header;
                    }
                    if (reachedBody)
                    {
                        if (!firstLine)
                        {
                            body = body + "\r\n" + lineTest;
                        }
                        else { body = lineTest; firstLine = false; }
                    }
                }
                BodyBox.Text = body;
            }
            messageNodeInfo nodeNew = new messageNodeInfo();
            nodeNew.headerText = HeaderBox.Text;
            nodeNew.bodyText = BodyBox.Text;
            nodeNew.tNode.Text = holder;
            nodeNew.tNode.Name = msgfile;
            nodeNew.filePath = msgfile;
            nodeNew.fileName = holder;
            nodeNew.tNode.ContextMenuStrip = contextMenuStrip2;
            nodeList.Add(nodeNew);

            tabControl1.TabPages.Add(myTab);
            //tabControl1.Hide();
            closeBtn.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;

            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Level != 0 && fromNode == false)
                {                  
                    treeView1.SelectedNode.Parent.Nodes.Add(nodeNew.tNode);
                    nodeNew.pNodeIndex = treeView1.SelectedNode.Parent.Index;
                }
                else if(fromNode == false)
                {
                    treeView1.SelectedNode.Nodes.Add(nodeNew.tNode);
                    nodeNew.pNodeIndex = treeView1.SelectedNode.Index;
                }

                treeView1.SelectedNode.Expand();
            }
            else if (treeView1.SelectedNode == null)
            {
                if (treeView1.Nodes.ContainsKey("Untitled") == false)
                {
                    TreeNode newTopNode = new TreeNode("Untitled");
                    newTopNode.Name = "Untitled";
                    newTopNode.ContextMenuStrip = contextMenuStrip1;
                    nodeNew.pNodeIndex = treeView1.Nodes.Count;
                    newTopNode.Nodes.Add(nodeNew.tNode);
                    treeView1.Nodes.Add(newTopNode);
                    treeView1.SelectedNode = treeView1.Nodes[newTopNode.Name];
                }
                else
                {
                    ;
                }
            }
            else
            {
                ;
            }
        }



        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult msgFileSelectResult = this.openFileDialog1.ShowDialog();
            if (msgFileSelectResult == DialogResult.OK)
            {
                TreeNode treeNode = new TreeNode("Untitled");
                treeNode.Name = "Untitled";
                treeNode.ContextMenuStrip = contextMenuStrip1;
                int TabCount = 0;
                foreach (string msgfile in this.openFileDialog1.FileNames)
                {
                    string[] shortName = this.openFileDialog1.SafeFileNames;
                    string holder = shortName[TabCount];
                    load_files(msgfile, holder,ref TabCount);
                                
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fullMail = "";
            string fName = "";
            string space = " ";
            char[] splitter = space.ToCharArray();
            string[] title;
            string fullTitle = "";
            string holdTitle = "";
            int fileNumber = 1;
            StreamWriter outFiles;

            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                if (allTabsCheck.Checked)
                {
                    for (int x = 0; x < tabControl1.TabPages.Count; x++)
                    {
                        fileNumber = 1;
                        fullMail = tabControl1.TabPages[x].Controls[0].Text + "\r\n" + tabControl1.TabPages[x].Controls[1].Text;
                        fName = tabControl1.TabPages[x].Text;
                        title = fName.Split(splitter);
                        if (title.Length > 1)
                        {
                            fullTitle = title[0] + title[1];
                        }
                        else { fullTitle = title[0]; }
                        string fullPath = folderBrowserDialog1.SelectedPath + "\\" + fullTitle + ".txt";
                        holdTitle = fullTitle;
                        while (File.Exists(fullPath))
                        {
                            fullTitle = holdTitle + fileNumber.ToString();
                            fullPath = folderBrowserDialog1.SelectedPath + "\\" + fullTitle + ".txt";
                            fileNumber++;
                        }
                        outFiles = new StreamWriter(fullPath);
                        outFiles.Write(fullMail);
                        outFiles.Close();
                    }
                }
                else
                {
                    fullMail = tabControl1.SelectedTab.Controls[0].Text + "\r\n" + tabControl1.SelectedTab.Controls[1].Text;
                    fName = tabControl1.SelectedTab.Text;
                    title = fName.Split(splitter);
                    if (title.Length > 1)
                    {
                        fullTitle = title[0] + title[1];
                    }
                    else { fullTitle = title[0]; }
                    string fullPath = folderBrowserDialog1.SelectedPath + "\\" + fullTitle + ".txt";
                    holdTitle = fullTitle;
                    while (File.Exists(fullPath))
                    {
                        fullTitle = holdTitle + fileNumber.ToString();
                        fullPath = folderBrowserDialog1.SelectedPath + "\\" + fullTitle + ".txt";
                        fileNumber++;
                    }
                    outFiles = new StreamWriter(fullPath);
                    outFiles.Write(fullMail);
                    outFiles.Close();
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void currentTabCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (currentTabCheck.Checked){
                allTabsCheck.Checked = false;          
            }
            else if (!currentTabCheck.Checked)
            {
                allTabsCheck.Checked = true;
            }

        }

        private void allTabsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (allTabsCheck.Checked) {
                currentTabCheck.Checked = false;
            }

            else if (!allTabsCheck.Checked){
                currentTabCheck.Checked = true;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {     
            if (tabControl1.TabCount > 0)
            {
                foreach (messageNodeInfo currMNI in nodeList)
                {
                    if (currMNI.tNode.Name == tabControl1.SelectedTab.Text || currMNI.tNode.Text == tabControl1.SelectedTab.Text)
                    {
                        currMNI.rulesText = tabControl1.SelectedTab.Controls["rB"].Text;
                    }
                }
                tabControl1.SelectedTab.Dispose() ;
                if (tabControl1.TabCount == 0)
                {
                    closeBtn.Enabled = false;
                    button1.Enabled = false;
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Close All Tabs?", "Close Tabs", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                if (tabControl1.TabCount > 0)
                {
                    for (int x = tabControl1.TabPages.Count; x > 0; x--)
                    {
                        foreach (messageNodeInfo currMNI in nodeList)
                        {
                            if (currMNI.tNode.Name == tabControl1.TabPages[x - 1].Text || currMNI.tNode.Text == tabControl1.TabPages[x - 1].Text)
                            {
                                currMNI.rulesText = tabControl1.TabPages[x - 1].Controls["rB"].Text;
                            }
                        }
                        tabControl1.TabPages[x-1].Dispose();
                    }
                    closeBtn.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
            }
            
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView1.SelectedNode.Level > 0)
            {
                TreeView clickedNode = sender as TreeView;
                TreeNode selectNode = clickedNode.SelectedNode;
                int tabCounts = tabControl1.TabCount;
                string holdRuleText = "";
                foreach (messageNodeInfo currMNI in nodeList){
                    if (currMNI.tNode.Name == selectNode.Name && currMNI.tNode.Text == selectNode.Text)
                    {
                        holdRuleText = currMNI.rulesText;
                    }
                }
                load_files(clickedNode.SelectedNode.Name, clickedNode.SelectedNode.Text, ref tabCounts, holdRuleText, true);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView locTree = sender as TreeView;
            Form caseOptions = new Form();
            Label NameLabel = new Label();
            Button acceptButton = new Button();
            acceptButton.Text = "OK";
            acceptButton.Width = 100;
            acceptButton.Height = 25;
            acceptButton.Location = new Point(caseOptions.Width - 150, caseOptions.Height - 75);
            acceptButton.DialogResult = DialogResult.OK;

            NameLabel.Text = "Name:";
            NameLabel.Location = new Point(10, 10);
            NameLabel.AutoSize = true;
            TextBox nameTB = new TextBox();
            nameTB.Height = 20;
            nameTB.Width = 200;
            nameTB.Location = new Point(NameLabel.Location.X, NameLabel.Location.Y + 20);
            caseOptions.Controls.Add(NameLabel);
            caseOptions.Controls.Add(nameTB);
            caseOptions.Controls.Add(acceptButton);
            caseOptions.ShowDialog();

            if (caseOptions.DialogResult == DialogResult.OK)
            {
                if (NameLabel.Text != string.Empty && treeView1.SelectedNode != null )
                {
                    if (treeView1.SelectedNode.Level > 0)
                    {
                        treeView1.SelectedNode.Parent.Text = nameTB.Text;
                    }
                    else
                    {
                        treeView1.SelectedNode.Text = nameTB.Text;
                    }
                }
            }

            else if(caseOptions.DialogResult == DialogResult.Cancel){
                ;
            }
        }

        private void AddNode_Click(object sender, EventArgs e)
        {
            TreeNode treeNode = new TreeNode("Untitled");
            treeNode.Name = ("Untitled");
            treeNode.ContextMenuStrip = contextMenuStrip1;
            treeView1.Nodes.Add(treeNode);
        }

        private void removeNode_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Remove Node?", "Remove Node", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK && treeView1.Nodes.Count > 0)
            {
                if (treeView1.SelectedNode != null && treeView1.SelectedNode.Level == 0)
                {
                    treeView1.Nodes.Remove(treeView1.SelectedNode);
                }
            }
            else
            {
                ;
            }
        }

        private void markAsCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.ForeColor == Color.Green)
            {
                treeView1.SelectedNode.ForeColor = Color.Black;
            }
            else
            {
                treeView1.SelectedNode.ForeColor = Color.Green;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var confirmClose = MessageBox.Show("Exit Program?", "Exit Program", MessageBoxButtons.OKCancel);
            if (confirmClose == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {

                e.Cancel = true;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentWorkspace == "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Workspace Files (*.spamWS)|*.spamWS";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter myStream = new StreamWriter(sfd.OpenFile());
                    foreach (TreeNode topNodes in treeView1.Nodes)
                    {
                        if (topNodes.Level == 0)
                        {                         
                            myStream.WriteLine(topNodes.Text);
                        }
                       
                    }
                    myStream.WriteLine("--EOD");
                    foreach (messageNodeInfo allList in nodeList)
                    {
                        myStream.WriteLine(allList.pNodeIndex.ToString());
                        myStream.WriteLine(allList.fileName.ToString());
                        myStream.WriteLine(allList.filePath);
                        if (allList.rulesText == null || allList.rulesText == "")
                        {
                            allList.rulesText = "\n\r";
                        }
                        myStream.WriteLine(allList.rulesText);
                        myStream.WriteLine("--EON");
                     }
                    myStream.Close();
                       
                    }
                }
           }

        private void openWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openWS = new OpenFileDialog();
            openWS.Filter = "Workspace Files (*.spamWS)|*.spamWS";
            if (openWS.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamWS = new StreamReader(openWS.OpenFile());
                treeView1.Nodes.Clear();
                tabControl1.TabPages.Clear();
                nodeList.Clear();
                string holdDef = streamWS.ReadLine();
                while (holdDef != null && holdDef != "--EOD")
                {
                    TreeNode holdNode = new TreeNode(holdDef);
                    holdNode.ContextMenuStrip = contextMenuStrip1;
                    treeView1.Nodes.Add(holdNode);
                    holdDef = streamWS.ReadLine();
                }


                string holdRule;
                while ((holdRule = streamWS.ReadLine()) != null)
                {
                    messageNodeInfo newMNI = new messageNodeInfo();
                    TreeNode nNode = new TreeNode();
                    Int32 nodeIndex;
                    Int32.TryParse(holdRule, out nodeIndex);
                    nNode.Text = streamWS.ReadLine();
                    nNode.Name = streamWS.ReadLine();
                    newMNI.fileName = nNode.Text;
                    newMNI.filePath = nNode.Name;
                    newMNI.pNodeIndex = nodeIndex;
                    
                    while (holdRule != "--EON")
                    {
                        newMNI.rulesText = newMNI.rulesText + holdRule;
                        holdRule = streamWS.ReadLine();
                    }

                    treeView1.Nodes[nodeIndex].Nodes.Add(nNode);
                    nodeList.Add(newMNI);

                }
                


            }
        }


    }
}
