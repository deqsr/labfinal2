using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorka2
{
    internal class Address
    {

        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public void DisplayName()
        {
            Console.WriteLine($"Index: {Index} Country : {Country} City : {City} Street : {Street} House : {House} Apartment : {Apartment}");

        }

    }
}
