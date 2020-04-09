using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_Acme_Customer_Management_.BLL
{
    public class Order
    {
        public Order(){}
        public Order(int orderId) => (OrderId) = (orderId);

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; } //captura la hora de acuerdo a la zona horaria

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
