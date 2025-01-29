using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {

        class Address
        {
            public string Index { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string Street { get; set; }
            public string House { get; set; }
            public string Apartment { get; set; }

            public void Display()
            {
                Console.WriteLine($"Index: {Index}");
                Console.WriteLine($"Country: {Country}");
                Console.WriteLine($"City: {City}");
                Console.WriteLine($"Street: {Street}");
                Console.WriteLine($"House: {House}");
                Console.WriteLine($"Apartment: {Apartment}");
            }
        }

   
        static void Main()
        {
            Address myAddress = new Address
            {
                Index = "123456",
                Country = "Russia",
                City = "Moscow",
                Street = "Tverskaya",
                House = "10",
                Apartment = "25"
            };

                myAddress.Display();
                Console.ReadKey();

        }
        
    }
}
