using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bankproject
{
    public partial class loanmgt : Form
    {
        public loanmgt()
        {
            InitializeComponent();
        }



        private void nextbutton_Click(object sender, EventArgs e)
        {
            
            
               loanform loandisplay=new loanform();
                loandisplay.Show();
         
        
                    
                

            }


        private void loanmgt_Load(object sender, EventArgs e)
        {
            nextbutton.Visible = false;
            button1.Visible = false;
            

        }

        private void createbutton_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nextbutton.Visible = false;
      
            if(radioButton1.Checked==true)
            {
                nextbutton.Visible = true;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            if(radioButton2.Checked==true) 
            {
                button1.Visible = true;
            }
            
           

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            creat c = new creat();
            c.Show();
           this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
