using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBill
{
    class Validator
    {
        //Test if textbox is empty or not (required field)
        public static bool isProvided(TextBox tb, string name)
        {
            bool result = true;

            if (tb.Text == string.Empty)  //empty text box
            {
                result = false;
                MessageBox.Show(name + " is required", "data entry error");
                tb.Focus();
            }
            return result;
        }

        //Test if textbox is empty or not (required field)
        public static bool isProvided(TextBox tb)
        {
            bool result = true;

            if (tb.Text == string.Empty)  //empty text box
            {
                result = false;
                tb.Focus();
            }
            return result;
        }

        //Check if two textboxes are both empty
        public static bool isProvided(TextBox tb1, TextBox tb2)
        {
            bool result = true;

            if ((tb1.Text == string.Empty) && (tb2.Text == string.Empty))  //empty text box
            {
                result = false;
                MessageBox.Show("Provide at least one value");
            }
            return result;
        }

        //Test if input is non neg int
        public static bool isNonNegInt(TextBox tb, string name)
        {
            bool result = true;
            int pNum; //parsed number

            if (!Int32.TryParse(tb.Text, out pNum)) //tests if not integer
            {
                result = false;
                MessageBox.Show(name + " has to be an integer", "Data entry error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (pNum < 0)
            {
                result = false;
                MessageBox.Show(name + " has to be a positive value", "Data entry error");
                tb.SelectAll();
                tb.Focus();
            }

            return result;
        }

        //Test if input is non neg int
        public static bool isNonNegInt(string val,TextBox tb, string name)
        {
            bool result = true;

            int pNum; //parsed number

            if (!Int32.TryParse(val.ToString(), out pNum)) //tests if not integer
            {
                result = false;
                MessageBox.Show(name + " must be an integer value", "Data entry error");
                tb.SelectAll();
                tb.Focus();
                return result;

            }

            else if (Convert.ToInt32(val) < 0)
            {
                result = false;
                MessageBox.Show(name + " has to be a positive int value", "Data entry error");
                tb.SelectAll();
                tb.Focus();
                return result;
            }

            return result;
        }

        //Test if input is non neg double
        public static bool isNonNegDouble(TextBox tb, string name)
        {
            bool result = true;
            double pNum; //parsed number

            if (!Double.TryParse(tb.Text, out pNum)) //tests if not integer
            {
                result = false;
                MessageBox.Show(name + " has to be an integer", "Data entry error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (pNum < 0)
            {
                result = false;
                MessageBox.Show(name + " has to be a positive value", "Data entry error");
                tb.SelectAll();
                tb.Focus();
            }

            return result;
        }

        //Replace a blank string with 0
        public static string removeBlankString(String input)
        {
            string result;

            if (input == string.Empty)
            {
                result = "0";
            }
            else
            {
                result = input;
            }
            return result;
        }

    }
}
