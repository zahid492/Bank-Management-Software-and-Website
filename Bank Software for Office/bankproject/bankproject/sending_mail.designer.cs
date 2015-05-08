namespace bankproject
{
    partial class sending_mail
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
            this.sendbutton1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.accnotextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subjecttextBox3 = new System.Windows.Forms.TextBox();
            this.bodytextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendbutton1
            // 
            this.sendbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendbutton1.Location = new System.Drawing.Point(259, 408);
            this.sendbutton1.Name = "sendbutton1";
            this.sendbutton1.Size = new System.Drawing.Size(75, 23);
            this.sendbutton1.TabIndex = 0;
            this.sendbutton1.Text = "Send";
            this.sendbutton1.UseVisualStyleBackColor = true;
            this.sendbutton1.Click += new System.EventHandler(this.sendbutton1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(490, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // accnotextBox1
            // 
            this.accnotextBox1.Location = new System.Drawing.Point(91, 28);
            this.accnotextBox1.Name = "accnotextBox1";
            this.accnotextBox1.Size = new System.Drawing.Size(176, 20);
            this.accnotextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Account No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subject:";
            // 
            // subjecttextBox3
            // 
            this.subjecttextBox3.Location = new System.Drawing.Point(91, 64);
            this.subjecttextBox3.Multiline = true;
            this.subjecttextBox3.Name = "subjecttextBox3";
            this.subjecttextBox3.Size = new System.Drawing.Size(494, 50);
            this.subjecttextBox3.TabIndex = 11;
            // 
            // bodytextBox1
            // 
            this.bodytextBox1.Location = new System.Drawing.Point(91, 120);
            this.bodytextBox1.Multiline = true;
            this.bodytextBox1.Name = "bodytextBox1";
            this.bodytextBox1.Size = new System.Drawing.Size(494, 281);
            this.bodytextBox1.TabIndex = 13;
            // 
            // sending_mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 481);
            this.Controls.Add(this.bodytextBox1);
            this.Controls.Add(this.subjecttextBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accnotextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sendbutton1);
            this.Name = "sending_mail";
            this.Text = "sending_mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendbutton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox accnotextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subjecttextBox3;
        private System.Windows.Forms.TextBox bodytextBox1;
    }
}