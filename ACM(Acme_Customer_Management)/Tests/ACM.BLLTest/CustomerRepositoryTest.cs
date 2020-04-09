using System;
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
                LastName="MORALES"
            };

            //-- Act (Actuar)
            var actual = customerRepository.Retrieve(1);

            //-- Assert (Asignar)
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        }
    }
}
