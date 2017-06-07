namespace Store
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
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.UsernameLogin = new System.Windows.Forms.Label();
            this.PasswordLogin = new System.Windows.Forms.Label();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.bttnNewUser = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(91, 49);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtbxUsername.TabIndex = 0;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(91, 105);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtbxPassword.TabIndex = 1;
            this.txtbxPassword.UseSystemPasswordChar = true;
            // 
            // UsernameLogin
            // 
            this.UsernameLogin.AutoSize = true;
            this.UsernameLogin.Location = new System.Drawing.Point(27, 49);
            this.UsernameLogin.Name = "UsernameLogin";
            this.UsernameLogin.Size = new System.Drawing.Size(55, 13);
            this.UsernameLogin.TabIndex = 2;
            this.UsernameLogin.Text = "Username";
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.AutoSize = true;
            this.PasswordLogin.Location = new System.Drawing.Point(29, 105);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.Size = new System.Drawing.Size(53, 13);
            this.PasswordLogin.TabIndex = 3;
            this.PasswordLogin.Text = "Password";
            // 
            // bttnLogin
            // 
            this.bttnLogin.Location = new System.Drawing.Point(105, 180);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(86, 44);
            this.bttnLogin.TabIndex = 4;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = true;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // bttnNewUser
            // 
            this.bttnNewUser.Location = new System.Drawing.Point(105, 230);
            this.bttnNewUser.Name = "bttnNewUser";
            this.bttnNewUser.Size = new System.Drawing.Size(86, 23);
            this.bttnNewUser.TabIndex = 5;
            this.bttnNewUser.Text = "New User";
            this.bttnNewUser.UseVisualStyleBackColor = true;
            this.bttnNewUser.Click += new System.EventHandler(this.bttnNewUser_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(126, 147);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.bttnNewUser);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.PasswordLogin);
            this.Controls.Add(this.UsernameLogin);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxUsername);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Label UsernameLogin;
        private System.Windows.Forms.Label PasswordLogin;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Button bttnNewUser;
        private System.Windows.Forms.Label lblResult;
    }
}

