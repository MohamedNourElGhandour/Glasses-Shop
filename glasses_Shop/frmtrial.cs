using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace glasses_Shop
{
    public partial class frmtrial : Form
    {
        //private string My;
        public frmtrial()
        {
            InitializeComponent();
        }

        //static int ss = Properties.Settings.Default.trial;
        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }

        private void frmtrial_Load(object sender, EventArgs e)
        {

            label2.Text = Properties.Settings.Default.trial.ToString();
            if (Properties.Settings.Default.trial == 0 == true)
            {
                label2.Text = "This Trial has Expired. Call Mohammad Nour  +201112627380";
                btnStartProg.Enabled = false;
            }
            else
            {
            }
        }

        private void btnStartProg_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.trial == 0 == true)
            {
                btnStartProg.Enabled = false;

            }
            else
            {
                Properties.Settings.Default.trial -= 1;
                Properties.Settings.Default.Save();
                
                frmStart c = new frmStart();
                c.ShowDialog();
            }
            label2.Text = Properties.Settings.Default.trial.ToString();
            this.Close();
        }

        
    }
}
