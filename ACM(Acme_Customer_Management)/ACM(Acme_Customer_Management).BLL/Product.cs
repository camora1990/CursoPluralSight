using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_Acme_Customer_Management_.BLL
{
    public class Product
    {

        public Product() { }
        public Product(int productId) => (ProductId) = (productId);

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrencyPrice { get; set; } // el ? significa que le asigna null al precio si no se a asignado

        /// <summary>
        /// Retorna si es valido la craecion del Product
        /// </summary>
        /// <returns></returns>
        public bool Validated()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrencyPrice == null) isValid = false;

            return isValid;
        }
    }
}
