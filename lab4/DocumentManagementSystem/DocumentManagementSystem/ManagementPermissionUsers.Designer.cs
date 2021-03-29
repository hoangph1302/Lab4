namespace DocumentManagementSystem
{
    partial class ManagementPermissionUsers
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeGroupToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolChangeToGroup1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolChangeToGroup2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolChangeToGroup3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toopEnableEdittingGroup1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toopUnableEdittingGroup1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toopEnableEdittingGroup2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toopEnableEdittingGroup3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toopUnableEdittingGroup2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toopUnableEdittingGroup3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(18, 17);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(762, 270);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeGroupToToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 52);
            // 
            // changeGroupToToolStripMenuItem
            // 
            this.changeGroupToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolChangeToGroup1,
            this.toolChangeToGroup2,
            this.toolChangeToGroup3});
            this.changeGroupToToolStripMenuItem.Name = "changeGroupToToolStripMenuItem";
            this.changeGroupToToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.changeGroupToToolStripMenuItem.Text = "Change Group to";
            // 
            // toolChangeToGroup1
            // 
            this.toolChangeToGroup1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toopEnableEdittingGroup1,
            this.toopUnableEdittingGroup1});
            this.toolChangeToGroup1.Name = "toolChangeToGroup1";
            this.toolChangeToGroup1.Size = new System.Drawing.Size(216, 26);
            this.toolChangeToGroup1.Text = "1";
            // 
            // toolChangeToGroup2
            // 
            this.toolChangeToGroup2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toopEnableEdittingGroup2,
            this.toopUnableEdittingGroup2});
            this.toolChangeToGroup2.Name = "toolChangeToGroup2";
            this.toolChangeToGroup2.Size = new System.Drawing.Size(216, 26);
            this.toolChangeToGroup2.Text = "2";
            this.toolChangeToGroup2.Click += new System.EventHandler(this.toolChangeToGroup2_Click);
            // 
            // toolChangeToGroup3
            // 
            this.toolChangeToGroup3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toopEnableEdittingGroup3,
            this.toopUnableEdittingGroup3});
            this.toolChangeToGroup3.Name = "toolChangeToGroup3";
            this.toolChangeToGroup3.Size = new System.Drawing.Size(216, 26);
            this.toolChangeToGroup3.Text = "3";
            // 
            // toopEnableEdittingGroup1
            // 
            this.toopEnableEdittingGroup1.Name = "toopEnableEdittingGroup1";
            this.toopEnableEdittingGroup1.Size = new System.Drawing.Size(216, 26);
            this.toopEnableEdittingGroup1.Text = "Enable Editing";
            this.toopEnableEdittingGroup1.Click += new System.EventHandler(this.toopEnableEdittingGroup1_Click);
            // 
            // toopUnableEdittingGroup1
            // 
            this.toopUnableEdittingGroup1.Name = "toopUnableEdittingGroup1";
            this.toopUnableEdittingGroup1.Size = new System.Drawing.Size(216, 26);
            this.toopUnableEdittingGroup1.Text = "Unable Editing";
            this.toopUnableEdittingGroup1.Click += new System.EventHandler(this.toopUnableEdittingGroup1_Click);
            // 
            // toopEnableEdittingGroup2
            // 
            this.toopEnableEdittingGroup2.Name = "toopEnableEdittingGroup2";
            this.toopEnableEdittingGroup2.Size = new System.Drawing.Size(216, 26);
            this.toopEnableEdittingGroup2.Text = "Enable Editing";
            this.toopEnableEdittingGroup2.Click += new System.EventHandler(this.toopEnableEdittingGroup2_Click);
            // 
            // toopEnableEdittingGroup3
            // 
            this.toopEnableEdittingGroup3.Name = "toopEnableEdittingGroup3";
            this.toopEnableEdittingGroup3.Size = new System.Drawing.Size(216, 26);
            this.toopEnableEdittingGroup3.Text = "Enable Editing";
            this.toopEnableEdittingGroup3.Click += new System.EventHandler(this.toopEnableEdittingGroup3_Click);
            // 
            // toopUnableEdittingGroup2
            // 
            this.toopUnableEdittingGroup2.Name = "toopUnableEdittingGroup2";
            this.toopUnableEdittingGroup2.Size = new System.Drawing.Size(216, 26);
            this.toopUnableEdittingGroup2.Text = "Unable Editing";
            this.toopUnableEdittingGroup2.Click += new System.EventHandler(this.toopUnableEdittingGroup2_Click);
            // 
            // toopUnableEdittingGroup3
            // 
            this.toopUnableEdittingGroup3.Name = "toopUnableEdittingGroup3";
            this.toopUnableEdittingGroup3.Size = new System.Drawing.Size(216, 26);
            this.toopUnableEdittingGroup3.Text = "Unable Editing";
            this.toopUnableEdittingGroup3.Click += new System.EventHandler(this.toopUnableEdittingGroup3_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 316);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(598, 120);
            this.textBox1.TabIndex = 4;
            // 
            // ManagementPermissionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "ManagementPermissionUsers";
            this.Text = "ManagementPermissionUsers";
            this.Load += new System.EventHandler(this.ManagementPermissionUsers_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeGroupToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolChangeToGroup1;
        private System.Windows.Forms.ToolStripMenuItem toolChangeToGroup2;
        private System.Windows.Forms.ToolStripMenuItem toolChangeToGroup3;
        private System.Windows.Forms.ToolStripMenuItem toopEnableEdittingGroup1;
        private System.Windows.Forms.ToolStripMenuItem toopUnableEdittingGroup1;
        private System.Windows.Forms.ToolStripMenuItem toopEnableEdittingGroup2;
        private System.Windows.Forms.ToolStripMenuItem toopEnableEdittingGroup3;
        private System.Windows.Forms.ToolStripMenuItem toopUnableEdittingGroup2;
        private System.Windows.Forms.ToolStripMenuItem toopUnableEdittingGroup3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}