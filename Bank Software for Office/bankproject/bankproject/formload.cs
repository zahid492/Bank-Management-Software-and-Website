using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bankproject
{
    public partial class formload : Form
    {
        public formload()
        {
            InitializeComponent();
        }
       // private int counter;
        public string astring = connectionstring.constring;
        Timer t = new Timer();

  
        private void formload_Load(object sender, EventArgs e)
        {
            ///////////////////////update all informatioin of my banking transaction with interest /////////////////

            int total_acc_no;
          
            SqlConnection cn2 = new SqlConnection(astring);
            cn2.Open();

            string sql = "select count(account_no) from basicinfo";
            SqlCommand cmd2 = new SqlCommand(sql, cn2);




            total_acc_no = int.Parse(cmd2.ExecuteScalar().ToString()) + 10000;



            cn2.Close();
            int num = 10001;
            while (num <= total_acc_no)
            {


                int j;

                
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
                      
                        SqlConnection cn = new SqlConnection(astring);
                        cn.Open();
                        string updat = "update basicinfo set initial='" + month + "',date='" + DateTime.Now +
                        "' where account_no='" + num + "'";
                        SqlCommand cmd1 = new SqlCommand(updat, cn);

                        //j = cmd1.ExecuteNonQuery();
                        cn.Close();
                    }

                    num++;


                }

            }
            t.Tick += new EventHandler(timer1_Tick);
            t.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e) {
          
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
         progressBar1.PerformStep();
{
if (progressBar1.Value == 100)
{
 
t.Stop();
 

this.Hide();
    loginform log = new loginform();
    log.Show();

}



}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

    }
}