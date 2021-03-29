namespace DocumentManagementSystem
{
    partial class HomePage
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePermissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forGroup3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forGroup2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forGroup1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePermissionOfUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btCmt = new System.Windows.Forms.Button();
            this.textBoxListCmt = new System.Windows.Forms.TextBox();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.textBoxCmt = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btDownload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btReload = new System.Windows.Forms.Button();
            this.groupBoxUpload = new System.Windows.Forms.GroupBox();
            this.btUpload = new System.Windows.Forms.Button();
            this.buttonBrowser = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.lbShare = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.btCheck = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managerToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listToolStripMenuItem,
            this.createANewFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listToolStripMenuItem.Text = "Refresh files";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // createANewFileToolStripMenuItem
            // 
            this.createANewFileToolStripMenuItem.Name = "createANewFileToolStripMenuItem";
            this.createANewFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.createANewFileToolStripMenuItem.Text = "Create a new file";
            this.createANewFileToolStripMenuItem.Click += new System.EventHandler(this.createANewFileToolStripMenuItem_Click);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFileToolStripMenuItem,
            this.changePermissionToolStripMenuItem,
            this.changePermissionOfUserToolStripMenuItem});
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managerToolStripMenuItem.Text = "Management";
            this.managerToolStripMenuItem.Visible = false;
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.deleteFileToolStripMenuItem.Text = "Delete file";
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // changePermissionToolStripMenuItem
            // 
            this.changePermissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forGroup3ToolStripMenuItem,
            this.forGroup2ToolStripMenuItem,
            this.forGroup1ToolStripMenuItem,
            this.privateToolStripMenuItem});
            this.changePermissionToolStripMenuItem.Name = "changePermissionToolStripMenuItem";
            this.changePermissionToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.changePermissionToolStripMenuItem.Text = "Change permission of selected file";
            // 
            // forGroup3ToolStripMenuItem
            // 
            this.forGroup3ToolStripMenuItem.Name = "forGroup3ToolStripMenuItem";
            this.forGroup3ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.forGroup3ToolStripMenuItem.Text = "for group 3";
            this.forGroup3ToolStripMenuItem.Click += new System.EventHandler(this.forGroup3ToolStripMenuItem_Click);
            // 
            // forGroup2ToolStripMenuItem
            // 
            this.forGroup2ToolStripMenuItem.Name = "forGroup2ToolStripMenuItem";
            this.forGroup2ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.forGroup2ToolStripMenuItem.Text = "for group 2";
            this.forGroup2ToolStripMenuItem.Click += new System.EventHandler(this.forGroup2ToolStripMenuItem_Click);
            // 
            // forGroup1ToolStripMenuItem
            // 
            this.forGroup1ToolStripMenuItem.Name = "forGroup1ToolStripMenuItem";
            this.forGroup1ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.forGroup1ToolStripMenuItem.Text = "for group 1";
            this.forGroup1ToolStripMenuItem.Click += new System.EventHandler(this.forGroup1ToolStripMenuItem_Click);
            // 
            // privateToolStripMenuItem
            // 
            this.privateToolStripMenuItem.Name = "privateToolStripMenuItem";
            this.privateToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.privateToolStripMenuItem.Text = "private";
            this.privateToolStripMenuItem.Click += new System.EventHandler(this.privateToolStripMenuItem_Click);
            // 
            // changePermissionOfUserToolStripMenuItem
            // 
            this.changePermissionOfUserToolStripMenuItem.Name = "changePermissionOfUserToolStripMenuItem";
            this.changePermissionOfUserToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.changePermissionOfUserToolStripMenuItem.Text = "Change permission of user";
            this.changePermissionOfUserToolStripMenuItem.Click += new System.EventHandler(this.changePermissionOfUserToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(20, 45);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(726, 325);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shared files with me";
            // 
            // btCmt
            // 
            this.btCmt.Location = new System.Drawing.Point(649, 552);
            this.btCmt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCmt.Name = "btCmt";
            this.btCmt.Size = new System.Drawing.Size(97, 24);
            this.btCmt.TabIndex = 19;
            this.btCmt.Text = "Comment";
            this.btCmt.UseVisualStyleBackColor = true;
            this.btCmt.Visible = false;
            this.btCmt.Click += new System.EventHandler(this.btCmt_Click);
            // 
            // textBoxListCmt
            // 
            this.textBoxListCmt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxListCmt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxListCmt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxListCmt.Location = new System.Drawing.Point(9, 442);
            this.textBoxListCmt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxListCmt.Multiline = true;
            this.textBoxListCmt.Name = "textBoxListCmt";
            this.textBoxListCmt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxListCmt.Size = new System.Drawing.Size(738, 101);
            this.textBoxListCmt.TabIndex = 20;
            this.textBoxListCmt.Visible = false;
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(658, 334);
            this.btOpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(87, 24);
            this.btOpenFile.TabIndex = 21;
            this.btOpenFile.Text = "Open";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(6, 22);
            this.axAcroPDF1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(745, 382);
            this.axAcroPDF1.TabIndex = 22;
            this.axAcroPDF1.Visible = false;
            // 
            // textBoxCmt
            // 
            this.textBoxCmt.Location = new System.Drawing.Point(9, 552);
            this.textBoxCmt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCmt.Multiline = true;
            this.textBoxCmt.Name = "textBoxCmt";
            this.textBoxCmt.Size = new System.Drawing.Size(636, 25);
            this.textBoxCmt.TabIndex = 24;
            this.textBoxCmt.Visible = false;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(668, 414);
            this.btClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(78, 24);
            this.btClose.TabIndex = 25;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Visible = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click_1);
            // 
            // btDownload
            // 
            this.btDownload.Location = new System.Drawing.Point(585, 414);
            this.btDownload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(78, 24);
            this.btDownload.TabIndex = 26;
            this.btDownload.Text = "Download";
            this.btDownload.UseVisualStyleBackColor = true;
            this.btDownload.Visible = false;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(415, 414);
            this.btEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(78, 24);
            this.btEdit.TabIndex = 28;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Visible = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btReload
            // 
            this.btReload.Location = new System.Drawing.Point(497, 414);
            this.btReload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(83, 24);
            this.btReload.TabIndex = 29;
            this.btReload.Text = "Reload";
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Visible = false;
            this.btReload.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // groupBoxUpload
            // 
            this.groupBoxUpload.Controls.Add(this.btUpload);
            this.groupBoxUpload.Controls.Add(this.buttonBrowser);
            this.groupBoxUpload.Controls.Add(this.textBoxPath);
            this.groupBoxUpload.Controls.Add(this.textBoxFileName);
            this.groupBoxUpload.Controls.Add(this.comboBoxGroup);
            this.groupBoxUpload.Controls.Add(this.lbShare);
            this.groupBoxUpload.Controls.Add(this.label2);
            this.groupBoxUpload.Controls.Add(this.lbFileName);
            this.groupBoxUpload.Location = new System.Drawing.Point(0, 24);
            this.groupBoxUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxUpload.Name = "groupBoxUpload";
            this.groupBoxUpload.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxUpload.Size = new System.Drawing.Size(753, 413);
            this.groupBoxUpload.TabIndex = 30;
            this.groupBoxUpload.TabStop = false;
            this.groupBoxUpload.Visible = false;
            // 
            // btUpload
            // 
            this.btUpload.Location = new System.Drawing.Point(325, 261);
            this.btUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btUpload.Name = "btUpload";
            this.btUpload.Size = new System.Drawing.Size(62, 24);
            this.btUpload.TabIndex = 8;
            this.btUpload.Text = "Upload";
            this.btUpload.UseVisualStyleBackColor = true;
            this.btUpload.Click += new System.EventHandler(this.btUpload_Click);
            // 
            // buttonBrowser
            // 
            this.buttonBrowser.Location = new System.Drawing.Point(488, 106);
            this.buttonBrowser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBrowser.Name = "buttonBrowser";
            this.buttonBrowser.Size = new System.Drawing.Size(62, 24);
            this.buttonBrowser.TabIndex = 7;
            this.buttonBrowser.Text = "Browser...";
            this.buttonBrowser.UseVisualStyleBackColor = true;
            this.buttonBrowser.Click += new System.EventHandler(this.buttonBrowser_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(177, 75);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(374, 20);
            this.textBoxPath.TabIndex = 6;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(177, 177);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(154, 20);
            this.textBoxFileName.TabIndex = 5;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Items.AddRange(new object[] {
            "group 1",
            "group 2",
            "group 3",
            "not share"});
            this.comboBoxGroup.Location = new System.Drawing.Point(459, 176);
            this.comboBoxGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(92, 21);
            this.comboBoxGroup.TabIndex = 4;
            // 
            // lbShare
            // 
            this.lbShare.AutoSize = true;
            this.lbShare.Location = new System.Drawing.Point(392, 178);
            this.lbShare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbShare.Name = "lbShare";
            this.lbShare.Size = new System.Drawing.Size(47, 13);
            this.lbShare.TabIndex = 3;
            this.lbShare.Text = "Share to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path";
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(81, 177);
            this.lbFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(54, 13);
            this.lbFileName.TabIndex = 0;
            this.lbFileName.Text = "File Name";
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(623, 506);
            this.btCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(98, 27);
            this.btCheck.TabIndex = 9;
            this.btCheck.Text = "checkCode";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.groupBoxUpload);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btDownload);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.textBoxCmt);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.textBoxListCmt);
            this.Controls.Add(this.btCmt);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxUpload.ResumeLayout(false);
            this.groupBoxUpload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewFileToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCmt;
        private System.Windows.Forms.TextBox textBoxListCmt;
        private System.Windows.Forms.Button btOpenFile;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.TextBox textBoxCmt;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.GroupBox groupBoxUpload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label lbShare;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button btUpload;
        private System.Windows.Forms.Button buttonBrowser;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePermissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forGroup3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forGroup2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forGroup1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePermissionOfUserToolStripMenuItem;
    }
}