namespace bankproject
{
    partial class manager_login
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.loginbutton1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.infolabel3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(208, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginbutton1
            // 
            this.loginbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton1.Location = new System.Drawing.Point(97, 188);
            this.loginbutton1.Name = "loginbutton1";
            this.loginbutton1.Size = new System.Drawing.Size(75, 23);
            this.loginbutton1.TabIndex = 10;
            this.loginbutton1.Text = "Login";
            this.loginbutton1.UseVisualStyleBackColor = true;
            this.loginbutton1.Click += new System.EventHandler(this.loginbutton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "UserName";
            // 
            // infolabel3
            // 
            this.infolabel3.AutoSize = true;
            this.infolabel3.Location = new System.Drawing.Point(115, 156);
            this.infolabel3.Name = "infolabel3";
            this.infolabel3.Size = new System.Drawing.Size(138, 13);
            this.infolabel3.TabIndex = 13;
            this.infolabel3.Text = "Wrong login info is provided";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Please insert your Username and  Password";
            // 
            // manager_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 233);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.infolabel3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loginbutton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "manager_login";
            this.Text = "Administartion  Login Panel";
            this.Load += new System.EventHandler(this.manager_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button loginbutton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infolabel3;
        private System.Windows.Forms.Label label3;
    }
}