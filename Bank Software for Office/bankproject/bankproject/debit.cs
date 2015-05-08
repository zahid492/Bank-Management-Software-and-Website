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
    public partial class debit : Form
    {
        public debit()
        {
            InitializeComponent();
        }
        public void reset()
        {
            accnotextBox1.Clear();
            nametext.Clear();
            amounttext.Clear();
            textBox1.Clear();
        }
        public string sqlstring = connectionstring.constring;
        private void button1_Click(object sender, EventArgs e)
        {
            /////////////to store debitted balance from my account//////////////////
            
            try
            {
               
               
                SqlConnection cn = new SqlConnection(sqlstring);
  
                cn.Open();

                string sql = "select initial from basicinfo where account_no='" + accnotextBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);


                string amount = cmd.ExecuteScalar().ToString();

                double accamount = Convert.ToDouble(amount);
                if (accamount > 1000)
                {
                    int j;
                    SqlTransaction trans;

                
                    string updat = "update basicinfo set initial=initial+'" + amounttext.Text + "' where account_no='" +
                                   accnotextBox1.Text + "' and name='" + nametext.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(updat, cn);
                    trans = cn.BeginTransaction();
                    cmd1.Transaction = trans;
                    j = cmd1.ExecuteNonQuery();
                    if (j == 1)
                    {
                        int f;
                        trans.Commit();
                        MessageBox.Show("Debitted......");
                        string debitinsert = "insert into tbl_debit (accout_no,name,debit_amount,date) values ('" +
                                             accnotextBox1.Text + "','" + nametext.Text + "','" + amounttext.Text +
                                             "','" + DateTime.Now + "');";
                        SqlCommand command = new SqlCommand(debitinsert, cn);
                        f = command.ExecuteNonQuery();
                        cn.Close();


                        reset();

                    }
                    else
                        trans.Rollback();
                }
            }
  
            catch(Exception)
            {
                MessageBox.Show("No suuficent data");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accnotextBox1_TextChanged(object sender, EventArgs e)
        {
            
            ///////////////check the given account no is existing or not///////////////////////

            SqlConnection cn = new SqlConnection(sqlstring);

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            string sql = "select name,initial from basicinfo where account_no='" + accnotextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader datas = cmd.ExecuteReader();
            if (datas.Read())
            {
                nametext.Text = datas.GetValue(0).ToString();
                textBox1.Text = datas.GetValue(1).ToString();
                button1.Visible = true;
             
            }
            else
            {
                nametext.Text = "No Result found";
                textBox1.Text = "No address found";
            

            }
        }

        private void accnotextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void debit_Load(object sender, EventArgs e)
        {
            button1.Visible = false;

        }
    }
}
