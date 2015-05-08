using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace bankproject
{
    public partial class Form1 : Form
    {
        private string adminname = string.Empty;

        public Form1(string admin)
        {
            InitializeComponent();
            adminname = admin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            creat c=new creat();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            credit cre=new credit();
            cre.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            debit deb=new debit();
            deb.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transfer tran=new Transfer();
            tran.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loanmgt loan = new loanmgt();
            loan.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            check ch = new check();
            ch.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cardtext cardsystem=new cardtext();
            cardsystem.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loginform log = new loginform();
            log.Show();
            this.Hide();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
        manager_login manager=new manager_login();
            manager.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loginform log=new loginform();
            log.Show();
            
        }

      private void Form1_Load(object sender, EventArgs e)
      {


          name.Text = adminname;

      }

      private void button10_Click(object sender, EventArgs e)
      {
          currency_convertion currency=new currency_convertion();
          currency.Show();
      }

      private void button11_Click(object sender, EventArgs e)
      {
         statement st=new statement();
      
         st.Show();
      }

      private void button12_Click(object sender, EventArgs e)
      {
          About1 about1=new About1();
          about1.Show();
      }

      private void button13_Click(object sender, EventArgs e)
      {
          sending_mail send = new sending_mail();
          send.Show();
      }

     
    }
}
