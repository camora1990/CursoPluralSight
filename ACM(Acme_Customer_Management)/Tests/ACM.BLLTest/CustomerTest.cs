using System;
using ACM_Acme_Customer_Management_.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLLTest
{
    [TestClass]
    public class CustomerTest
    {
        //Pruebas para las propiedades
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange (Organizar)
            Customer customer = new Customer
            {
                FirtsName = "CAMILO",
                LastName = "MORALES"
            };
            string expected = "MORALES, CAMILO";

            //-- Act (Actuar)
            string actual = customer.FullName;

            //-- Assert (Asignar)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange (Organizar)
            Customer customer = new Customer
            {
                LastName = "MORALES",
            };
            string expected = "MORALES";

            //-- Act (Actuar)
            string actual = customer.FullName;

            //-- Assert (Asignar)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNamelastNameEmpty()
        {
            //-- Arrange (Organizar)
            Customer customer = new Customer
            {
                FirtsName= "CAMILO",
            };
            string expected = "CAMILO";

            //-- Act (Actuar)
            string actual = customer.FullName;

            //-- Assert (Asignar)
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Statictest()
        {
            //-- Arrange (Organizar)
            var custome1 = new Customer();
            custome1.FirtsName = "ALEJANDRO";
            Customer.InstanceCount += 1;

            var custome2 = new Customer();
            custome1.FirtsName = "MARITZA";
            Customer.InstanceCount += 1;

            var custome3 = new Customer();
            custome1.FirtsName = "ANDREA";
            Customer.InstanceCount += 1;

            int expected = 3;

            //-- Act (Actuar)
            int actual = Customer.InstanceCount;

            //-- Assert (Asignar)
            Assert.AreEqual(expected, actual);
        }


        //pruebas para los metodos

        [TestMethod]
        public void ValidateValid() // valida que tanto correo y Email esten correctos
        {
            //-- Arrange (Organizar)
            var custome1 = new Customer
            {
                LastName = "MORALES",
                EmailAddress = "morales@correo.com"
            };
            var expected = true;

            //-- Act (Actuar)
            var actual = custome1.Validate();

            //-- Assert (Asignar)
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ValidateMissingLastName() //valida que su respuesta sea falsecuando falta el lastName
        {
            //-- Arrange (Organizar)
            var custome1 = new Customer
            {
                EmailAddress = "morales@correo.com"
            };
            var expected = false;

            //-- Act (Actuar)
            var actual = custome1.Validate();

            //-- Assert (Asignar)
            Assert.AreEqual(expected, actual);
        }

    }
}
