using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_Acme_Customer_Management_.BLL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retorna un producto
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if(productId == 1)
            {
                product.CurrencyPrice = 12.5M;
                product.ProductName = "Llantas Pirelli";
                product.ProductDescription = "llantas";
            }
            return product;            
        }

        /// <summary>
        /// Guarda El producto actual
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;
            if(product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {
                        //llamar a un procedimiento almacenado de inserción
                    }
                    else
                    {
                        //llamar a un procedimiento de actualizacion
                    }
                }else
                {
                    success = false;
                }
            }
            return success;
        }

       
    }
}
