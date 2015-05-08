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
    public partial class statement : Form
    {
        public statement()
        {
            InitializeComponent();
        }
        public String ConnStr = connectionstring.constring;
        private void button1_Click(object sender, EventArgs e)
        {

           ///////// ///////////////Crystal report to show a text report on a specific account////////////////////////

            crystalReportViewer1.Enabled = true;

     string acc_no = textBox1.Text;
            int int_acc_no = Convert.ToInt32(acc_no);
          
     SqlConnection myConnection = new SqlConnection(ConnStr);
            myConnection.Open();
           string sql = "select phone,gender,nationality,occupation,account_no,name,age,initial,open_date,type,email,address from basicinfo where account_no='"+int_acc_no+"';";
            DataSet Ds;
            SqlCommand cmd1 = new SqlCommand(sql, myConnection);
            SqlDataAdapter da = new SqlDataAdapter();
            da = new SqlDataAdapter(cmd1);
            Ds = new DataSet();
            da.Fill(Ds, "basicinfo");



            string sql1 = "select date,amount from tbl_credit where account_no='" + int_acc_no + "' order by date desc;";
            SqlCommand cmd2 = new SqlCommand(sql1, myConnection);
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1 = new SqlDataAdapter(cmd2);
            da1.Fill(Ds, "tbl_credit");

            index2 objRpt = new index2();
            objRpt.SetDataSource(Ds);
           crystalReportViewer1.Visible = true;
           crystalReportViewer1.ReportSource = objRpt;
            

            myConnection.Close();

     






           
   
        }

        private void statement_Load(object sender, EventArgs e)
        {
          crystalReportViewer1.Visible = false;
          crystalReportViewer1.Enabled = false;

        }
    }
}
