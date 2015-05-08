using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Configuration;

namespace bankproject
{
    public partial class credit : Form
    {
        public credit()
        {
            InitializeComponent();
        }
   
        public void reset()
        {
            accnotextBox1.Clear();
            nametext.Clear();
            amounttext.Clear();
            textBox1.Clear();
            sigpictureBox1.Visible = false;

        }
        public string sqlstring = connectionstring.constring;
      
        private void button1_Click(object sender, EventArgs e)
        {

            //////////////Credited account of a client////////////////////////



            try
            {
              
                SqlConnection cn = new SqlConnection(sqlstring);

                cn.Open();

                string sql = "select initial from basicinfo where account_no='" + accnotextBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);

                string amount = cmd.ExecuteScalar().ToString();

                double accamount = Convert.ToDouble(amount);



                int aI = int.Parse(amounttext.Text);
                if (accamount > 1000 && accamount - aI > 1000)
                {

                    int j;
                    SqlTransaction trans;

                    string updat = "update basicinfo set initial=initial-'" + amounttext.Text + "' where account_no='" +
                                   accnotextBox1.Text + "' and name='" + nametext.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(updat, cn);
                    trans = cn.BeginTransaction();
                    cmd1.Transaction = trans;
                    j = cmd1.ExecuteNonQuery();



                    if (j == 1)
                    {
                        int f;
                        trans.Commit();
                        MessageBox.Show("credited...");
                        string creditinsert = "insert into tbl_credit (account_no,name,amount,date) values ('" +
                                              accnotextBox1.Text + "','" + nametext.Text + "','" + amounttext.Text +
                                              "','" + DateTime.Now + "');";
                        SqlCommand command = new SqlCommand(creditinsert, cn);
                        f = command.ExecuteNonQuery();
                        cn.Close();


                        reset();

                    }
                    else
                    {
                        trans.Rollback();
                        MessageBox.Show("Not sufficent balance............");
                    }

                }
                  
                else {
                    MessageBox.Show("Your Account acced balance............");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Not sufficent data..........");
            }

     


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accnotextBox1_TextChanged(object sender, EventArgs e)
        {

          //  string sqlstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\BANGLADESH\Documents\bankinfo.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
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
               textBox1.Text = "No balance found";
             
            }
            cn.Close();
       

          


        }

        private void accnotextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void credit_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void checkbutton_Click(object sender, EventArgs e)
        {
            //retrive my signature to check that correct person.

            try
            {
                SqlConnection cn =
                    new SqlConnection(sqlstring);
                MemoryStream stream = new MemoryStream();
                cn.Open();
                SqlCommand command =
                    new SqlCommand("select sigimage from basicinfo where account_no='" + accnotextBox1.Text + "'", cn);
                byte[] image = (byte[]) command.ExecuteScalar();
                stream.Write(image, 0, image.Length);
                cn.Close();
                Bitmap bitmap = new Bitmap(stream);
                sigpictureBox1.Image = bitmap;
                sigpictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           
            }
            catch(Exception)
            {
                MessageBox.Show("No sufficent Signature");
            }

        }

        private void credit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void amounttext_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }


    }
}
