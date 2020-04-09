using System;
using System.Collections.Generic;
using System.Text;

namespace ACM_Acme_Customer_Management_.BLL
{
    class AddressRepository
    {
        /// <summary>
        /// Retorna una direccion
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public Address Retrieve (int addressId)
        {
            //create the intance of address classs
            //pass in the requested id
            Address address = new Address(1);

            //code that retrieve the defined address

            //temporary hard coded values to return
            //a pupulate address
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StrestLine1 = "Cra 68";
                address.StrestLine2 = "#87-97";
                address.City = "Medellin";
                address.State = "Robledo";
                address.Country = "Colombia";
                address.PostalCode = "057";
            }
            return address;
        }

        /// <summary>
        /// Retorna una lista de direcciones
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StrestLine1 = "Cra 49",
                StrestLine2 = "#69s-97",
                City = "Sabaneta",
                State = "Sabaneta",
                Country = "Colombia",
                PostalCode = "057",
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StrestLine1 = "Cra 68",
                StrestLine2 = "#87-97",
                City = "Medellin",
                State = "Robledo",
                Country = "Colombia",
                PostalCode = "057",
            };
            addressList.Add(address);

            return addressList;
        }
     
        /// <summary>
        /// Guarda una direccion
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool Save(Address address)
        {
            return true;
        }
    }
}
