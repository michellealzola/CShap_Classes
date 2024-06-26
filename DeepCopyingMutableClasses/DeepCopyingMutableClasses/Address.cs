using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepCopyingMutableClasses
{
    internal class Address
    {
        public string HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }

        public Address(string _houseNumber, string _streetName, string _city)
        {
            HouseNumber = _houseNumber;
            StreetName = _streetName;
            City = _city;
        }

        public Address(Address other)
        {
            HouseNumber = other.HouseNumber;
            StreetName = other.StreetName;
            City = other.City;
        }
    }
}
