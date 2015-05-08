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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        public void reset()
        {
            tranferto_acctextBox6.Clear();
            
            transfer_balance_textBox3.Clear();
            transfer_from_acctextBox1.Clear();
            transfer_from_nametextBox2.Clear();
            transferto_nametextBox5.Clear();
        }
        public string sqlstring = connectionstring.constring;
        private void button1_Click(object sender, EventArgs e)
        {
            /////////////////////////transfer balance from one account to other account./////////////////////
            
            try
            {

                int transfer_from_amount = int.Parse(transfer_balance_textBox3.Text);
                int from_account = int.Parse(transfer_from_acctextBox1.Text);
                int to_account = int.Parse(tranferto_acctextBox6.Text);



                SqlConnection cn = new SqlConnection(sqlstring);
                // MessageBox.Show(cn.State.ToString());
                cn.Open();
                // MessageBox.Show(cn.State.ToString());
                string sql = "select initial from basicinfo where account_no='" + transfer_from_acctextBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);

               // int amount = int.Parse(cmd.ExecuteScalar().ToString());
                // MessageBox.Show(transfer_from_amount.ToString());


                string accamount = cmd.ExecuteScalar().ToString();

                double amount = Convert.ToDouble(accamount);
                if (amount > 1000 && amount - transfer_from_amount > 1000)
                {
                    int j, k;
                    SqlTransaction trans;


                    trans = cn.BeginTransaction();
                    string from_updat = "update basicinfo set initial=initial-'" + transfer_balance_textBox3.Text +
                                        "' where account_no='" + transfer_from_acctextBox1.Text + "' and name='" +
                                        transfer_from_nametextBox2.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(from_updat, cn);

                    cmd1.Transaction = trans;

                    string to_updat = "update basicinfo set initial=initial+'" + transfer_balance_textBox3.Text +
                                      "' where account_no='" + tranferto_acctextBox6.Text + "' and name='" +
                                      transferto_nametextBox5.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(to_updat, cn);

                    cmd2.Transaction = trans;

                    j = cmd1.ExecuteNonQuery();
                    k = cmd2.ExecuteNonQuery();
                    if (j == 1 && k == 1)
                    {
                        trans.Commit();
                        int f;
                        string creditinsert = "insert into tbl_credit (account_no,name,amount,date) values ('" +
                                              transfer_from_acctextBox1.Text + "','" + transfer_from_nametextBox2.Text +
                                              "','" + transfer_balance_textBox3.Text + "','" + DateTime.Now + "');";
                        SqlCommand creditcommand = new SqlCommand(creditinsert, cn);
                        f = creditcommand.ExecuteNonQuery();

                        int g;
                        string debittinsert = "insert into tbl_debit (accout_no,name,debit_amount,date) values ('" +
                                              tranferto_acctextBox6.Text + "','" + transferto_nametextBox5.Text + "','" +
                                              transfer_balance_textBox3.Text + "','" + DateTime.Now + "');";
                        SqlCommand debitcommand = new SqlCommand(debittinsert, cn);
                        g = debitcommand.ExecuteNonQuery();








                        MessageBox.Show("Transfered...");


                        cn.Close();


                        reset();

                    }
                    else
                    {
                        trans.Rollback();

                        MessageBox.Show("Please Cheeck your information");

                    }
                }
                else
                {
                    MessageBox.Show("You have not Sufficent balance ");
                    reset();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No sufficent data............");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        
        
        
        
        
        
        
        
        
        private void transfer_from_acctextBox1_TextChanged(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection(sqlstring);

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            string sql = "select name from basicinfo where account_no='" + transfer_from_acctextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader datas = cmd.ExecuteReader();
            if (datas.Read())
            {
                transfer_from_nametextBox2.Text = datas.GetValue(0).ToString();
                //textBox1.Text = datas.GetValue(1).ToString();
            }
            else
            {transfer_from_nametextBox2.Text = "No Result found";
                //textBox1.Text = "No address found";
            }
        }

        private void tranferto_acctextBox6_TextChanged(object sender, EventArgs e)
        {
           
            SqlConnection cn = new SqlConnection(sqlstring);

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            string sql = "select name from basicinfo where account_no='" + tranferto_acctextBox6.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader datas = cmd.ExecuteReader();
            if (datas.Read())
            {
                transferto_nametextBox5.Text = datas.GetValue(0).ToString();
                //textBox1.Text = datas.GetValue(1).ToString();
            }
            else
            {
               transferto_nametextBox5.Text = "No Result found";
                //textBox1.Text = "No address found";
            }
        }
    }

       
}
