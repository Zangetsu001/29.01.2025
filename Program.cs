using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            public string GetInfo()
            {
                return $"Имя: {FirstName}\nФамилия: {LastName}\nВозраст: {Age}";
            }

            public void Output()
            {
                Console.WriteLine(GetInfo());
            }
        }
            static void Main(string[] args)
            {
                Person person = new Person("Эдуард", "Афтентьев", 17);
                person.Output();
                Console.ReadKey();
            }
        
    }
}
