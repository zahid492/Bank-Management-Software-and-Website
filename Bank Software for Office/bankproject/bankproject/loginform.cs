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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }
        public void reset()
        {
            textBox1.Clear();
            textBox2.Clear();
            infolabel.Visible = false;


        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            bool blnfound = false;


            string con = connectionstring.constring;
            SqlConnection cn = new SqlConnection(con);
            cn.Open();
            // MessageBox.Show(cn.State.ToString());
            SqlCommand cmd = new SqlCommand("select * from tbl_login ", cn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {



                if (dr["username"].ToString() == textBox1.Text)
                {


                    if (dr["password"].ToString() == textBox2.Text)
                    {

                        blnfound = true;
                        this.Visible = false;
                        infolabel.Visible = false;

                        Form1 open = new Form1(textBox1.Text);
                        open.Show();






                    }
                }

            }


            if (blnfound == false)
                infolabel.Visible = true;

            dr.Close();

            cn.Close();
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            infolabel.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newloginform nlog = new newloginform();
            nlog.Show();
            
        }
    }
}
