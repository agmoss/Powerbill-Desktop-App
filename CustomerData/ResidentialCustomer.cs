﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class ResidentialCustomer : Customer
    {
        //Members
        private char custType = 'R';
        private double kwh;

        //Properties
        public char CustType { get => custType; set => custType = value; }
        public double Kwh { get => kwh; set => kwh = value; }


        //Constructor
        public ResidentialCustomer(int AccountNumber,string CustomerName,double KWH)
        {
            this.CustName = CustomerName;
            this.AccountNo = AccountNumber;
            Kwh = KWH;

        }

        public override string ToString()
        {
            return  AccountNo + ", " + CustName + ", " + CustType + ", " + Kwh;
        }

        public override double CalculateCharge()
        {
            if (Kwh > 0)
            {
                return 6 + 0.052 * Kwh;
            }

            return 0;
                
        }
    }
}