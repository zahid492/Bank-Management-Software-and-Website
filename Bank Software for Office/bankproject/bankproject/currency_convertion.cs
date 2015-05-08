using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace bankproject
{
    public partial class currency_convertion : Form
    {
        public currency_convertion()
        {
            InitializeComponent();
        }

        public string sqlstring = connectionstring.constring;
        private void button1_Click(object sender, EventArgs e)
        {

            ///////////////////////////Using webservice to show the current currency among several country///
            label1.Visible = true;
            label5.Visible = true;
            try
            {
                string xmlResult = null;
                string url;
                url = "http://www.webservicex.net/CurrencyConvertor.asmx/ConversionRate?FromCurrency=" + comboBox1.Text.Substring(0, 3) + "&ToCurrency=" + comboBox2.Text.Substring(0, 3) + "";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader resStream = new StreamReader(response.GetResponseStream());
                XmlDocument doc = new XmlDocument();
                xmlResult = resStream.ReadToEnd();
                doc.LoadXml(xmlResult);
                string string_rate = doc.GetElementsByTagName("double").Item(0).InnerText;

                double per_rate = Convert.ToDouble(string_rate);
                string amount = amnttext.Text;
                int total_amount = Convert.ToInt32(amount);
                double final_amount = per_rate * total_amount;

                totaltext.Text = final_amount.ToString();


                label1.Text = " " + comboBox1.Text.ToUpper() + " --> " + comboBox2.Text.ToUpper() + " Value is: " + string_rate;
                label5.Text = "Total amount: " + final_amount;
            }
            catch (Exception)
            {
                label1.Text = "Not a valid Currency or Try again later";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void currency_convertion_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label5.Visible = false;
            donebutton.Enabled = false;
            totaltext.Visible = false;
            comboBox1.SelectedIndex = 139;
            comboBox2.SelectedIndex = 8;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {      if(checkBox1.Checked)
        {
            donebutton.Enabled = true;
        }
        else
        {
            donebutton.Enabled = false;
        }
       

        }

        private void donebutton_Click(object sender, EventArgs e)
        {
            string final_amount = totaltext.Text;
            double double_amount = Convert.ToDouble(final_amount);
            string amount = amnttext.Text;
            int amnt = Convert.ToInt32(amount);
            double rate = double_amount/amnt;
            int j;
          
           // string sqlstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\BANGLADESH\Documents\bankinfo.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection cn = new SqlConnection(sqlstring);

            cn.Open();


            string insert =
                "insert into tbl_currency (currency_from,currency_to,per_rate,amount_from,total_amount,date) values ('" +
                comboBox1.Text + "','" + comboBox2.Text + "','" + rate + "','" + amnttext.Text + "','" + double_amount + "', '" +
                DateTime.Now + "') ;";
            SqlCommand command = new SqlCommand(insert, cn);
            j = command.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Transaction Complete..........");

        }

      
    }
}
