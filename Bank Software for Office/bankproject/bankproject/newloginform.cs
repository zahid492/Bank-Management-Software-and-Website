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
    public partial class newloginform : Form
    {
        public newloginform()
        {
            InitializeComponent();
        }
        public void reset() {
            manager_passwordtextBox4.Clear();
            manageridtextBox3.Clear();
        }
        public String ConnStr = connectionstring.constring;
        private void button1_Click(object sender, EventArgs e)
        {
            //to create new admin for my software

            int j;


            SqlConnection cn1 = new SqlConnection(ConnStr);

            if (cn1.State == ConnectionState.Closed)
                cn1.Open();
          //  MessageBox.Show(cn1.State.ToString());
            string selectsql = "select password from tbl_login where username='" + manageridtextBox3.Text + "' and rank='manager';";
            SqlCommand cmd = new SqlCommand(selectsql, cn1);
            SqlDataReader datas = cmd.ExecuteReader();
            if (datas.Read())
            {
                string manager = datas.GetValue(0).ToString();
                if (manager == manager_passwordtextBox4.Text)
                {

                    cn1.Close();

                    SqlConnection cn2 = new SqlConnection(ConnStr);

                    if (cn2.State == ConnectionState.Closed)
                        cn2.Open();
                    string insert =
                     "insert into tbl_login (id,username,password,rank) values ('" + useridtextBox1.Text + "','" + usernametextBox.Text + "','" + passwordtextBox2.Text + "','clark') ;";
                    SqlCommand command = new SqlCommand(insert, cn2);
                    j = command.ExecuteNonQuery();
                    MessageBox.Show("Succesfully operation..........");
                    reset();
                    useridtextBox1.Clear();
                    usernametextBox.Clear();
                    passwordtextBox2.Clear();
                    infolabel.Visible = false;
                }
                else {
                    //MessageBox.Show("Not match manager Id & password........... ");
                    infolabel.Visible = true;
                    reset();

                }
            }

            else
            {
                //MessageBox.Show("Not match manager Id & password........... ");
                infolabel.Visible = true;
                reset();
            }
        }

        private void newloginform_Load(object sender, EventArgs e)
        {
            infolabel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void useridtextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
