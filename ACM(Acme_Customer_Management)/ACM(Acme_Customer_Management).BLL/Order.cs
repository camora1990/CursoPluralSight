using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_Acme_Customer_Management_.BLL
{
    public class Order : EntityBase
    {
        public Order() : this(0){}
        public Order(int orderId) => (OrderId, OrderItems) = (orderId, new List<OrderItem>());

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; } //captura la hora de acuerdo a la zona horaria
        public int CustomerId { get; set; } //relacion con Cliente
        public int ShippingAddressId { get; set; } //Relacion Con direccion de envio
        public List<OrderItem> OrderItems { get; set; } // relacion con los item de la orden

        /// <summary>
        /// Valida que la orden sea valida
        /// </summary>
        /// <returns></returns>
      
        public override string ToString() => $"{OrderId} ({OrderDate.Value.Date})";

        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
