using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_Acme_Customer_Management_.BLL
{
    public class OrderItem
    {
        public OrderItem() {}
        public OrderItem(int orderItemId) => (OrderItemId) = (orderItemId);

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; } //Precio de compra
        public int Quantity { get; set; }

        /// <summary>
        /// Retorna Una orden item
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve (int orderItemId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Retorna lista de ordenes
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retrieve ()
        {
            return new List<OrderItem>();
        }

        /// <summary>
        /// Gurada la OrdenItem actual
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Valida que los campos sean correctos// cantidad precio venta y idproduct
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            if (ProductId <= 0) isValid = false;
            return isValid;
        }

    }
}
