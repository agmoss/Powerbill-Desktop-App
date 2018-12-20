using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public abstract class Customer
    {
        //Member variables
        private int accountNo;
        private string custName;

        //Properties
        public int AccountNo { get => accountNo; set => accountNo = value; }
        public string CustName { get => custName; set => custName = value; }


        //Calculate Charge 
        abstract public double CalculateCharge();

        //ToString
        abstract public override string ToString();

    }
}
