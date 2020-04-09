using System;
using System.Collections.Generic;

namespace ACM_Acme_Customer_Management_.BLL
{
    //Clase cliente
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customeId) => (CustomerId) = (customeId);
     
        public int CustomerId { get; private set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public static int InstanceCount { get; set; }

        public string FullName
        {
            get
            {
                string fullname = LastName;
                if (string.IsNullOrEmpty(FirtsName) != true)
                {
                    if (string.IsNullOrEmpty(LastName) != true)
                    {
                        fullname += ", ";
                    }
                    fullname += FirtsName;
                }
                return fullname;
            }
        }

        /// <summary>
        /// Valida si correo y Apellido no estan vacios.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;
            if (string.IsNullOrEmpty(LastName)) isValid = false;

            return isValid;
        } 
    }
}
