using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBill
{
    class Statistics
    {

        /// <summary>
        /// Form Statistics
        /// </summary>

        public static Dictionary<string,double> totalCharge(string[] contents)
        {

            //Create return dictionary
            Dictionary<string, double> Charges = new Dictionary<string, double>();

            Charges.Add("total", 0);
            Charges.Add("residential", 0);
            Charges.Add("industrial", 0);
            Charges.Add("commercial", 0);
            
            if (contents.Length < 1) {
                return Charges;
            }

            double[] charges = new double[4];

            foreach (string item in contents)
            {

                string charge = item.Split(',')[4];

                Charges["total"] += Convert.ToDouble(charge);

                string type = item.Split(',')[2].Trim();

                if (type == "I")
                {

                    Charges["industrial"] += Convert.ToDouble(charge);
                }
                else if (type == "C")
                {
                    Charges["commercial"] += Convert.ToDouble(charge);
                }
                else
                {
                    Charges["residential"] += Convert.ToDouble(charge);
                }
            }

            return Charges;
        }
    }
}
