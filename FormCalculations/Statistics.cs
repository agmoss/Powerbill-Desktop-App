using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCalculations
{
    public static class Statistics
    {

        /// <summary>
        /// Form Statistics
        /// </summary>

        public static void numberOfCustomers()
        {
            txtNumCust.Text = lstCustomers.Items.Count.ToString();
        }

        public static double totalCharge()
        {
            string[] contents = lstCustomers.Items.OfType<string>().ToArray();
            double[] charges = new double[contents.Length];

            int count = 0;
            foreach (string item in contents)
            {
                string substring = item.Split(',')[4];

                //Cast to double
                charges[count++] = Convert.ToDouble(substring);

            }

            return charges.Sum();
        }
    }
}
