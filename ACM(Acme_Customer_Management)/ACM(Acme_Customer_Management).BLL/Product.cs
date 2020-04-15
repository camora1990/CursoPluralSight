using ACME.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_Acme_Customer_Management_.BLL
{
    public class Product : EntityBase
    {

        public Product() { }
        public Product(int productId) => (ProductId) = (productId);
        private string _productName;
        public int ProductId { get; private set; }
        public string ProductName 
        { 
            get 
            {
                //usamos la clase estatica de datos comunes que fue extendida
                return _productName.InsertSpaces();
            } 
            set 
            {
                _productName = value;
            } 
        }
        public string ProductDescription { get; set; }
        public decimal? CurrencyPrice { get; set; } // el ? significa que le asigna null al precio si no se a asignado

        /// <summary>
        /// Retorna si es valido la craecion del Product
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrencyPrice == null) isValid = false;

            return isValid;
        }

      

        public override string ToString() => ProductName;

       
    }
}
