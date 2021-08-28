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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool load = false;
        int h = 9;
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;database=glasses_shop;Integrated Security=true");
        glasses_shopDataContext nor = new glasses_shopDataContext();
        int a = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCobName();

            //for (int i = 0; i < dt.Rows.Count ; i++)
            //{
            //    ComboName.Items.Add(dt.Rows[i]["Name"]);
            //}


            //Convert.ToInt32( ComboName.SelectedValue)

            
            
        }

        private void FillCobName()
        {

            using (SqlDataAdapter da = new SqlDataAdapter("select ID,Name from Customer", con))
            {

                DataTable dt = new DataTable();
                da.Fill(dt);

                ComboName.DataSource = dt;
                ComboName.ValueMember = dt.Columns[0].ToString();
                ComboName.DisplayMember = dt.Columns[1].ToString();
                con.Close();
            }
            
        }


       

        private void Form1_Shown(object sender, EventArgs e)
        {
            load = true;

        }

    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            EnabledTextboxes();
            a = 0;
            try

            {
            //System.InvalidOperationException ex=new InvalidOperationException ();

            //if ( ex.Message=="Sequence contains no elements")
            //{
            var customer = nor.Customers.Single(cust => cust.id == Convert.ToInt32(ComboName.SelectedValue));
            
                
                txtID.Text = customer.id.ToString();
                label3.Visible = true;
                txtNewName.Visible = true;
                //txtNewName.Enabled = true;
                txtNewName.Text = customer.Name;
                txtDoctor.Text = customer.doctorname;
                txtDate.Text = customer.date.ToString();
                txtPrice.Text = customer.price.ToString();
                txtobservation.Text = customer.observations;
                txtLencetype.Text = customer.lensec_Id.ToString();
                txtTele.Text = customer.tele.ToString();
                txtDLax.Text = customer.DL_ax.ToString();
                txtDLcyx.Text = customer.DL_cyx.ToString();
                txtDLsph.Text = customer.DL_sph.ToString();
                txtRLSPH.Text = customer.RL_ax.ToString();
                txtRLcyx.Text = customer.RL_cyx.ToString();
                txtRLAx.Text = customer.RL_ax.ToString();
                txtRRsph.Text = customer.RL_sph.ToString();
                txtRRcyx.Text = customer.RR_cyx.ToString();
                txtRRax.Text = customer.RR_ax.ToString();
                txtDRax.Text = customer.DR_ax.ToString();
                txtDRcyx.Text = customer.DR_cyx.ToString();
                txtDRsph.Text = customer.DR_sph.ToString();
                txtD_IPD.Text = customer.D_IPD.ToString();
                txtR_IPD.Text = customer.R_IPD.ToString();
                btnIns_Update.Text = "تعديل";
            //}
            }
            //else
            //{
            catch (System.InvalidOperationException ex)
            {
                if (ex.Message == "Sequence contains no elements")
                {
                    a = 1;
                    con.Open();
                    SqlCommand com1 = new SqlCommand("select max(ID) from Customer", con);
                    h = (int)com1.ExecuteScalar() + 1;
                    txtID.Text = h.ToString();
                    con.Close();

                    EmptyTextboxes();
                btnIns_Update.Text = "إضافة";

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            //}

        }

        private void EmptyTextboxes()
        {
            txtDoctor.Text = "";
            txtTele.Text = "";
            txtDate.Text = "";
            txtPrice.Text = "";
            txtobservation.Text = "";
            txtLencetype.Text = "";
            txtDLax.Text = "";
            txtDLcyx.Text = "";
            txtDLsph.Text = "";
            txtRLSPH.Text = "";
            txtRLcyx.Text = "";
            txtRLAx.Text = "";
            txtRRsph.Text = "";
            txtRRcyx.Text = "";
            txtRRax.Text = "";
            txtDRax.Text = "";
            txtDRcyx.Text = "";
            txtDRsph.Text = "";
            txtD_IPD.Text = "";
            txtR_IPD.Text = "";
            txtNewName.Text = "";
        }

        private  void EnabledTextboxes()
        {
            lblID.Enabled =true;
            lblDoctor.Enabled = true;
            lbldate.Enabled = true;
            lblLence.Enabled = true;
            lblObservation.Enabled = true;
            lblPrice.Enabled = true;
            lblTelephone.Enabled = true;
            lblTelephone.Enabled = true;
            txtTele.Enabled = true;
            txtobservation.Enabled = true;
            txtPrice.Enabled = true;
            txtDoctor.Enabled = true;
            txtDate.Enabled = true;
            txtLencetype.Enabled = true;
            txtDate.Enabled = true;
            TableLayoutPanel1.Enabled = true;
            btnIns_Update.Visible = true;
            txtNewName.Visible = false;
            label3.Visible = false;

        }
        private void disabledTextboxes()
        {
            lblID.Enabled = false;
            lblDoctor.Enabled = false;
            lbldate.Enabled = false;
            lblLence.Enabled = false;
            lblObservation.Enabled = false;
            lblPrice.Enabled = false;
            lblTelephone.Enabled = false;
            txtTele.Enabled = false;
            txtobservation.Enabled = false;
            txtPrice.Enabled = false;
            txtDoctor.Enabled = false;
            txtDate.Enabled = false;
            txtLencetype.Enabled = false;
            txtDate.Enabled = false;
            TableLayoutPanel1.Enabled = false;
            btnIns_Update.Visible = false;
            txtNewName.Visible = false;
            label3.Visible = false;
            

        }
        private void btnIns_Update_Click(object sender, EventArgs e)
        {
            if (txtDate.Text == "")
            {
                MessageBox.Show("من فضلك أدخل التاريخ");
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("من فضلك أدخل السعر");
                return;
            }
            disabledTextboxes();
              if (a==0)
            {
                  
                Customer customer = nor.Customers.Single(cust => cust.id == Convert.ToInt32(ComboName.SelectedValue));
                customer.id = Convert.ToInt32(txtID.Text);
                customer.Name = txtNewName.Text;
                fillFieldsInDatabaseWithValuesIntextboxes(customer);
                nor.SubmitChanges();

                MessageBox.Show("تمت التعديل بنجاح");
                FillCobName();

            }
           

            //nor.SubmitChanges();
            if (a == 1)
            {
                //Customer customer = nor.Customers.Single(cust => cust.id == h);
                Customer customer = new Customer();
                ////customer.id = h;
                customer.Name = ComboName.Text;
                //customer.doctorname = txtDoctor.Text;
                //customer.date = Convert.ToDateTime(txtDate.Text);
                //customer.price = Convert.ToDecimal(txtPrice.Text);
                //customer.lensec_Id = txtLencetype.Text;
                //customer.observations = txtobservation.Text;
                //customer.tele = txtTele.Text;
                //customer.DL_ax = Convert.ToDouble(txtDLax.Text);
                //customer.DL_cyx = Convert.ToDouble(txtDLcyx.Text);
                //customer.DL_sph = Convert.ToDouble(txtDLsph.Text);
                //customer.RL_sph = Convert.ToDouble(txtRLSPH.Text);
                //customer.RL_cyx = Convert.ToDouble(txtRLcyx.Text);
                //customer.RL_ax = Convert.ToDouble(txtRLAx.Text);
                //customer.RR_sph = Convert.ToDouble(txtRRsph.Text);
                //customer.RR_cyx = Convert.ToDouble(txtRRcyx.Text);
                //customer.RR_ax = Convert.ToDouble(txtRRax.Text);
                //customer.DR_ax = Convert.ToDouble(txtDRax.Text);
                //customer.DR_cyx = Convert.ToDouble(txtDRcyx.Text);
                //customer.DR_sph = Convert.ToDouble(txtDRsph.Text);
                //customer.D_IPD = Convert.ToDouble(txtD_IPD.Text);
                //customer.R_IPD = Convert.ToDouble(txtR_IPD.Text);
                fillFieldsInDatabaseWithValuesIntextboxes(customer);
                nor.Customers.InsertOnSubmit(customer);
                nor.SubmitChanges();
                MessageBox.Show("تمت الإضافة بنجاح");

                FillCobName();
                EmptyTextboxes();

                
            }

        }

        private void fillFieldsInDatabaseWithValuesIntextboxes(Customer customer)
        {
            customer.doctorname = txtDoctor.Text;
            customer.date = Convert.ToDateTime(txtDate.Text).Date;
            customer.price = Convert.ToDecimal(txtPrice.Text);
            customer.lensec_Id = txtLencetype.Text;
            customer.observations = txtobservation.Text;
            customer.tele = txtTele.Text;
            if (txtDLax.Text == "")
                customer.DL_ax = "0";
            else
                customer.DL_ax = txtDLax.Text;

            if (txtDLcyx.Text == "")
                customer.DL_cyx = "0";
            else 
            customer.DL_cyx = txtDLcyx.Text;

            if (txtDLsph.Text == "")
                customer.DL_sph = "0";
            else 
            customer.DL_sph = txtDLsph.Text;

            if (txtRLSPH.Text == "")
                customer.RL_sph = "0";
            else 
            customer.RL_sph = txtRLSPH.Text;

            if (txtRLcyx.Text == "")
                customer.RL_cyx = "0";
            else
                customer.RL_cyx = txtRLcyx.Text;

            if (txtRLAx.Text == "")
                customer.RL_ax = "0";
            else 
                customer.RL_ax = txtRLAx.Text;

            if (txtRRsph.Text == "")
                customer.RR_sph = "0";
            else
                customer.RR_sph = txtRRsph.Text;

            if (txtRRcyx.Text == "")
                customer.RR_cyx = "0";
            else
                customer.RR_cyx = txtRRcyx.Text;

            if (txtRRax.Text == "")
                customer.RR_ax = "0";
            else
            customer.RR_ax = txtRRax.Text;

            if (txtDRax.Text == "")
                customer.DR_ax = "0";
            else 
                customer.DR_ax = txtDRax.Text;

            if (txtDRcyx.Text == "")
                customer.DR_cyx = "0";
            else 
                customer.DR_cyx = txtDRcyx.Text;

            if (txtDRsph.Text == "")
                customer.DR_sph = "0";
            else 
                customer.DR_sph = txtDRsph.Text;

            if (txtD_IPD.Text == "")
                customer.D_IPD = "0";
            else
                customer.D_IPD = txtD_IPD.Text;

            if (txtR_IPD.Text == "")
                customer.R_IPD = "0";
            else 
                customer.R_IPD = txtR_IPD.Text;
        }

        private void ComboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = "";            
            EmptyTextboxes();
            disabledTextboxes();

        }


        private void JustLetter(object sender, KeyPressEventArgs e)
        {
            //Enter Just Leters in textbox Arabic Name,English Name,Nationality
            if (Char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
            }
            //8 bachspace , 32 space
            if (e.KeyChar == 8 || e.KeyChar == 32)
            {
                e.Handled = false;

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

        private void JustNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false || e.KeyChar == 8)
            {
                e.Handled = true;
            }


            if (e.KeyChar == 8)
            {
                e.Handled = false;

            }
        }

        private void JustDecimalNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false || e.KeyChar == 8)
            {
                e.Handled = true;
            }
            //هذه هي . العلامة العشرية
            if  (e.KeyChar== 46)
            {
                e.Handled = false;
            }
            //هذه علامة + وعلامة -  أ
            if (e.KeyChar == 43 || e.KeyChar == 45)
            {
                e.Handled = false;

            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;

            }

        }
        
       
    }
}
