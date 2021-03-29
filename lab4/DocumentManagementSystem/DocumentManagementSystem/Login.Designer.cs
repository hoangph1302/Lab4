namespace DocumentManagementSystem
{
    partial class Login
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbWrongAccount = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbPW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(299, 148);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(212, 22);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(299, 198);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.PasswordChar = '*';
            this.textBoxPW.Size = new System.Drawing.Size(212, 22);
            this.textBoxPW.TabIndex = 3;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(347, 252);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(123, 28);
            this.btLogin.TabIndex = 7;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbWrongAccount
            // 
            this.lbWrongAccount.AutoSize = true;
            this.lbWrongAccount.ForeColor = System.Drawing.Color.Red;
            this.lbWrongAccount.Location = new System.Drawing.Point(268, 294);
            this.lbWrongAccount.Name = "lbWrongAccount";
            this.lbWrongAccount.Size = new System.Drawing.Size(279, 17);
            this.lbWrongAccount.TabIndex = 8;
            this.lbWrongAccount.Text = "ID or password is wrong. Try again, please!";
            this.lbWrongAccount.Visible = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(177, 151);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(55, 17);
            this.lbID.TabIndex = 9;
            this.lbID.Text = "Your ID";
            // 
            // lbPW
            // 
            this.lbPW.AutoSize = true;
            this.lbPW.Location = new System.Drawing.Point(177, 201);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(69, 17);
            this.lbPW.TabIndex = 10;
            this.lbPW.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPW);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbWrongAccount);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxID);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbWrongAccount;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPW;
    }
}