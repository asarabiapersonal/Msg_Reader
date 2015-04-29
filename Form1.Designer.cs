namespace Msg_Reader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ipList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.currentTabCheck = new System.Windows.Forms.CheckBox();
            this.allTabsCheck = new System.Windows.Forms.CheckBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.closeAllBtn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNode = new System.Windows.Forms.Button();
            this.removeNode = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.markAsCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleMakerBtn = new System.Windows.Forms.Button();
            this.fromRTA = new System.Windows.Forms.RichTextBox();
            this.bodySizeInc = new System.Windows.Forms.Button();
            this.bodySizeDec = new System.Windows.Forms.Button();
            this.headerSizeInc = new System.Windows.Forms.Button();
            this.headerSizeDec = new System.Windows.Forms.Button();
            this.headerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyTextToDomainsAndIPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToIPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToDomains = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToIPsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.domainList = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.headerMenu.SuspendLayout();
            this.bodyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(279, 32);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(279, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(1208, 983);
            this.tabControl1.TabIndex = 3;
            // 
            // ipList
            // 
            this.ipList.Location = new System.Drawing.Point(1756, 58);
            this.ipList.Multiline = true;
            this.ipList.Name = "ipList";
            this.ipList.Size = new System.Drawing.Size(140, 406);
            this.ipList.TabIndex = 4;
            this.ipList.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1788, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Addresses";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(1783, 1027);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1780, 959);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Export messages to .txt";
            // 
            // currentTabCheck
            // 
            this.currentTabCheck.AutoSize = true;
            this.currentTabCheck.Checked = true;
            this.currentTabCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.currentTabCheck.Location = new System.Drawing.Point(1769, 980);
            this.currentTabCheck.Name = "currentTabCheck";
            this.currentTabCheck.Size = new System.Drawing.Size(82, 17);
            this.currentTabCheck.TabIndex = 8;
            this.currentTabCheck.Text = "Current Tab";
            this.currentTabCheck.UseVisualStyleBackColor = true;
            this.currentTabCheck.CheckedChanged += new System.EventHandler(this.currentTabCheck_CheckedChanged);
            // 
            // allTabsCheck
            // 
            this.allTabsCheck.AutoSize = true;
            this.allTabsCheck.Location = new System.Drawing.Point(1769, 1004);
            this.allTabsCheck.Name = "allTabsCheck";
            this.allTabsCheck.Size = new System.Drawing.Size(64, 17);
            this.allTabsCheck.TabIndex = 9;
            this.allTabsCheck.Text = "All Tabs";
            this.allTabsCheck.UseVisualStyleBackColor = true;
            this.allTabsCheck.CheckedChanged += new System.EventHandler(this.allTabsCheck_CheckedChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Enabled = false;
            this.closeBtn.Location = new System.Drawing.Point(1411, 27);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "Close Tab";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // closeAllBtn
            // 
            this.closeAllBtn.Enabled = false;
            this.closeAllBtn.Location = new System.Drawing.Point(1321, 27);
            this.closeAllBtn.Name = "closeAllBtn";
            this.closeAllBtn.Size = new System.Drawing.Size(75, 23);
            this.closeAllBtn.TabIndex = 11;
            this.closeAllBtn.Text = "Close All";
            this.closeAllBtn.UseVisualStyleBackColor = true;
            this.closeAllBtn.Click += new System.EventHandler(this.closeAllBtn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 57);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(245, 985);
            this.treeView1.TabIndex = 12;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // AddNode
            // 
            this.AddNode.Location = new System.Drawing.Point(12, 29);
            this.AddNode.Name = "AddNode";
            this.AddNode.Size = new System.Drawing.Size(19, 26);
            this.AddNode.TabIndex = 13;
            this.AddNode.Text = "+";
            this.AddNode.UseVisualStyleBackColor = true;
            this.AddNode.Click += new System.EventHandler(this.AddNode_Click);
            // 
            // removeNode
            // 
            this.removeNode.Location = new System.Drawing.Point(37, 29);
            this.removeNode.Name = "removeNode";
            this.removeNode.Size = new System.Drawing.Size(20, 26);
            this.removeNode.TabIndex = 14;
            this.removeNode.Text = "-";
            this.removeNode.UseVisualStyleBackColor = true;
            this.removeNode.Click += new System.EventHandler(this.removeNode_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markAsCompleteToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(161, 26);
            // 
            // markAsCompleteToolStripMenuItem
            // 
            this.markAsCompleteToolStripMenuItem.Name = "markAsCompleteToolStripMenuItem";
            this.markAsCompleteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.markAsCompleteToolStripMenuItem.Text = "Mark As Complete";
            this.markAsCompleteToolStripMenuItem.Click += new System.EventHandler(this.markAsCompleteToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWorkspaceToolStripMenuItem,
            this.saveCurrentWorkspaceToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openWorkspaceToolStripMenuItem
            // 
            this.openWorkspaceToolStripMenuItem.Name = "openWorkspaceToolStripMenuItem";
            this.openWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openWorkspaceToolStripMenuItem.Text = "Open Workspace";
            this.openWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.openWorkspaceToolStripMenuItem_Click);
            // 
            // saveCurrentWorkspaceToolStripMenuItem
            // 
            this.saveCurrentWorkspaceToolStripMenuItem.Name = "saveCurrentWorkspaceToolStripMenuItem";
            this.saveCurrentWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveCurrentWorkspaceToolStripMenuItem.Text = "Save Current Workspace";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // ruleMakerBtn
            // 
            this.ruleMakerBtn.Location = new System.Drawing.Point(371, 31);
            this.ruleMakerBtn.Name = "ruleMakerBtn";
            this.ruleMakerBtn.Size = new System.Drawing.Size(75, 23);
            this.ruleMakerBtn.TabIndex = 18;
            this.ruleMakerBtn.Text = "RuleMaker";
            this.ruleMakerBtn.UseVisualStyleBackColor = true;
            this.ruleMakerBtn.Click += new System.EventHandler(this.ruleMakerBtn_Click);
            // 
            // fromRTA
            // 
            this.fromRTA.Location = new System.Drawing.Point(1508, 57);
            this.fromRTA.Name = "fromRTA";
            this.fromRTA.Size = new System.Drawing.Size(232, 301);
            this.fromRTA.TabIndex = 19;
            this.fromRTA.Text = "";
            this.fromRTA.WordWrap = false;
            // 
            // bodySizeInc
            // 
            this.bodySizeInc.Enabled = false;
            this.bodySizeInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodySizeInc.Location = new System.Drawing.Point(857, 1046);
            this.bodySizeInc.Name = "bodySizeInc";
            this.bodySizeInc.Size = new System.Drawing.Size(35, 34);
            this.bodySizeInc.TabIndex = 20;
            this.bodySizeInc.Text = "+";
            this.bodySizeInc.UseVisualStyleBackColor = true;
            this.bodySizeInc.Click += new System.EventHandler(this.bodySizeInc_Click);
            // 
            // bodySizeDec
            // 
            this.bodySizeDec.Enabled = false;
            this.bodySizeDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodySizeDec.Location = new System.Drawing.Point(898, 1046);
            this.bodySizeDec.Name = "bodySizeDec";
            this.bodySizeDec.Size = new System.Drawing.Size(35, 34);
            this.bodySizeDec.TabIndex = 20;
            this.bodySizeDec.Text = "-";
            this.bodySizeDec.UseVisualStyleBackColor = true;
            this.bodySizeDec.Click += new System.EventHandler(this.bodySizeDec_Click);
            // 
            // headerSizeInc
            // 
            this.headerSizeInc.Enabled = false;
            this.headerSizeInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerSizeInc.Location = new System.Drawing.Point(1411, 1046);
            this.headerSizeInc.Name = "headerSizeInc";
            this.headerSizeInc.Size = new System.Drawing.Size(33, 35);
            this.headerSizeInc.TabIndex = 21;
            this.headerSizeInc.Text = "+";
            this.headerSizeInc.UseVisualStyleBackColor = true;
            this.headerSizeInc.Click += new System.EventHandler(this.headerSizeInc_Click);
            // 
            // headerSizeDec
            // 
            this.headerSizeDec.Enabled = false;
            this.headerSizeDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerSizeDec.Location = new System.Drawing.Point(1450, 1046);
            this.headerSizeDec.Name = "headerSizeDec";
            this.headerSizeDec.Size = new System.Drawing.Size(37, 35);
            this.headerSizeDec.TabIndex = 22;
            this.headerSizeDec.Text = "-";
            this.headerSizeDec.UseVisualStyleBackColor = true;
            this.headerSizeDec.Click += new System.EventHandler(this.headerSizeDec_Click);
            // 
            // headerMenu
            // 
            this.headerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyTextToDomainsAndIPsToolStripMenuItem,
            this.copyToIPsToolStripMenuItem});
            this.headerMenu.Name = "headerMenu";
            this.headerMenu.Size = new System.Drawing.Size(156, 48);
            // 
            // copyTextToDomainsAndIPsToolStripMenuItem
            // 
            this.copyTextToDomainsAndIPsToolStripMenuItem.Name = "copyTextToDomainsAndIPsToolStripMenuItem";
            this.copyTextToDomainsAndIPsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.copyTextToDomainsAndIPsToolStripMenuItem.Text = "Copy to Domains";
            this.copyTextToDomainsAndIPsToolStripMenuItem.Click += new System.EventHandler(this.copyToDomainsHeader_Click);
            // 
            // copyToIPsToolStripMenuItem
            // 
            this.copyToIPsToolStripMenuItem.Name = "copyToIPsToolStripMenuItem";
            this.copyToIPsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.copyToIPsToolStripMenuItem.Text = "Copy to IPs";
            this.copyToIPsToolStripMenuItem.Click += new System.EventHandler(this.copyToIPsHeader_Click);
            // 
            // bodyMenu
            // 
            this.bodyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToDomains,
            this.copyToIPsToolStripMenuItem1});
            this.bodyMenu.Name = "contextMenuStrip3";
            this.bodyMenu.Size = new System.Drawing.Size(156, 48);
            // 
            // copyToDomains
            // 
            this.copyToDomains.Name = "copyToDomains";
            this.copyToDomains.Size = new System.Drawing.Size(155, 22);
            this.copyToDomains.Text = "Copy to Domains";
            this.copyToDomains.Click += new System.EventHandler(this.copyToDomainsBody_Click);
            // 
            // copyToIPsToolStripMenuItem1
            // 
            this.copyToIPsToolStripMenuItem1.Name = "copyToIPsToolStripMenuItem1";
            this.copyToIPsToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.copyToIPsToolStripMenuItem1.Text = "Copy to IPs";
            this.copyToIPsToolStripMenuItem1.Click += new System.EventHandler(this.copyToIPsBody_Click);
            // 
            // domainList
            // 
            this.domainList.Location = new System.Drawing.Point(1759, 492);
            this.domainList.Multiline = true;
            this.domainList.Name = "domainList";
            this.domainList.Size = new System.Drawing.Size(139, 430);
            this.domainList.TabIndex = 23;
            this.domainList.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1803, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Domains";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1588, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Rules to Add";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1505, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "From:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1505, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Subject:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1505, 729);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Body";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1508, 378);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(232, 348);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(1508, 745);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(232, 296);
            this.richTextBox2.TabIndex = 32;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1081);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.domainList);
            this.Controls.Add(this.headerSizeDec);
            this.Controls.Add(this.headerSizeInc);
            this.Controls.Add(this.bodySizeDec);
            this.Controls.Add(this.bodySizeInc);
            this.Controls.Add(this.fromRTA);
            this.Controls.Add(this.ruleMakerBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.removeNode);
            this.Controls.Add(this.AddNode);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.closeAllBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.allTabsCheck);
            this.Controls.Add(this.currentTabCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipList);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spam Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.headerMenu.ResumeLayout(false);
            this.bodyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox ipList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage myTab;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox currentTabCheck;
        private System.Windows.Forms.CheckBox allTabsCheck;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button closeAllBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button AddNode;
        private System.Windows.Forms.Button removeNode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem markAsCompleteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button ruleMakerBtn;
        private System.Windows.Forms.RichTextBox fromRTA;
        private System.Windows.Forms.Button bodySizeInc;
        private System.Windows.Forms.Button bodySizeDec;
        private System.Windows.Forms.Button headerSizeInc;
        private System.Windows.Forms.Button headerSizeDec;
        private System.Windows.Forms.ContextMenuStrip headerMenu;
        private System.Windows.Forms.ToolStripMenuItem copyTextToDomainsAndIPsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip bodyMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToDomains;
        private System.Windows.Forms.TextBox domainList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ToolStripMenuItem copyToIPsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToIPsToolStripMenuItem1;
    }
}

