using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class statement : System.Web.UI.Page
{
    public string constring = connectionstring.sqlconstring;
    protected void Page_Load(object sender, EventArgs e)
    {

        Label2.Visible = false;
       balancelabel.Visible = false;
        try
        {
            Label1.Text = (string)Session["myvar1"];
            balanceTextBox3.Text = (string)Session["mybal"];
            namelabel.Text = (string)Session["myname"];
            
        }
        catch (Exception)
        {

            Response.Redirect("~/Default.aspx");
        }
       }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        try
        {

            string string_amount = amountTextBox4.Text.ToString();
            int amnt = Convert.ToInt32(string_amount);




            SqlConnection cn1 = new SqlConnection(constring);


            cn1.Open();

            string sql = "SELECT account_no FROM tbl_user_client WHERE (UserName = '" + Label1.Text + "');";
            SqlCommand cmd = new SqlCommand(sql, cn1);


            string string_account = cmd.ExecuteScalar().ToString();
            int acc = Convert.ToInt32(string_account);



            cn1.Close();





            SqlConnection cn2 = new SqlConnection(constring);


            cn2.Open();

            string sql1 = "select  card_serial,pin_no from tbl_card where account_no=" + acc + ";";
            SqlCommand cmd1 = new SqlCommand(sql1, cn2);
            SqlDataReader datas = cmd1.ExecuteReader();
            if (datas.Read())
            {
                if (cardserialTextBox5.Text == datas.GetValue(0).ToString() && pinTextBox6.Text == datas.GetValue(1).ToString() && amnt <= 20000)
                {

                    SqlConnection cn = new SqlConnection(constring);

                    cn.Open();

                    string string_balance = balanceTextBox3.Text;
                    double balance = Convert.ToDouble(string_balance);

                    if (balance > 1000 && balance - amnt > 1000)
                    {
                        int j, k;
                        SqlTransaction trans;


                        trans = cn.BeginTransaction();
                        string from_updat = "update basicinfo set initial=initial-'" + amnt + "' where account_no='" + acc + "';";

                        SqlCommand updatecmd1 = new SqlCommand(from_updat, cn);

                        updatecmd1.Transaction = trans;

                        string to_updat = "update basicinfo set initial=initial+'" + amnt + "' where account_no='" + accTextBox1.Text + "';";
                        SqlCommand updatecmd2 = new SqlCommand(to_updat, cn);

                        updatecmd2.Transaction = trans;

                        j = updatecmd1.ExecuteNonQuery();
                        k = updatecmd2.ExecuteNonQuery();
                        if (j == 1 && k == 1)
                        {
                            trans.Commit();
                            int f;
                            string creditinsert = "insert into tbl_credit (account_no,name,amount,date) values ('" + acc + "','" + namelabel.Text + "','" + amountTextBox4.Text + "','" + DateTime.Now + "');";
                            SqlCommand creditcommand = new SqlCommand(creditinsert, cn);
                            f = creditcommand.ExecuteNonQuery();

                            int g;
                            string debittinsert = "insert into tbl_debit (accout_no,name,debit_amount,date) values ('" + accTextBox1.Text + "','" + nameTextBox2.Text + "','" + amountTextBox4.Text + "','" + DateTime.Now + "');";
                            SqlCommand debitcommand = new SqlCommand(debittinsert, cn);
                            g = debitcommand.ExecuteNonQuery();
                            cn.Close();

                            balancelabel.Visible = true;
                            reset();

                        }
                        else
                        {
                            trans.Rollback();



                        }
                    }
                    else {
                        Label2.Visible = true;
                    }


             



                }
                else {
                    Label2.Visible = true;
                }
            }
            else
            {
                
              // Response.Redirect(Label2.Text,true);
                Label2.Visible = true;
            }



            cn2.Close();



        }
        catch (Exception) {

            Response.Redirect("~/transfer.aspx");
            Label2.Visible = true;
        }

 

    }























    protected void accTextBox1_TextChanged(object sender, EventArgs e)
    {
        try
        {
            SqlConnection cn = new SqlConnection(constring);


            cn.Open();


            string sql = "select name from basicinfo where account_no='" + accTextBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader datas = cmd.ExecuteReader();
            if (datas.Read())
            {
                nameTextBox2.Text = datas.GetValue(0).ToString();

            }
            else
            {
                nameTextBox2.Text = "No result found";

            }

        }
        catch (Exception)
        {

            Response.Redirect("~/Default.aspx");
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("~/Default.aspx");
        Session.Clear();
        
    }
    public void reset() {
        accTextBox1.Text = string.Empty;
        nameTextBox2.Text = string.Empty;
        cardserialTextBox5.Text = string.Empty;
        pinTextBox6.Text = string.Empty;
        nameTextBox2.Text = string.Empty;
        amountTextBox4.Text = string.Empty;
    }
}