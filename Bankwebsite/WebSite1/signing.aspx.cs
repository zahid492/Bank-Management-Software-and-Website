using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class signing : System.Web.UI.Page
{
    public string constring = connectionstring.sqlconstring;
    protected void Page_Load(object sender, EventArgs e)
    {
       Label1.Visible = false;
    }

    protected void CreateUserWizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
    {

        try
        {
            SqlConnection cn1 = new SqlConnection(constring);


            cn1.Open();

            string sql = "SELECT basicinfo.name, tbl_card.card_serial, tbl_card.pin_no FROM basicinfo INNER JOIN tbl_card ON basicinfo.account_no = tbl_card.account_no WHERE (basicinfo.account_no = '" + accTextBox1.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, cn1);
            SqlDataReader datas = cmd.ExecuteReader();
            if (datas.Read())
            {
                if (nameTextBox2.Text == datas.GetValue(0).ToString() && serialTextBox3.Text == datas.GetValue(1).ToString() && pinTextBox4.Text == datas.GetValue(2).ToString())
                {
                    Response.Write("You succesfully verified ");
                }
                else
                {

                    // Errormsg.Visible = true;
                    Label1.Visible = true;
                    Response.Write("You do not logged in");
                    Response.Redirect("~/signing.aspx");
                 
                    Label1.Text = "Wrong Information ,Check Your Info.";
                    


                }


            }
            else
            {
                //Errormsg.Visible = true;
                Response.Write("You do not logged in");

                Response.Redirect("~/signing.aspx");
                Label1.Visible = true;
                Label1.Text = "Wrong Information ,Check Your Info.";

            }
            cn1.Close();
        }
        catch (Exception) {
            Response.Redirect("~/signing.aspx");
        }
        }
   

    
    
    protected void CreateUserWizard1_ContinueButtonClick(object sender, EventArgs e)
    {

       
    }
    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        try
        {
            int j;
            SqlConnection cn = new SqlConnection(constring);

            cn.Open();


            string insert = "insert into tbl_user_client (account_no,name,card_serial,UserName) values ('" + accTextBox1.Text + "','" + nameTextBox2.Text + "','" + serialTextBox3.Text + "','" + CreateUserWizard1.UserName + "') ;";
            SqlCommand command = new SqlCommand(insert, cn);
            j = command.ExecuteNonQuery();
            cn.Close();
        }
        catch (Exception) {
            Response.Redirect("~/signing.aspx");
        }
          
    
    }
}