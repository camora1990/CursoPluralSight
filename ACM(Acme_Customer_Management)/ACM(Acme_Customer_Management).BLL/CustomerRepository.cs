﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_Acme_Customer_Management_.BLL
{
    public class CustomerRepository
    {
        /// <summary>
        /// Guarda el cliente Actual.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            return true;
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