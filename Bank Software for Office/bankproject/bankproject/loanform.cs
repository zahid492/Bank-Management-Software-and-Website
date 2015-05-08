using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bankproject
{
    public partial class loanform : Form
    {
        public loanform()
        {
            InitializeComponent();
           
        }
        




        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                string test = acctextBox2.Text;

                if (comboBox1.Text == "Education Loan")
                {
                    education edu = new education();

                    edu.Show();
                    this.Close();

                }
                if (comboBox1.Text == "Housing Loan")
                {
                    houseing house = new houseing();
                    house.Show();
                    this.Close();

                }
                if (comboBox1.Text == "Car Loan")
                {
                    car carloan = new car();
                    carloan.Show();
                    this.Close();
                }

                if (comboBox1.Text == "SME Loan")
                {
                    sme smeloan = new sme();
                    smeloan.Show();
                    this.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No suffient data..........");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acctextBox2_TextChanged(object sender, EventArgs e)
        {
            ////////////////check the information of user///////////////////////


            string sqlstring = connectionstring.constring;
            SqlConnection cn = new SqlConnection(sqlstring);

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            string sql = "select name,address from basicinfo where account_no='" + acctextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader datas = cmd.ExecuteReader();
            if (datas.Read())
            {
               NametextBox.Text = datas.GetValue(0).ToString();
                comboBox1.Visible = true;
                label3.Visible = true;
                button1.Visible = true;
            }
            else
            {
              NametextBox.Text = "No Result found";
               
            }
        }

        private void loanform_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            comboBox1.Visible = false;
            label3.Visible = false;
        }

        private void acctextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

  
    }
}
