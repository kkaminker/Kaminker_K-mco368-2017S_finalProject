namespace Store
{
    partial class CustInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_fname = new System.Windows.Forms.TextBox();
            this.txtbx_lname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_city = new System.Windows.Forms.TextBox();
            this.txtbx_street = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_zip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_phone = new System.Windows.Forms.TextBox();
            this.bttn_custInfoSubmit = new System.Windows.Forms.Button();
            this.comboBox_state = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // txtbx_fname
            // 
            this.txtbx_fname.Location = new System.Drawing.Point(92, 17);
            this.txtbx_fname.Name = "txtbx_fname";
            this.txtbx_fname.Size = new System.Drawing.Size(83, 20);
            this.txtbx_fname.TabIndex = 2;
            // 
            // txtbx_lname
            // 
            this.txtbx_lname.Location = new System.Drawing.Point(92, 58);
            this.txtbx_lname.Name = "txtbx_lname";
            this.txtbx_lname.Size = new System.Drawing.Size(83, 20);
            this.txtbx_lname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "State";
            // 
            // txtbx_city
            // 
            this.txtbx_city.Location = new System.Drawing.Point(92, 143);
            this.txtbx_city.Name = "txtbx_city";
            this.txtbx_city.Size = new System.Drawing.Size(83, 20);
            this.txtbx_city.TabIndex = 12;
            // 
            // txtbx_street
            // 
            this.txtbx_street.Location = new System.Drawing.Point(92, 110);
            this.txtbx_street.Name = "txtbx_street";
            this.txtbx_street.Size = new System.Drawing.Size(83, 20);
            this.txtbx_street.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Zip Code";
            // 
            // txtbx_zip
            // 
            this.txtbx_zip.Location = new System.Drawing.Point(170, 186);
            this.txtbx_zip.Name = "txtbx_zip";
            this.txtbx_zip.Size = new System.Drawing.Size(83, 20);
            this.txtbx_zip.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone Number";
            // 
            // txtbx_phone
            // 
            this.txtbx_phone.Location = new System.Drawing.Point(96, 227);
            this.txtbx_phone.Name = "txtbx_phone";
            this.txtbx_phone.Size = new System.Drawing.Size(83, 20);
            this.txtbx_phone.TabIndex = 17;
            // 
            // bttn_custInfoSubmit
            // 
            this.bttn_custInfoSubmit.Location = new System.Drawing.Point(92, 270);
            this.bttn_custInfoSubmit.Name = "bttn_custInfoSubmit";
            this.bttn_custInfoSubmit.Size = new System.Drawing.Size(92, 31);
            this.bttn_custInfoSubmit.TabIndex = 18;
            this.bttn_custInfoSubmit.Text = "Submit";
            this.bttn_custInfoSubmit.UseVisualStyleBackColor = true;
            this.bttn_custInfoSubmit.Click += new System.EventHandler(this.bttn_custInfoSubmit_Click);
            // 
            // comboBox_state
            // 
            this.comboBox_state.FormattingEnabled = true;
            this.comboBox_state.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.comboBox_state.Location = new System.Drawing.Point(46, 186);
            this.comboBox_state.Name = "comboBox_state";
            this.comboBox_state.Size = new System.Drawing.Size(54, 21);
            this.comboBox_state.TabIndex = 19;
            // 
            // CustInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 313);
            this.Controls.Add(this.comboBox_state);
            this.Controls.Add(this.bttn_custInfoSubmit);
            this.Controls.Add(this.txtbx_phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_zip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_street);
            this.Controls.Add(this.txtbx_city);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbx_lname);
            this.Controls.Add(this.txtbx_fname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustInfo";
            this.Text = "Customer Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_fname;
        private System.Windows.Forms.TextBox txtbx_lname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_city;
        private System.Windows.Forms.TextBox txtbx_street;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_zip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_phone;
        private System.Windows.Forms.Button bttn_custInfoSubmit;
        private System.Windows.Forms.ComboBox comboBox_state;
    }
}