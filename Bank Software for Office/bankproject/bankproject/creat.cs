using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace bankproject
{
    public partial class creat : Form
    {
         
        public creat()
        {
            InitializeComponent();
        }
        public string sqlstring = connectionstring.constring;
        public void reset()
        {
      
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            
            textBox10.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            mypictureBox.Visible = false;
            sigpictureBox.Visible = false;
            sigtextBox.Clear();
            imagetextBox.Clear();
           










        }
       
        private void button1_Click(object sender, EventArgs e)
        {

  

 ////////////////////////////for inserting data to database//////////////////////////////



            try
            {
                string gen;
                int j;
                int a = int.Parse(textBox5.Text);
                if (radioButton1.Checked == true)
                    gen = "Male";
                else

                    gen = "Female";

                if (a > 1000)
                {
                    string acc = textBox1.Text;
                    

                    SqlConnection cn = new SqlConnection(sqlstring);





         //////////////////////////picture image////////////////////////////


                    MemoryStream ms = new MemoryStream();
                    mypictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                       
                    
                    byte[] pic_arr = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(pic_arr, 0, pic_arr.Length);



         /////////////////////////////////////////signature image////////////////////////////
                    MemoryStream sigms = new MemoryStream();
                    sigpictureBox.Image.Save(sigms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] sigpic_arr1 = new byte[sigms.Length];
                    sigms.Position = 0;
                    sigms.Read(sigpic_arr1, 0, sigpic_arr1.Length);





    
                    cn.Open();
           
                    string insert = "insert into basicinfo (account_no,name,address,phone,gender,nationality,occupation,age,initial,income,email,type,myimage,sigimage,date,open_date) values ('" + textBox1.Text + "','" + textBox2.Text + "','" +
                                    textBox3.Text + "','" + textBox4.Text + "','" + gen + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox5.Text + "','" + textBox8.Text + "','" + textBox10.Text + "','" + comboBox2.Text + "',@myimage,@sigimage,'" + DateTime.Now + "','"+DateTime.Now+"');";
                    SqlCommand command = new SqlCommand(insert, cn);
                    command.Parameters.AddWithValue("@myimage", pic_arr);
                    command.Parameters.AddWithValue("@sigimage", sigpic_arr1);



                    j = command.ExecuteNonQuery();


                    cn.Close();


                    MessageBox.Show("Your Account No:" + acc);




                    Thread thread = new Thread(send_mail);
                    thread.Start();

                
                    
                }
            }

            catch (Exception) {
                MessageBox.Show("No sufficent data...........");
            }
    


            this.Hide();
            creat cr = new creat();
            cr.Show();
         


  }

      private void send_mail()
        {

          //send confirmation mail that your account will be created succesfully/////////////////


            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                MailAddress from = new MailAddress("shuvorakib@gmail.com", "Bank Authority");
                MailAddress to = new MailAddress(textBox10.Text, textBox2.Text);
                MailMessage message = new MailMessage(@from, to);
                message.Body = "Hi\n," + textBox2.Text + "\nYour Account No:" + textBox1.Text +
                               "\nYour Current Balance:" + textBox5.Text ;

                message.Subject = "Bank information";
                NetworkCredential credential = new NetworkCredential("shuvorakib@gmail.com", "320takaa", "");
                client.Credentials = credential;



                client.Send(message);

            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }



        }


        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dialogbutton_Click(object sender, EventArgs e)
        {
            /////////////// set  the directory of my picture.////////////////////////////



            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "image files|*.jpg;*.png;*.gif";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.Cancel)
                return;
            mypictureBox.Image = Image.FromFile(ofd.FileName);
            mypictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
           
            imagetextBox.Text = ofd.FileName;
        }

        private void sigbutton_Click(object sender, EventArgs e)
        {
            // /////////////////// set the directory of my signature picture./////////////////////////


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "image files|*.jpg;*.png;*.gif";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.Cancel)
                return;
            sigpictureBox.Image = Image.FromFile(ofd.FileName);
            sigpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
           sigtextBox.Text = ofd.FileName;
        }

        private void creat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void creat_Load(object sender, EventArgs e)
        {
           int acc_no;
           
            SqlConnection cn = new SqlConnection(sqlstring);
          
            cn.Open();
          
            string sql = "select account_no from basicinfo order by open_date desc";
            SqlCommand cmd = new SqlCommand(sql, cn);




            acc_no = int.Parse(cmd.ExecuteScalar().ToString())+1;
            textBox1.Text = acc_no.ToString();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }





    }
}
