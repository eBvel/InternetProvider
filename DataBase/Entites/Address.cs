using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites
{
    [ComplexType]
    public class Address
    {
        [MaxLength(20)]
        public string City { get; private set; }
        [MaxLength(25)]
        public string Street { get; private set; }
        [MaxLength(6)]
        public string House { get; private set; }
        public int Flat { get; private set; }

        public Address() { }

        public Address(string city, string street, string  house, int flat)
        {
            City = city;
            Street = street;
            House = house;
            Flat = flat;
        }
    }
}
