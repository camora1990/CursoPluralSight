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
    }
}
