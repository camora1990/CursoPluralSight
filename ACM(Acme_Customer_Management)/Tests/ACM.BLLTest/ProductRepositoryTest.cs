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


        /// <summary>
        ///  Prueba cyuando un precio no es valido
        /// </summary>
        [TestMethod]
        public void SaveTestMissingPrice() 
        {
            //-- Arrange (Organizar)
            var productRepository = new ProductRepository();
            var updateProduct = new Product(1)
            {
                CurrencyPrice = null,
                ProductDescription = "Llanta",
                ProductName = "Llanta Pirreli",
                HasChanges = true
            };
            //-- Act (Actuar)
            var actual = productRepository.Save(updateProduct);
            //-- Assert (Asignar)
            Assert.AreEqual(false, actual);
        }


        /// <summary>
        /// prueba si el guardar es valido
        /// </summary>
        [TestMethod]
        public void SaveTestValid()
        {
            //-- Arrange (Organizar)
            var productRepository = new ProductRepository();
            var updateProduct = new Product(1)
            {
                CurrencyPrice = 12.0M,
                ProductDescription = "Llanta",
                ProductName = "Llanta Pirreli",
                HasChanges = true
            };
            //-- Act (Actuar)
            var actual = productRepository.Save(updateProduct);
            //-- Assert (Asignar)
            Assert.AreEqual(true, actual);
        }
    }
}
