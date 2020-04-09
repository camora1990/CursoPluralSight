using System;
using ACM_Acme_Customer_Management_.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange (Organizar)
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                CurrencyPrice = 12.5M,
                ProductDescription = "Llanta",
                ProductName = "Llanta Pirreli"
            };

            //-- Act (Actuar)
            var actual = productRepository.Retrieve(1);

            //-- Assert (Asignar)
            Assert.AreEqual(expected.ProductId, actual.ProductId);
        }
    }
}
