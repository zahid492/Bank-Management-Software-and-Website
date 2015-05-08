namespace bankproject
{
    partial class cardtext
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
            this.okbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.acctextBox1 = new System.Windows.Forms.TextBox();
            this.nametextBox2 = new System.Windows.Forms.TextBox();
            this.typecomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cardtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serialtextBox = new System.Windows.Forms.TextBox();
            this.Seriallabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailtextBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // okbutton
            // 
            this.okbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okbutton.Location = new System.Drawing.Point(477, 318);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(75, 29);
            this.okbutton.TabIndex = 0;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Card Type";
            // 
            // acctextBox1
            // 
            this.acctextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acctextBox1.Location = new System.Drawing.Point(265, 21);
            this.acctextBox1.Name = "acctextBox1";
            this.acctextBox1.Size = new System.Drawing.Size(234, 26);
            this.acctextBox1.TabIndex = 4;
            this.acctextBox1.TextChanged += new System.EventHandler(this.acctextBox1_TextChanged);
            this.acctextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acctextBox1_KeyPress);
            // 
            // nametextBox2
            // 
            this.nametextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextBox2.Location = new System.Drawing.Point(265, 71);
            this.nametextBox2.Name = "nametextBox2";
            this.nametextBox2.ReadOnly = true;
            this.nametextBox2.Size = new System.Drawing.Size(234, 26);
            this.nametextBox2.TabIndex = 5;
            // 
            // typecomboBox
            // 
            this.typecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typecomboBox.FormattingEnabled = true;
            this.typecomboBox.Items.AddRange(new object[] {
            "ATM Card",
            "Master Card",
            "Visa Card",
            "Salary Card",
            "Credit Card"});
            this.typecomboBox.Location = new System.Drawing.Point(265, 121);
            this.typecomboBox.Name = "typecomboBox";
            this.typecomboBox.Size = new System.Drawing.Size(121, 28);
            this.typecomboBox.TabIndex = 6;
            this.typecomboBox.SelectedIndexChanged += new System.EventHandler(this.typecomboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Credit Limit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // cardtextBox
            // 
            this.cardtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardtextBox.Location = new System.Drawing.Point(265, 236);
            this.cardtextBox.Name = "cardtextBox";
            this.cardtextBox.Size = new System.Drawing.Size(234, 26);
            this.cardtextBox.TabIndex = 9;
            this.cardtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardtextBox_KeyPress);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(578, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialtextBox
            // 
            this.serialtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialtextBox.Location = new System.Drawing.Point(265, 157);
            this.serialtextBox.Name = "serialtextBox";
            this.serialtextBox.Size = new System.Drawing.Size(234, 26);
            this.serialtextBox.TabIndex = 11;
            // 
            // Seriallabel
            // 
            this.Seriallabel.AutoSize = true;
            this.Seriallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seriallabel.Location = new System.Drawing.Point(154, 162);
            this.Seriallabel.Name = "Seriallabel";
            this.Seriallabel.Size = new System.Drawing.Size(55, 20);
            this.Seriallabel.TabIndex = 12;
            this.Seriallabel.Text = "Serial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // emailtextBox1
            // 
            this.emailtextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox1.Location = new System.Drawing.Point(265, 198);
            this.emailtextBox1.Name = "emailtextBox1";
            this.emailtextBox1.Size = new System.Drawing.Size(234, 26);
            this.emailtextBox1.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(26, 324);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 20);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "I agree term and condition";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cardtext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 359);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.emailtextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.serialtextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cardtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typecomboBox);
            this.Controls.Add(this.nametextBox2);
            this.Controls.Add(this.acctextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.Seriallabel);
            this.Name = "cardtext";
            this.Text = "card";
            this.Load += new System.EventHandler(this.cardtext_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cardtext_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox acctextBox1;
        private System.Windows.Forms.TextBox nametextBox2;
        private System.Windows.Forms.ComboBox typecomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cardtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox serialtextBox;
        private System.Windows.Forms.Label Seriallabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailtextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}