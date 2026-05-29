namespace Contacts_winForm
{
    partial class Form_addedit
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
            this.firstttt_name = new System.Windows.Forms.Label();
            this.emaillll = new System.Windows.Forms.Label();
            this.last_nalllme = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phoooone = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idddddddd = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(336, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // firstttt_name
            // 
            this.firstttt_name.AutoSize = true;
            this.firstttt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.firstttt_name.Location = new System.Drawing.Point(51, 182);
            this.firstttt_name.Name = "firstttt_name";
            this.firstttt_name.Size = new System.Drawing.Size(119, 26);
            this.firstttt_name.TabIndex = 2;
            this.firstttt_name.Text = "First Name";
            // 
            // emaillll
            // 
            this.emaillll.AutoSize = true;
            this.emaillll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.emaillll.Location = new System.Drawing.Point(51, 327);
            this.emaillll.Name = "emaillll";
            this.emaillll.Size = new System.Drawing.Size(68, 26);
            this.emaillll.TabIndex = 4;
            this.emaillll.Text = "Email";
            this.emaillll.Click += new System.EventHandler(this.label4_Click);
            // 
            // last_nalllme
            // 
            this.last_nalllme.AutoSize = true;
            this.last_nalllme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.last_nalllme.Location = new System.Drawing.Point(51, 245);
            this.last_nalllme.Name = "last_nalllme";
            this.last_nalllme.Size = new System.Drawing.Size(118, 26);
            this.last_nalllme.TabIndex = 3;
            this.last_nalllme.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(51, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Country";
            // 
            // phoooone
            // 
            this.phoooone.AutoSize = true;
            this.phoooone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.phoooone.Location = new System.Drawing.Point(51, 390);
            this.phoooone.Name = "phoooone";
            this.phoooone.Size = new System.Drawing.Size(75, 26);
            this.phoooone.TabIndex = 5;
            this.phoooone.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Address";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(244, 97);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 8;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(244, 179);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(100, 20);
            this.txtfirstname.TabIndex = 9;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(244, 245);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(100, 20);
            this.txtlastname.TabIndex = 10;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(244, 390);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 20);
            this.txtphone.TabIndex = 12;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(244, 327);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 11;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(244, 535);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 20);
            this.txtaddress.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(592, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 72);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(385, 584);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 72);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idddddddd
            // 
            this.idddddddd.AutoSize = true;
            this.idddddddd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.idddddddd.Location = new System.Drawing.Point(51, 100);
            this.idddddddd.Name = "idddddddd";
            this.idddddddd.Size = new System.Drawing.Size(34, 26);
            this.idddddddd.TabIndex = 2;
            this.idddddddd.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 472);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // Form_addedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 668);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoooone);
            this.Controls.Add(this.emaillll);
            this.Controls.Add(this.last_nalllme);
            this.Controls.Add(this.idddddddd);
            this.Controls.Add(this.firstttt_name);
            this.Controls.Add(this.label1);
            this.Name = "Form_addedit";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_addedit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstttt_name;
        private System.Windows.Forms.Label emaillll;
        private System.Windows.Forms.Label last_nalllme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label phoooone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label idddddddd;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}