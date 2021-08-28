using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace glasses_Shop
{
    public partial class frmTotalPrice : Form
    {
        public frmTotalPrice()
        {
            InitializeComponent();
        }

        //glasses_ShopDataContext nor = new glasses_ShopDataContext();
        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;database=glasses_shop;Integrated Security=true");
        decimal  h;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string a = "select  sum(price)  from Customer where [date] between  @txtDate1 and @txtDate2";
                con.Open();
                SqlCommand com1 = new SqlCommand(a, con);
                com1.Parameters.AddWithValue("@txtDate1", Convert.ToDateTime(txtDate1.Text));
                com1.Parameters.AddWithValue("@txtDate2", Convert.ToDateTime(txtDate2.Text));

                h = (decimal)com1.ExecuteScalar();
                lblTotal.Text = h.ToString();
            }
            catch(FormatException ex)
            {
                if (ex.Message == "String was not recognized as a valid DateTime.")
                {
                    MessageBox.Show("من فضلك أدخل التاريخ بشكل مناسب ");
                }
                else
                {
                    MessageBox.Show(ex.Message );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.Message );
            }
            finally
            {
                con.Close();
            }
        }

        private void Justdate(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 8)
            {
                e.Handled = false;

            }

            // 47 هذه العلامة / هي 
            if (e.KeyChar == 47)
            {
                e.Handled = false;

            }

        }
        



     
    }
}
