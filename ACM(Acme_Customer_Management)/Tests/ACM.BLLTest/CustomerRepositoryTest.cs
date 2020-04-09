using System;
using System.Collections.Generic;
using ACM_Acme_Customer_Management_.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange (Organizar)
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "camilo@correo.com",
                FirtsName = "CAMILO",
                LastName = "MORALES"
            };

            //-- Act (Actuar)
            var actual = customerRepository.Retrieve(1);

            //-- Assert (Asignar)
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange (Organizar)
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "camilo@correo.com",
                FirtsName = "CAMILO",
                LastName = "MORALES",
                AddressList = new List<Address>
                {
                    new Address
                    {
                        AddressType = 1,
                        StrestLine1 = "Cra 49",
                        StrestLine2 = "#69s-97",
                        City = "Sabaneta",
                        State = "Sabaneta",
                        Country = "Colombia",
                        PostalCode = "057",
                    },
                    new Address
                    {
                        AddressType = 2,
                        StrestLine1 = "Cra 68",
                        StrestLine2 = "#87-97",
                        City = "Medellin",
                        State = "Robledo",
                        Country = "Colombia",
                        PostalCode = "057",
                    }
                }
                
            };

            //-- Act (Actuar)
            var actual = customerRepository.Retrieve(1);

            //-- Assert (Asignar)
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirtsName, actual.FirtsName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].StrestLine1, actual.AddressList[i].StrestLine1);
                Assert.AreEqual(expected.AddressList[i].StrestLine2, actual.AddressList[i].StrestLine2);
            }
           

        }
    }
}