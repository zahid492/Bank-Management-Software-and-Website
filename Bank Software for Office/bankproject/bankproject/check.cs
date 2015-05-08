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
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
        }
        public string sqlstring = connectionstring.constring;
        public void clean()
        {

            acclabel.Visible = false;
            acctextBox1.Visible = false;
            displaybutton.Visible = false;
            acctlabel.Visible = true;
            label1.Visible = true;
            label8.Visible = true;
            label6.Visible = true;
            Typelabel.Visible = true;
            balncelabel.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            label10.Visible = true;
            label7.Visible = true;
            creditlabel5.Visible = true;
            debitlabel9.Visible =true;
        }

        private void check_Load(object sender, EventArgs e)
        {
            acclabel.Visible = true;
            acctextBox1.Visible = true;
            acctlabel.Visible = false;
            label1.Visible = false;
            label8.Visible = false;
            label6.Visible = false;
            Typelabel.Visible = false;
            balncelabel.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            label10.Visible = false;
            label7.Visible = false;
            creditlabel5.Visible = false;
            debitlabel9.Visible = false;
            label8.Visible = false;
            label7.Visible = false;

        }

        private void displaybutton_Click(object sender, EventArgs e)

        {

            ///////////////////display of a account transaction debit and credit///////////////////

            clean();
           
            label8.Text = acctextBox1.Text;
        
            SqlConnection cn1 = new SqlConnection(sqlstring);

            if (cn1.State == ConnectionState.Closed)
                cn1.Open();

            string selectsql = "select name,initial,type from basicinfo where account_no='" + acctextBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(selectsql, cn1);
            SqlDataReader datas = cmd.ExecuteReader();
            if (datas.Read())
            {
                label7.Text = datas.GetValue(0).ToString();
                label6.Text = datas.GetValue(1).ToString();
                label1.Text = datas.GetValue(2).ToString();
            }

           cn1.Close();


          
           SqlConnection cn2 = new SqlConnection(sqlstring);
          
            if (cn2.State == ConnectionState.Closed)
               cn2.Open();
            string sql = "select amount,date from tbl_credit where account_no='" + acctextBox1.Text + "' order by date desc";
           
          
            DataSet ds;
            SqlCommand cmd1 = new SqlCommand(sql, cn2);
            
            SqlDataAdapter da = new SqlDataAdapter();
          
            da = new SqlDataAdapter(cmd1);
          
            ds = new DataSet();
            da.Fill(ds,"amnt,dat");
            dataGridView2.DataSource = ds.Tables[0];
            cn2.Close();



        
            SqlConnection cn3 = new SqlConnection(sqlstring);
            if (cn3.State == ConnectionState.Closed)
                cn3.Open();
            string sql1 = "select debit_amount,date from tbl_debit where accout_no='" + acctextBox1.Text + "' order by date desc";
          

            SqlCommand cmd2 = new SqlCommand(sql1,cn3);
            SqlDataAdapter data=new SqlDataAdapter();
            data=new SqlDataAdapter(cmd2);
            ds=new DataSet();
            data.Fill(ds,"aas,bhhj");


            dataGridView1.DataSource = ds.Tables[0];

            cn3.Close();
       
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        }


     
    

