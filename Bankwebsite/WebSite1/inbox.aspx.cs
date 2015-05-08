using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class inbox : System.Web.UI.Page
{

    public string constring = connectionstring.sqlconstring;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Label1.Text = (string)Session["myvar1"];



            SqlConnection cn1 = new SqlConnection(constring);


            cn1.Open();

            string sql = "SELECT account_no FROM tbl_user_client WHERE (UserName = '" + Label1.Text + "');";
            SqlCommand cmd = new SqlCommand(sql, cn1);


            string account = cmd.ExecuteScalar().ToString();
            int acc = Convert.ToInt32(account);



            cn1.Close();


            SqlConnection cn2 = new SqlConnection(constring);


            cn2.Open();
            string sql1 = "select subject As Subject ,mail_body AS Message ,sent_date As Date from tbl_inbox where account_no='" + acc + "' order by sent_date desc";


            DataSet ds;
            SqlCommand cmd1 = new SqlCommand(sql1, cn2);

            SqlDataAdapter da = new SqlDataAdapter();

            da = new SqlDataAdapter(cmd1);

            ds = new DataSet();
            da.Fill(ds, "amnt,dat");
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            cn2.Close();
        }
        catch (Exception)
        {

            Response.Redirect("~/Default.aspx");
        }



        
        



       

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("~/Default.aspx");
        Session.Clear();
        
    }
}