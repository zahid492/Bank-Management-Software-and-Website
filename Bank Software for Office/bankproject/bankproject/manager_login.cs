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
    public partial class manager_login : Form
    {
        public manager_login()
        {
            InitializeComponent();
        }
        public void reset()
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void loginbutton1_Click(object sender, EventArgs e)
        {
            //check that manager username & password


            bool blnfound = false;






            string con = connectionstring.constring;


            SqlConnection cn = new SqlConnection(con);
            cn.Open();
            //MessageBox.Show(cn.State.ToString());
            SqlCommand cmd = new SqlCommand("select * from tbl_login where rank='manager';", cn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {



                if (dr["username"].ToString() == textBox1.Text)
                {


                    if (dr["password"].ToString() == textBox2.Text)
                    {

                        blnfound = true;
                    admin ad=new admin();
                        ad.Show();
                        infolabel3.Visible = false;
                        this.Visible = false;
                    }

                }

            }


            if (blnfound == false)
                infolabel3.Visible = true;
                //MessageBox.Show("Wrong login info is provided");
            dr.Close();

            cn.Close();
            reset();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manager_login_Load(object sender, EventArgs e)
        {
            infolabel3.Visible = false;
        }
    }
}
