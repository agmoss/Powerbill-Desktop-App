using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBill
{
    public partial class ChargeForm : Form
    {
        public ChargeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Instantiate Customer Object
        /// </summary>

        public CustomerData.Customer getCustomerObject()
        {

            if (rbCommercial.Checked)
            {
                //Instantate new Commercial customer
                CustomerData.CommercialCustomer newCust = new CustomerData.CommercialCustomer(Convert.ToInt32(txtAcctNum.Text), Convert.ToString(txtCustName.Text), Convert.ToDouble(txtKwh.Text));
                return newCust;

            }
            else if (rbIndustrial.Checked)
            {
                //Instantiate new Industrial customer
                CustomerData.IndustrialCustomer newCust = new CustomerData.IndustrialCustomer(Convert.ToInt32(txtAcctNum.Text), Convert.ToString(txtCustName.Text), Convert.ToDouble(txtPeakKwh.Text), Convert.ToDouble(txtNonPeakKwh.Text));
                return newCust;
            }
            else
            {
                //Instantiate new Residential customer
                CustomerData.ResidentialCustomer newCust = new CustomerData.ResidentialCustomer(Convert.ToInt32(txtAcctNum.Text), Convert.ToString(txtCustName.Text), Convert.ToDouble(txtKwh.Text));
                return newCust;
            }
        }

        /// <summary>
        /// FileIO
        /// </summary>

        public void populateLstBox()
        {
            string[] readText = FileIO.getTxtLines();

            foreach (string line in readText)

            {
                lstCustomers.Items.Add(line);
            }
        }

        /// <summary>
        /// Customer Statistics
        /// </summary>

        public void updateStats()
        {
            txtNumCust.Text = lstCustomers.Items.Count.ToString();

            Dictionary<string, double> CurrentCharge = Statistics.totalCharge(lstCustomers.Items.OfType<string>().ToArray());
            txtSumCharge.Text = CurrentCharge["total"].ToString();
            txtIcharge.Text = CurrentCharge["industrial"].ToString();
            txtCcharge.Text = CurrentCharge["commercial"].ToString();
            txtRcharge.Text = CurrentCharge["residential"].ToString();
        }

        /// <summary>
        /// Event Handlers
        /// </summary>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                errorProvider1.Clear();
                CustomerData.Customer newCust = getCustomerObject();
                lstCustomers.Items.Add(newCust.ToString() + ", " + newCust.CalculateCharge());
                updateStats();
            }
        }

        private void calcCharge_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                errorProvider1.Clear();
                CustomerData.Customer newCust = getCustomerObject();
                txtCharge.Text = newCust.CalculateCharge().ToString("f2");
            }
        }

        private void ChargeForm_Load(object sender, EventArgs e)
        {
            //Check of the default customer type on load
            rbResidential.Checked = true;
            populateLstBox();
            updateStats();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Save the listbox
            FileIO.saveListBox(lstCustomers);

            //Close the form
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Create an instance of a form and assign it the currently active form.
            Form currentForm = Form.ActiveForm;

            foreach (Control c in currentForm.Controls)
            {
                if (c is TextBox && c.Enabled == true)
                {
                    TextBox tb = c as TextBox;
                    if (tb.Text != string.Empty) //Textbox has content
                    {
                        tb.Text = string.Empty; //Clear the textbox
                    }
                }
            }
        }

        private void rbResidential_CheckedChanged(object sender, EventArgs e)
        {
            //Label visibility
            lblKwh.Visible = true;
            lblPeakKwh.Visible = false;
            lblNonPeakKwh.Visible = false;

            //textbox visibility
            txtPeakKwh.Visible = false;
            txtNonPeakKwh.Visible = false;
            txtKwh.Visible = true;
        }

        private void rbCommercial_CheckedChanged(object sender, EventArgs e)
        {
            //Label Visibility
            lblKwh.Visible = true;
            lblPeakKwh.Visible = false;
            lblNonPeakKwh.Visible = false;

            //Textbox Visibility
            txtKwh.Visible = true;
            txtPeakKwh.Visible = false;
            txtNonPeakKwh.Visible = false;
        }

        private void rbIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            //Label visibility
            lblKwh.Visible = false;
            lblPeakKwh.Visible = true;
            lblNonPeakKwh.Visible = true;

            //Textbox visibility
            txtKwh.Visible = false;
            txtPeakKwh.Visible = true;
            txtNonPeakKwh.Visible = true;
        }

        /// <summary>
        /// Validator
        /// </summary>

        private bool IsValid()
        {
            bool no_error = true;

            if (txtCustName.Text == string.Empty)
            {
                errorProvider1.SetError(txtCustName, "Customer name is missing");
                no_error = false;
            }
            else
            {
                // Clear all Error Messages
                try
                {
                    int i = Convert.ToInt32(txtAcctNum.Text);
                }
                catch
                {
                    errorProvider1.Clear(); 
                    errorProvider1.SetError(txtAcctNum, "Account number must be an integer");
                    return false;
                }

                //Now differientate between industrial and non industrial customers
                if (!rbIndustrial.Checked)
                {
                    try
                    {
                        double j = Convert.ToDouble(txtKwh.Text);
                    }
                    catch
                    {
                        errorProvider1.Clear(); 
                        errorProvider1.SetError(txtKwh, "Please enter a valid KWH value");
                        return false;
                    }
                }
                else
                {
                    try
                    {
                        double b = Convert.ToDouble(txtPeakKwh.Text);
                    }
                    catch
                    {
                        errorProvider1.Clear(); 
                        errorProvider1.SetError(txtPeakKwh, "Please enter a valid peak KWH value");
                        return false;
                    }
                    try
                    {
                        double t = Convert.ToDouble(txtNonPeakKwh.Text);
                    }
                    catch
                    {
                        errorProvider1.Clear(); 
                        errorProvider1.SetError(txtNonPeakKwh, "Please enter a valid non peak KWH value");
                        return false;
                    }
                }
            }
            return no_error;

        }                
    }
}


