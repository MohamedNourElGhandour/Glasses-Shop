using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace glasses_Shop
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void toolstripCustommer_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            m.ShowDialog();
        }

        private void toolstriptotalsales_Click(object sender, EventArgs e)
        {
            frmTotalPrice tsp = new frmTotalPrice();
            tsp.ShowDialog();
        }

       

        
    }
}
