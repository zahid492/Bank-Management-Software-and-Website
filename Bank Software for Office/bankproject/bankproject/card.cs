using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace bankproject
{
    public partial class cardtext : Form
    {
        public cardtext()
        {
            InitializeComponent();
        }
        public void reset()
        {
            acctextBox1.Clear();
            nametextBox2.Clear();
            cardtextBox.Clear();
            okbutton.Visible = false;
          




        }

        public string sqlstring = connectionstring.constring;

        private void acctextBox1_TextChanged(object sender, EventArgs e)
        {

            SqlConnection cn = new SqlConnection(sqlstring);

            if (cn.State == ConnectionState.Closed)
                cn.Open();

            string sql = "select name,email from basicinfo where account_no='" + acctextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader datas = cmd.ExecuteReader();
            if (datas.Read())
            {
               nametextBox2.Text = datas.GetValue(0).ToString();
                emailtextBox1.Text = datas.GetValue(1).ToString();
                
                okbutton.Visible = true;
            }
            else
            {
               
              nametextBox2.Text = "No result found";
              emailtextBox1.Text = "No result found";


            }
            cn.Close();
 
       
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            Random random = new Random(); 
           int a= random.Next(1000, 10000);

           int j;
            string b = typecomboBox.Text;

           SqlConnection cn = new SqlConnection(sqlstring);

           cn.Open();


            string insert =
                "insert into tbl_card (account_no,card_type,card_serial,pin_no,card_date,credit_limit) values ('" +
                acctextBox1.Text + "','" + typecomboBox.Text + "','" + serialtextBox.Text + "','" + a + "', '" +
                DateTime.Now + "','" + cardtextBox.Text + "') ;";
           SqlCommand command = new SqlCommand(insert, cn);
           j = command.ExecuteNonQuery();
           cn.Close();
        
           Thread thread = new Thread(()=>send_mail(a,b));
           thread.Start();
            this.Hide();

         

        }

        private void send_mail(int a,string b)
        {
            ///////////////send hidden pin no of my given email address ///////////////////

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            MailAddress from = new MailAddress("shuvorakib@gmail.com", "Bank Authority");
            MailAddress to = new MailAddress(emailtextBox1.Text, nametextBox2.Text);
            MailMessage message = new MailMessage(@from, to);
            message.Body = "Hi\n," + nametextBox2.Text + "\nYour Account No:" + acctextBox1.Text + "\nYour Serial No:" + serialtextBox.Text + "\nYour card type No:" +b+ "\n Your pin No:" + a;
            message.Subject = "Card information";
            NetworkCredential credential = new NetworkCredential("shuvorakib@gmail.com", "320takaa", "");
            client.Credentials = credential;
            try
            {

                client.Send(message);
                MessageBox.Show("card succesfully done,check your Email...........");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception is:" + ex.ToString());
            }


            
        }

        private void cardtext_Load(object sender, EventArgs e)
        {
            cardtextBox.Visible = false;
            label4.Visible = false;
            okbutton.Enabled = false;
        }

        private void typecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            ///////////////////////Random serial no created////////////////////////////////
            Random serial = new Random();
            long b = serial.Next(1000000, 10000000);
            serialtextBox.Text = b.ToString();
            if(typecomboBox.Text=="Credit Card")
            {
                cardtextBox.Visible = true;
                label4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void acctextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void cardtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void cardtext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                okbutton.PerformClick();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                okbutton.Enabled = true;
            }
            else
            {
              okbutton.Enabled = false;
            }
        }

        






      

    }
}
