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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }


        public string astring = connectionstring.constring;

        private void button1_Click(object sender, EventArgs e)
        {
            /////////////////// to show all account which created on between two date./////////////////
            SqlConnection cn2 = new SqlConnection(astring);
            if (cn2.State == ConnectionState.Closed)
                cn2.Open();
            string sql = "SELECT * FROM basicinfo WHERE date BETWEEN '" + fromdateTimePicker1.Value.ToString()+ "' AND '" +
                         todateTimePicker2.Value.ToString() + "';";


            DataSet ds;
            SqlCommand cmd1 = new SqlCommand(sql, cn2);

            SqlDataAdapter da = new SqlDataAdapter();

            da = new SqlDataAdapter(cmd1);

            ds = new DataSet();
            da.Fill(ds, "amnt,dat");
           acchistorydataGridView1.DataSource = ds.Tables[0];
            cn2.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection cn2 = new SqlConnection(astring);
            if (cn2.State == ConnectionState.Closed)
                cn2.Open();
            string sql = "SELECT sum(amount) as Total  FROM tbl_credit WHERE date BETWEEN '" + from_credit_dateTimePicker2.Value.ToString() + "' AND '" +
                  to_credit_dateTimePicker1.Value.ToString() + "';";


            DataSet ds;
            SqlCommand cmd1 = new SqlCommand(sql, cn2);

            SqlDataAdapter da = new SqlDataAdapter();

            da = new SqlDataAdapter(cmd1);

            ds = new DataSet();
            da.Fill(ds, "amnt,dat");
          totalcreditdataGridView1.DataSource = ds.Tables[0];
            cn2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            SqlConnection cn2 = new SqlConnection(astring);
            if (cn2.State == ConnectionState.Closed)
                cn2.Open();
            string sql = "SELECT sum(debit_amount) as Total  FROM tbl_debit WHERE date BETWEEN '" + debit_fromdateTimePicker2.Value.ToString() + "' AND '" +
                  debit_to_dateTimePicker1.Value.ToString() + "';";


            DataSet ds;
            SqlCommand cmd1 = new SqlCommand(sql, cn2);

            SqlDataAdapter da = new SqlDataAdapter();

            da = new SqlDataAdapter(cmd1);

            ds = new DataSet();
            da.Fill(ds, "amnt,dat");
          debitdataGridView1.DataSource = ds.Tables[0];
            cn2.Close();
        }

        


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ////////////////// to show a specific  account which contain whole information.//////////////////
            SqlConnection cn2 = new SqlConnection(astring);
            if (cn2.State == ConnectionState.Closed)
                cn2.Open();
            string sql = "SELECT * FROM basicinfo WHERE account_no= '" + textBox1.Text + "';";


            DataSet ds;
            SqlCommand cmd1 = new SqlCommand(sql, cn2);

            SqlDataAdapter da = new SqlDataAdapter();

            da = new SqlDataAdapter(cmd1);

            ds = new DataSet();
            da.Fill(ds, "amnt,dat");
            detailsdataGridView1.DataSource = ds.Tables[0];
            cn2.Close();
        }

        private void today_creditbutton5_Click(object sender, EventArgs e)
        {
            ///////////// to show all credited transaction between two date./////////////////////////

            
            SqlConnection cn2 = new SqlConnection(astring);
            if (cn2.State == ConnectionState.Closed)
                cn2.Open();
            string sql = "SELECT sum(amount) as Today  FROM tbl_credit WHERE date ='"+DateTime.Today.ToShortDateString()+"';";
            //string sql = "select *from tbl_card where card_date='"+DateTime.Today.ToShortDateString()+" ';"; 

            DataSet ds;
            SqlCommand cmd1 = new SqlCommand(sql, cn2);

            SqlDataAdapter da = new SqlDataAdapter();

            da = new SqlDataAdapter(cmd1);

            ds = new DataSet();
            da.Fill(ds, "amnt,dat");
            totalcreditdataGridView1.DataSource = ds.Tables[0];
            cn2.Close();

        }

        private void today_debitbutton6_Click(object sender, EventArgs e)
        {
            ////////////////////to show all debiteded transaction between two date./////////////////////

            SqlConnection cn2 = new SqlConnection(astring);
            if (cn2.State == ConnectionState.Closed)
                cn2.Open();
            string sql = "SELECT sum(debit_amount) as Today  FROM tbl_debit WHERE date ='"+DateTime.Today.ToShortDateString()+"';";


            DataSet ds;
            SqlCommand cmd1 = new SqlCommand(sql, cn2);

            SqlDataAdapter da = new SqlDataAdapter();

            da = new SqlDataAdapter(cmd1);

            ds = new DataSet();
            da.Fill(ds, "amnt,dat");
            debitdataGridView1.DataSource = ds.Tables[0];
            cn2.Close();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        
        }

        private void button5_Click(object sender, EventArgs e)
        {
      ///////////// to updateing all account with give interest of calculating each day after 15 days held.///////////////

            int total_acc_no;
            
            SqlConnection cn2 = new SqlConnection(astring);
            cn2.Open();

            string sql = "select count(account_no) from basicinfo";
            SqlCommand cmd2 = new SqlCommand(sql, cn2);




            total_acc_no = int.Parse(cmd2.ExecuteScalar().ToString()) + 10000;


          //  MessageBox.Show(total_acc_no.ToString());
            cn2.Close();
            int num = 10001;
            while (num <= total_acc_no)
            {


                int j;

                //string sqlstring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\BANGLADESH\Documents\bankinfo.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                SqlConnection cn1 = new SqlConnection(astring);

                if (cn1.State == ConnectionState.Closed)
                    cn1.Open();

                string selectsql = "select initial,date from basicinfo where account_no='" + num + "'";
                SqlCommand cmd = new SqlCommand(selectsql, cn1);
                SqlDataReader datas = cmd.ExecuteReader();
                if (datas.Read())
                {
                    string amnt = datas.GetValue(0).ToString();
                    string date = datas.GetValue(1).ToString();
                 



                    DateTime dt1 = DateTime.Parse(date);
                    DateTime dt2 = DateTime.Now;
                    double totalday = (dt2 - dt1).TotalDays;
                    double initial_amount = Convert.ToDouble(amnt);
                    int day_count = Convert.ToInt32(totalday);
                    int month_count = 1 + day_count / 30;

                    double inter_rate = 8;
                    double mon_rate = inter_rate / 1200;

                    double month = initial_amount * mon_rate / (1 - 1 / Math.Pow(1 + mon_rate, month_count));

                 
                    cn1.Close();

                    if (day_count > 10)
                    {
                       // string sqlstring1 = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\BANGLADESH\Documents\bankinfo.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True;";
                        SqlConnection cn = new SqlConnection(astring);
                        cn.Open();
                        string updat = "update basicinfo set initial='" + month + "',date='" + DateTime.Now +
                        "' where account_no='" + num + "'";
                        SqlCommand cmd1 = new SqlCommand(updat, cn);

                        j = cmd1.ExecuteNonQuery();
                        cn.Close();
                    }

                    num++;


                }
                
            }


            MessageBox.Show("Update done........");
        }


    
 

       

        }
    }

