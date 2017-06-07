namespace Store
{
    partial class CreateLogin
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
            this.bttnCreateLogin = new System.Windows.Forms.Button();
            this.Lbl_Username = new System.Windows.Forms.Label();
            this.txtbxUsernameNew = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtbxPasswordNew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnCreateLogin
            // 
            this.bttnCreateLogin.Location = new System.Drawing.Point(88, 205);
            this.bttnCreateLogin.Name = "bttnCreateLogin";
            this.bttnCreateLogin.Size = new System.Drawing.Size(103, 44);
            this.bttnCreateLogin.TabIndex = 0;
            this.bttnCreateLogin.Text = "Create Account";
            this.bttnCreateLogin.UseVisualStyleBackColor = true;
            this.bttnCreateLogin.Click += new System.EventHandler(this.bttnCreateLogin_Click);
            // 
            // Lbl_Username
            // 
            this.Lbl_Username.AutoSize = true;
            this.Lbl_Username.Location = new System.Drawing.Point(26, 25);
            this.Lbl_Username.Name = "Lbl_Username";
            this.Lbl_Username.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Username.TabIndex = 1;
            this.Lbl_Username.Text = "Username";
            // 
            // txtbxUsernameNew
            // 
            this.txtbxUsernameNew.Location = new System.Drawing.Point(95, 25);
            this.txtbxUsernameNew.Name = "txtbxUsernameNew";
            this.txtbxUsernameNew.Size = new System.Drawing.Size(95, 20);
            this.txtbxUsernameNew.TabIndex = 2;
            this.txtbxUsernameNew.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(26, 75);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password";
            // 
            // txtbxPasswordNew
            // 
            this.txtbxPasswordNew.Location = new System.Drawing.Point(96, 72);
            this.txtbxPasswordNew.Name = "txtbxPasswordNew";
            this.txtbxPasswordNew.PasswordChar = '*';
            this.txtbxPasswordNew.Size = new System.Drawing.Size(95, 20);
            this.txtbxPasswordNew.TabIndex = 4;
            this.txtbxPasswordNew.UseSystemPasswordChar = true;
            // 
            // CreateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtbxPasswordNew);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txtbxUsernameNew);
            this.Controls.Add(this.Lbl_Username);
            this.Controls.Add(this.bttnCreateLogin);
            this.Name = "CreateLogin";
            this.Text = "CreateLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnCreateLogin;
        private System.Windows.Forms.Label Lbl_Username;
        private System.Windows.Forms.TextBox txtbxUsernameNew;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtbxPasswordNew;
    }
}