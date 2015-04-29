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
using System.Runtime.InteropServices;
using System.Diagnostics;
using iwantedue;
using SARuleMaker;


namespace Msg_Reader
{

    public partial class Form1 : Form
    {
        string currentWorkspace = "";
        public List<messageNodeInfo> nodeList = new List<messageNodeInfo>();
        public static int lastY = 0;
        public static int numOfRules = 1;
        public static bool ruleBoxOpen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Show();
        }

        // Each message is opened and a tabpage is created dynamically with a header and body box
        private void load_files(string msgfile, string holder, ref int TabCount,string ruleTxt = "",bool fromNode = false)
        {
            bool rulesFileHere = check_for_rules();

            myTab = new TabPage(holder);
            myTab.Text = holder;
            TextBox HeaderBox = new TextBox();
            HeaderBox.Multiline = true;
            HeaderBox.Width = 550;
            HeaderBox.Height = 960;
            HeaderBox.Location = new Point(650, 0);
            HeaderBox.ScrollBars = ScrollBars.Both;
            HeaderBox.ReadOnly = true;
            HeaderBox.BackColor = Color.White;
            HeaderBox.WordWrap = false;
            headerSizeDec.Enabled = true;
            headerSizeInc.Enabled = true;
            HeaderBox.ContextMenuStrip = headerMenu;
            myTab.Controls.Add(HeaderBox);

            TextBox BodyBox = new TextBox();
            BodyBox.Multiline = true;
            BodyBox.Width = 650;
            BodyBox.Height = 960;
            BodyBox.ScrollBars = ScrollBars.Both;
            BodyBox.ReadOnly = true;
            BodyBox.BackColor = Color.White;
            BodyBox.WordWrap = false;
            bodySizeDec.Enabled = true;
            bodySizeInc.Enabled = true;
            BodyBox.ContextMenuStrip = bodyMenu;
            myTab.Controls.Add(BodyBox);

            Regex regex_txt = new Regex(@"\.txt$");
            Regex regex_msg = new Regex(@"\.msg$");
            Regex regex_eml = new Regex(@"\.eml$");
            Match match_txt = regex_txt.Match(msgfile);
            Match match_msg = regex_msg.Match(msgfile);
            Match match_eml = regex_eml.Match(msgfile);

            TabCount = TabCount + 1;

            // What type of file are we trying to open. 
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
            
            // Add a new node to the tree view for these files
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
            closeAllBtn.Enabled = true;

            // If a top level treeview node is already selected add the new files to that node
            // Otherwise create a new toplevel node 
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

        // Opening files from dialog, loop through each of the selected files and load them into program.
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

        // This isn't used yet. Inteded to read from a core rules file and show information about rules a message has in it
        private bool check_for_rules()
        {
            if (!File.Exists("lsslocalrules.cf"))
            {
                return false;
            }
            else if(File.Exists("lsslocalrules.cf"))
            {
                return true;
            }

            return false;
        }


        // Exporting messages to text format.
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

            // Export all tabs or just selected
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

        // Close the selected tab
        private void closeBtn_Click(object sender, EventArgs e)
        {     
            if (tabControl1.TabCount > 0)
            {
                foreach (messageNodeInfo currMNI in nodeList)
                {
                    if (currMNI.tNode.Name == tabControl1.SelectedTab.Text || currMNI.tNode.Text == tabControl1.SelectedTab.Text)
                    {
                       
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

        // Double clicking on a child node in tree view opens file in header/body view area
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

        // Right clicking top level node allows you to edit the top level nodes name
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeView locTree = sender as TreeView;
            Form caseOptions = new Form();
            caseOptions.Size = new Size(225, 150);
            Label NameLabel = new Label();
            Button acceptButton = new Button();
            acceptButton.Text = "OK";
            acceptButton.Width = 75;
            acceptButton.Height = 25;
            acceptButton.Location = new Point(75,75);
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

        // Only removes top level node at the moment
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

        // Exit the program, ask for conformation 
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

        // This saves the treeview to a file to be opened later
        // Does not save any of the textbox data
        // ONLY the information in the treeview nodes
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

        // Load treeview workspace 
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

        // Increasing and decreasing font size of header/body views 
        private void headerSizeInc_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Controls[0].Font.Size <= 15)
            {
                tabControl1.SelectedTab.Controls[0].Font = new Font(tabControl1.SelectedTab.Controls[0].Font.Name, tabControl1.SelectedTab.Controls[0].Font.Size + 1);
            }
        }

        private void headerSizeDec_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Controls[0].Font.Size >= 5)
            {
                tabControl1.SelectedTab.Controls[0].Font = new Font(tabControl1.SelectedTab.Controls[0].Font.Name, tabControl1.SelectedTab.Controls[0].Font.Size - 1);
            }
        }

        private void bodySizeInc_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Controls[1].Font.Size <= 15)
            {
                tabControl1.SelectedTab.Controls[1].Font = new Font(tabControl1.SelectedTab.Controls[1].Font.Name, tabControl1.SelectedTab.Controls[1].Font.Size + 1);
            }
        }

        private void bodySizeDec_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Controls[1].Font.Size >= 5)
            {
                tabControl1.SelectedTab.Controls[1].Font = new Font(tabControl1.SelectedTab.Controls[1].Font.Name, tabControl1.SelectedTab.Controls[1].Font.Size - 1);
            }
        }

        // Close all open tabs
        private void closeAllBtn_Click(object sender, EventArgs e)
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

                            }
                        }
                        tabControl1.TabPages[x - 1].Dispose();
                    }
                    closeBtn.Enabled = false;
                    button1.Enabled = false;
                    closeAllBtn.Enabled = false;
                }
            }
            
        }

        // Open seperate rulemaker form
        private void ruleMakerBtn_Click(object sender, EventArgs e)
        {
            Form RuleMaker = new FormRM();
            RuleMaker.TopMost = true;
            RuleMaker.Show();
           
        }

        // Right clicking in the header/body view brings up menu to copy selected text to domain or ip textboxes
        private void copyToIPsHeader_Click(object sender, EventArgs e)
        {
            TextBox selTextB = new TextBox();
            selTextB = (TextBox)tabControl1.SelectedTab.Controls[0];
            if (selTextB.SelectedText != string.Empty)
            {
                ipList.Text = ipList.Text + selTextB.SelectedText + "\r\n";
            }
        }

        private void copyToIPsBody_Click(object sender, EventArgs e)
        {
            TextBox selTextB = new TextBox();
            selTextB = (TextBox)tabControl1.SelectedTab.Controls[1];
            if (selTextB.SelectedText != string.Empty)
            {
                ipList.Text = ipList.Text + selTextB.SelectedText + "\r\n";
            }
        }

        private void copyToDomainsHeader_Click(object sender, EventArgs e)
        {
            TextBox selTextB = new TextBox();
            selTextB = (TextBox)tabControl1.SelectedTab.Controls[0];
            if (selTextB.SelectedText != string.Empty)
            {
                domainList.Text = domainList.Text + selTextB.SelectedText + "\r\n";
            }
        }

        private void copyToDomainsBody_Click(object sender, EventArgs e)
        {
            TextBox selTextB = new TextBox();
            selTextB = (TextBox)tabControl1.SelectedTab.Controls[1];
            if (selTextB.SelectedText != string.Empty)
            {
                domainList.Text = domainList.Text + selTextB.SelectedText + "\r\n";
            }
        }

    }
}
