using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Threading;
using System.Net;
using System.Data.SqlClient;
namespace bankproject
{
    public partial class sending_mail : Form
    {
        public sending_mail()
        {
            InitializeComponent();
        }
        public string sqlstring = connectionstring.constring;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message sucessfully send.........");
            Thread thread = new Thread(send_mail);
            thread.Start();
        }

        private void send_mail()
        {
            ///////////////////////sending mail via gmail smtp//////////////////////////////

            SqlConnection cn = new SqlConnection(sqlstring);
       
            cn.Open();
         
            string sql = "select email from basicinfo where account_no='" + accnotextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);

            string mailadd = cmd.ExecuteScalar().ToString();

            cn.Close();
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            MailAddress from = new MailAddress("shuvorakib@gmail.com", subjecttextBox3.Text);
            MailAddress to = new MailAddress(mailadd, subjecttextBox3.Text);
            MailMessage message = new MailMessage(@from, to);
            message.Body = bodytextBox1.Text;
            message.Subject = subjecttextBox3.Text;
            NetworkCredential credential = new NetworkCredential("shuvorakib@gmail.com", "320takaa", "");
            client.Credentials = credential;
            try
            {

                client.Send(message);
                
            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception is:" + ex.ToString());
            }



            int j;
            SqlConnection cn1 = new SqlConnection(sqlstring);

            cn1.Open();


            string insert =
                "insert into tbl_inbox (account_no,subject,mail_body,sent_date) values ('" + accnotextBox1.Text + "','" + message.Subject + "','" + message.Body + "','" + DateTime.Now + "');";
            SqlCommand command = new SqlCommand(insert, cn1);
            j = command.ExecuteNonQuery();
            cn1.Close();




        }

    
   
    }
}
