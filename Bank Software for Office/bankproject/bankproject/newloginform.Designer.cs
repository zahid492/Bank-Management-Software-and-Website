namespace bankproject
{
    partial class newloginform
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.manageridtextBox3 = new System.Windows.Forms.TextBox();
            this.manager_passwordtextBox4 = new System.Windows.Forms.TextBox();
            this.infolabel = new System.Windows.Forms.Label();
            this.useridtextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(252, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(333, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manager Userid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Manager Password";
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(166, 93);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(183, 20);
            this.usernametextBox.TabIndex = 6;
            // 
            // passwordtextBox2
            // 
            this.passwordtextBox2.Location = new System.Drawing.Point(166, 138);
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.PasswordChar = '●';
            this.passwordtextBox2.Size = new System.Drawing.Size(183, 20);
            this.passwordtextBox2.TabIndex = 7;
            // 
            // manageridtextBox3
            // 
            this.manageridtextBox3.Location = new System.Drawing.Point(166, 188);
            this.manageridtextBox3.Name = "manageridtextBox3";
            this.manageridtextBox3.Size = new System.Drawing.Size(183, 20);
            this.manageridtextBox3.TabIndex = 8;
            // 
            // manager_passwordtextBox4
            // 
            this.manager_passwordtextBox4.Location = new System.Drawing.Point(165, 228);
            this.manager_passwordtextBox4.Name = "manager_passwordtextBox4";
            this.manager_passwordtextBox4.PasswordChar = '●';
            this.manager_passwordtextBox4.Size = new System.Drawing.Size(184, 20);
            this.manager_passwordtextBox4.TabIndex = 9;
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infolabel.Location = new System.Drawing.Point(149, 291);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(230, 20);
            this.infolabel.TabIndex = 16;
            this.infolabel.Text = "Wrong login info is provided";
            // 
            // useridtextBox1
            // 
            this.useridtextBox1.Location = new System.Drawing.Point(166, 47);
            this.useridtextBox1.Name = "useridtextBox1";
            this.useridtextBox1.Size = new System.Drawing.Size(183, 20);
            this.useridtextBox1.TabIndex = 18;
            this.useridtextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.useridtextBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Employee Id";
            // 
            // newloginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 368);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.useridtextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.manager_passwordtextBox4);
            this.Controls.Add(this.manageridtextBox3);
            this.Controls.Add(this.passwordtextBox2);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "newloginform";
            this.Text = "newloginform";
            this.Load += new System.EventHandler(this.newloginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox passwordtextBox2;
        private System.Windows.Forms.TextBox manageridtextBox3;
        private System.Windows.Forms.TextBox manager_passwordtextBox4;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.TextBox useridtextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}