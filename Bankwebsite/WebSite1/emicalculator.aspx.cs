using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class emicalculator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            double amount = double.Parse(amountTextBox1.Text);


            double month = double.Parse(monthTextBox2.Text);
            double inter_rate = double.Parse(interestTextBox3.Text);



            double mon_rate = inter_rate / 1200;

            double month_pay = amount * mon_rate / (1 - 1 / Math.Pow(1 + mon_rate, month));

            double total_payment = month_pay * month;


            monthlyamountTextBox4.Text = month_pay.ToString();
            totalamountTextBox5.Text = total_payment.ToString();
        }
        catch(Exception){
        Response.Redirect("~/emicalculator.aspx");}
    }
    protected void resteButton2_Click(object sender, EventArgs e)
    {
   
        amountTextBox1.Text = string.Empty;
        monthTextBox2.Text = string.Empty;
        monthlyamountTextBox4.Text = string.Empty;
        interestTextBox3.Text = string.Empty;
        totalamountTextBox5.Text = string.Empty;
   
        
    }
   
}