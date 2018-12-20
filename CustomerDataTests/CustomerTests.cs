using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    [TestClass()]
    public class CustomerTests
    {

        /// <summary>
        /// Residential Customer class tests
        /// </summary>

        [TestMethod()]
        public void TestCalculateChargePosKwhResidential()
        {
            //Arrange
            ResidentialCustomer r1 = new ResidentialCustomer(10, "Andrew", 20);
            double expected = 7.04;


            //Act
            double chargAmt = r1.CalculateCharge();

            //Assert
            Assert.AreEqual(chargAmt, expected);
        }

        [TestMethod()]
        public void TestCalculateChargeNegKwhResidential()
        {
            //Arrange
            ResidentialCustomer r1 = new ResidentialCustomer(10, "Andrew", -20);
            double expected = 0;

            //Act
            double chargeAmt = r1.CalculateCharge();

            //Assert
            Assert.AreEqual(chargeAmt, expected);
        }

        [TestMethod()]
        public void CustomerTypeResidential()
        {
            //Arrange
            ResidentialCustomer r1 = new ResidentialCustomer(10, "Andrew", 20);
            char expected = 'R';

            //Assert
            Assert.AreEqual(expected, r1.CustType);

        }

        /// <summary>
        /// Commercial customer class tests
        /// </summary>

        [TestMethod()]
        public void TestCalculateChargePosKwhCommercial()
        {
            //Arrange
            CommercialCustomer c1 = new CommercialCustomer(10, "Andrew", 150);
            double expected = 66.75;


            //Act
            double chargAmt = c1.CalculateCharge();

            //Assert
            Assert.AreEqual(chargAmt, expected);
        }

        [TestMethod()]
        public void TestCalculateChargeNegKwhCommercial()
        {
            //Arrange
            CommercialCustomer c1 = new CommercialCustomer(10, "Andrew", -20);
            double expected = 0;

            //Act
            double chargeAmt = c1.CalculateCharge();

            //Assert
            Assert.AreEqual(chargeAmt, expected);
        }

        [TestMethod()]
        public void CustomerTypeCommercial()
        {
            //Arrange
            CommercialCustomer c1 = new CommercialCustomer(10, "Andrew", 20);
            char expected = 'C';

            //Assert
            Assert.AreEqual(expected, c1.CustType);

        }


        /// <summary>
        /// Industrial customer class tests
        /// </summary>

        [TestMethod()]
        public void TestCalculateChargePosKwhIndustrial()
        {
            //Arrange
            IndustrialCustomer i1 = new IndustrialCustomer(10, "Andrew", 30, 40);
            double expected = 119.07;

            //Act 
            double chargeAmt = i1.CalculateCharge();

            //Assert
            Assert.AreEqual(chargeAmt, expected);
        }


        [TestMethod()]
        public void TestCalculateChargeNegKwhIndustrial()
        {
            //Arrange
            IndustrialCustomer i1 = new IndustrialCustomer(10, "Andrew", -30, -40);
            double expected = 0;

            //Act 
            double chargeAmt = i1.CalculateCharge();

            //Assert
            Assert.AreEqual(chargeAmt, expected);

        }
    }

}