using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Threading;

public partial class contactus : System.Web.UI.Page
{

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        Thread thread = new Thread(send_mail);
        thread.Start();


    }
    private void send_mail()
    {
        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        client.EnableSsl = true;
        MailAddress from = new MailAddress(emailTextBox2.Text, "Contact query");
        MailAddress to = new MailAddress("shuvorakib@gmail.com","Contact query");
        MailMessage message = new MailMessage(@from, to);
        message.Body = "Hi I am " + nameTextBox1.Text + ",\n"+msgTextBox3.Text+"\n From "+emailTextBox2.Text;
        message.Subject = "Contact query";
        NetworkCredential credential = new NetworkCredential("shuvorakib@gmail.com", "320takaa", "");
        client.Credentials = credential;
        try
        {
            status.Visible = true;
            status.Text = "Message sent succesfully........";
            client.Send(message);
          
        }

        catch (Exception)
        {
            status.Visible = true;
            status.Text = "Message sent failed.........";
          
        }



    }
    protected void Page_Load(object sender, EventArgs e)
    {
        status.Visible = false;
    }
}