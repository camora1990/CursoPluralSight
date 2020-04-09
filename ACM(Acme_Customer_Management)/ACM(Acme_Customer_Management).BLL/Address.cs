using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_Acme_Customer_Management_.BLL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId) => (AddressId) = (addressId);

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string StrestLine1 { get; set; }
        public string StrestLine2 { get; set; }

        /// <summary>
        /// Valida datos de la direccion
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(City)) isValid = false;
            if(string.IsNullOrEmpty(Country)) isValid = false;
            if (string.IsNullOrEmpty(PostalCode)) isValid = false;

            return isValid;
        }

    }
}
