using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class IndustrialCustomer : Customer
    {
        //Members
        private char custType = 'I';
        private double peakKwh;
        private double nonPeakKwh;

        //Properties
        public char CustType { get => custType;}
        public double PeakKwh { get => peakKwh; set => peakKwh = value; }
        public double NonPeakKwh { get => nonPeakKwh; set => nonPeakKwh = value; }


        //Constructor
        public IndustrialCustomer(int AccountNumber, string CustomerName, double Peak_Kwh, double Non_Peak_Kwh)
        {
            this.CustName = CustomerName;
            this.AccountNo = AccountNumber;
            PeakKwh = Peak_Kwh;
            NonPeakKwh = Non_Peak_Kwh;

        }

        public override string ToString()
        {
            return AccountNo + ", " + CustName + ", " + CustType + ", " + PeakKwh + ", " + NonPeakKwh;
        }

        public override double CalculateCharge()
        {
            double peakCharge;
            double nonPeakCharge;


            if (PeakKwh > 0)
            {
                peakCharge = 76 + PeakKwh % 1000 * 0.065;
            }
            else
            {
                peakCharge = 0;
            }


            if (NonPeakKwh > 0)
            {
                nonPeakCharge = nonPeakCharge = 40 + NonPeakKwh % 1000 * 0.028;
            }
            else
            {
                nonPeakCharge = 0;
            }

   
            return peakCharge + nonPeakCharge;
        }
    }
}
