using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_Acme_Customer_Management_.BLL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retorna La orden por Id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);
            if(orderId == 12)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year,DateTime.Now.Month,14,10,00,00, new TimeSpan(7,0,0));
            }
            return order;
        }

        /// <summary>
        /// Guarda la Orden actual
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            var success = true;
            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {
                        //llamar a un procedimiento almacenado de inserción
                    }
                    else
                    {
                        //llamar a un procedimiento de actualizacion
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
