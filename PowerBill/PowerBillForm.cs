﻿using System;
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
        /// Access form elements and validate
        /// </summary>

        private string getCustName()
        {
            String boxVal = Convert.ToString(txtCustName.Text);
            return boxVal;
        }

        private double getKwh()
        {
            if (Validator.isNonNegDouble(txtKwh, "kWh"))
            {
                //Obtain kWh
                return Convert.ToDouble(txtKwh.Text);
            }

            return 0;
        }

        private int getAccountNumber()
        {
            if (Validator.isNonNegInt(txtAcctNum, "AccountNumber"))
            {
                //Obtain kWh
                return Convert.ToInt32(txtAcctNum.Text);
            }

            return 0;
        }

        private double getPeakKwh()
        {
            if (Validator.isNonNegDouble(txtPeakKwh, "Peak Kwh"))
            {
                //Obtain kWh
                return Convert.ToDouble(txtPeakKwh.Text);
            }

            return 0;
        }

        private double getNonPeakKwh()
        {
            if (Validator.isNonNegDouble(txtPeakKwh, "AccountNumber"))
            {
                //Obtain kWh
                return Convert.ToDouble(txtPeakKwh.Text);
            }

            return 0;
        }

        //Obtain total charge based on customer type and kWh
        private char getCustType()
        {

            //Commercial Customer
            if (rbCommercial.Checked)
            {
                return 'C';
            }
            //Residential Customer
            else if (rbIndustrial.Checked)
            {
                return 'I';
            }
            //Industrial Customer
            else //Default residential customer
            {
                return 'R';
            }

        }

        public CustomerData.Customer getCustomerObject()
        {
            char custType = getCustType();


            if (custType == 'C')
            {
                //Instantate new Commercial customer
                CustomerData.CommercialCustomer newCust = new CustomerData.CommercialCustomer(getAccountNumber(), getCustName(), getKwh());
                return newCust;

            }
            else if (custType == 'I')
            {
                //Instantiate new Industrial customer
                CustomerData.IndustrialCustomer newCust = new CustomerData.IndustrialCustomer(getAccountNumber(), getCustName(), getPeakKwh(), getNonPeakKwh());
                return newCust;
            }
            else
            {
                //Instantiate new Residential customer
                CustomerData.ResidentialCustomer newCust = new CustomerData.ResidentialCustomer(getAccountNumber(), getCustName(), getKwh());
                return newCust;
            }

        }

        /// <summary>
        /// FileIO
        /// </summary>

        public void populateLstBox()
        {

            string [] readText = FileIO.getTxtLines();

            foreach (string line in readText)

            {
                lstCustomers.Items.Add(line);
            }

        }

        public void updateStats()
        {
            txtNumCust.Text = lstCustomers.Items.Count.ToString();

            Dictionary<string,double> CurrentCharge = Statistics.totalCharge(lstCustomers.Items.OfType<string>().ToArray());
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
            CustomerData.Customer newCust = getCustomerObject();
            lstCustomers.Items.Add(newCust.ToString() + ", " + newCust.CalculateCharge());
            updateStats();
        }

        private void calcCharge_Click(object sender, EventArgs e)
        {
            CustomerData.Customer newCust = getCustomerObject();
            txtCharge.Text = newCust.CalculateCharge().ToString("f2");
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
                if (c is TextBox && c.Enabled ==true)
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
    }
}
