using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class CommercialCustomer : Customer
    {
        //Members
        private char custType = 'C';
        private double kwh;

        //Properties
        public char CustType { get => custType;}
        public double Kwh { get => kwh; set => kwh = value; }


        //Constructor
        public CommercialCustomer(int AccountNumber, string CustomerName, double KWH)
        {
            this.CustName = CustomerName;
            this.AccountNo = AccountNumber;
            Kwh = KWH;

        }

        public override string ToString()
        {
            return AccountNo + ", " + CustName + ", " + CustType + ", " + Kwh;
        }

        public override double CalculateCharge()
        {
            if (Kwh > 0)
            {
                return 60 + kwh % 1000 * 0.045;
            }

            return 0;

        }
    }
}
