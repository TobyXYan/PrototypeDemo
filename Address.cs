using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDemo
{
    public class Address
    {
        public int DoorNumber { get; set; }
        public int StreetNumber { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }

        public Address()
        {

        }
        public Address(int doorNumber, int streetNumber, int zipCode, string country)
        {
            DoorNumber = doorNumber;
            StreetNumber = streetNumber;
            ZipCode = zipCode;
            Country = country;
        }
    }
}
