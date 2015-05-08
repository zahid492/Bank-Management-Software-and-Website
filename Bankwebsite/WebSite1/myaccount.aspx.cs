using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;

public partial class myaccount : System.Web.UI.Page
{
    public string constring = connectionstring.sqlconstring;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Label1.Text = (string)Session["myvar"];
            //send data from inbox,transfer etc
            Session["myvar1"] = Label1.Text; 



            SqlConnection cn1 = new SqlConnection(constring);


            cn1.Open();

            string sql = "SELECT account_no FROM tbl_user_client WHERE (UserName = '" + Label1.Text + "');";
            SqlCommand cmd = new SqlCommand(sql, cn1);


            string amount = cmd.ExecuteScalar().ToString();
            int am = Convert.ToInt32(amount);



            cn1.Close();


            SqlConnection cn2 = new SqlConnection(constring);


            cn2.Open();

            string sql1 = "select account_no,name,phone,type,initial,email,open_date from basicinfo where account_no=" + am + ";";
            SqlCommand cmd1 = new SqlCommand(sql1, cn2);
            SqlDataReader datas = cmd1.ExecuteReader();
            if (datas.Read())
            {
                accLabel.Text = datas.GetValue(0).ToString();
                nameLabel5.Text = datas.GetValue(1).ToString();
                phoneLabel7.Text = datas.GetValue(2).ToString();
                typelabel.Text = datas.GetValue(3).ToString();
                balaLabel11.Text = datas.GetValue(4).ToString();
                mail.Text = datas.GetValue(5).ToString();
                datelabel.Text = datas.GetValue(6).ToString();

                Session["mybal"] = balaLabel11.Text;
                Session["myname"] = nameLabel5.Text;


            }

            else
            {

            }


            cn2.Close();
        }
        catch (Exception) { 
         Response.Redirect("~/Default.aspx");
        }
        


    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("~/Default.aspx");
        Session.Clear();
        
    }
}