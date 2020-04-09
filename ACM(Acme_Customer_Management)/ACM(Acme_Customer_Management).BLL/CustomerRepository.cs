using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM_Acme_Customer_Management_.BLL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }

        /// <summary>
        /// Guarda el cliente Actual.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            var success = true;
            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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

        /// <summary>
        /// Deuelve el cliente por Id.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "camilo@correo.com";
                customer.FirtsName = "CAMILO";
                customer.LastName = "MORALES";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        /// <summary>
        /// Devuelve todos los clientes.
        /// </summary>
        /// <returns></returns>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

    }
}
