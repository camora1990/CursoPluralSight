using System;
using ACM_Acme_Customer_Management_.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange (Organizar)
            var orderrepository = new OrderRepository();
            var expected = new Order(12)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, DateTime.Now.Month, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //-- Act (Actuar)
            var actual = orderrepository.Retrieve(12);

            //-- Assert (Asignar)
            Assert.AreEqual(expected.OrderId, actual.OrderId);
        }

        /// <summary>
        ///  Prueba cuando una fecha de orden es correcta
        /// </summary>
        [TestMethod]
        public void SaveTestOrderDate()
        {
            //-- Arrange (Organizar)
            var orderRepository = new OrderRepository();
            var updateOrder = new Order(12)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, DateTime.Now.Month, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                HasChanges = true

            };
            //-- Act (Actuar)
            var actual = orderRepository.Save(updateOrder);
            //-- Assert (Asignar)
            Assert.AreEqual(true, actual);
        }

        /// <summary>
        /// prueba cuando una orden date es null
        /// </summary>
        [TestMethod]
        public void SaveTestValid()
        {
            //-- Arrange (Organizar)
            var orderRepository = new OrderRepository();
            var updateOrder = new Order(1)
            {
                OrderDate = null,
                HasChanges = true
               
            };
            //-- Act (Actuar)
            var actual = orderRepository.Save(updateOrder);
            //-- Assert (Asignar)
            Assert.AreEqual(false, actual);

        }

    }
}
