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
    public partial class sme : Form
    {
        public sme()
        {
            InitializeComponent();
        }
        public string sqlstring = connectionstring.constring;

        private void acctextBox_TextChanged(object sender, EventArgs e)
        {
            //////////////////////////search all information of given account no//////////////////////////
            
            SqlConnection cn = new SqlConnection(sqlstring);

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            string sql = "select name,address from basicinfo where account_no='" + acctextBox.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader datas = cmd.ExecuteReader();
            if (datas.Read())
            {
                nametext.Text = datas.GetValue(0).ToString();
                plottext.Text = datas.GetValue(1).ToString();
            }
            else
            {
                nametext.Text = "No Result found";
                plottext.Text = "No address found";
            }
        }

        private void yeartext_TextChanged(object sender, EventArgs e)
        {
            ///////////////////////////// to calculate loan amount /////////////////////////////.
            double inter_rate;

            int amount = int.Parse(amounttext.Text);
            int year = int.Parse(yeartext.Text);
            if (amount > 100000)
            {


               
                SqlConnection cn = new SqlConnection(sqlstring);

                cn.Open();

                string sql = "select interest_rate from interest where loan_type='sme_loan'";
                SqlCommand cmd = new SqlCommand(sql, cn);

                inter_rate = double.Parse(cmd.ExecuteScalar().ToString());



                double mon_rate = inter_rate / 1200;

                double month = amount * mon_rate / (1 - 1 / Math.Pow(1 + mon_rate, year * 12));

                double total = month * year * 12;

                monthlytext.Text = month.ToString();
                paymenttextBox8.Text = total.ToString();
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
        {
            int a = int.Parse(amounttext.Text);
            if (a > 100000)
            {
                int j;

             
                SqlConnection cn = new SqlConnection(sqlstring);

                cn.Open();


                string insert =
                    "insert into tbl_loan (type,account_no,name,address,sme_name,purpose,site,invest,amount,year,total,monthly,nominee_name,nom_acc,phone,date) values ('sme','" +
                    acctextBox.Text + "','" + nametext.Text + "','" +
                    plottext.Text + "','" + smetext.Text + "','" + purposetextBox.Text + "','" + sitetextBox2.Text +
                    "','" + investtextBox3.Text +
                    "','" + amounttext.Text + "','" + yeartext.Text + "','" + paymenttextBox8.Text + "','" +
                    monthlytext.Text + "','" + nomNametext.Text + "','" + nom_acctext.Text + "','" + phone_text.Text +
                    "','" + DateTime.Now + "');"; //site area bad gese
                SqlCommand command = new SqlCommand(insert, cn);
                j = command.ExecuteNonQuery();
                cn.Close();



                MessageBox.Show("Loan Succesfully done...........");
                
            this.Close();
            }
        }

            catch(Exception)
            {
                MessageBox.Show("No sufficent data.........");
            }



        }

        private void acctextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void amounttext_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void yeartext_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

     


        


    }
}
