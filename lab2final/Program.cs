using laboratorka2;
using System;
using System.Globalization;

namespace laboratorka2
{

    class Program

    {

        static void Main(string[] args)
        {
            Address adressa = new();
            adressa.Index = 01101;
            adressa.Country = "Ukraine";
            adressa.House = "140";
            adressa.Apartment = "22";

            Console.WriteLine("Address:");
            Console.WriteLine($"Index:{adressa.Index}");
            Console.WriteLine($"Country:{adressa.Country}");
            Console.WriteLine($"House:{adressa.House}");
            Console.WriteLine($"Apartment:{adressa.Apartment}");

            Console.WriteLine("enter the number of the currency that you want to convert to UAH or UAH to EUR : USD=1,EUR=2,RUB=3,UAH=4");

            var currencyFrom = (Converter.Currency)int.Parse(Console.ReadLine());
            Console.WriteLine("the amount:");
            var amountToConvert = double.Parse(Console.ReadLine());
            var convertedAmount = $"{Converter.Convert(amountToConvert, currencyFrom)}";
            Console.WriteLine($"amount transferred:{convertedAmount}");

            Console.WriteLine("Select the employee's first and last name");
            Employee worker = new Employee();
            Console.WriteLine("Name:");
            worker.Name = Console.ReadLine();
            Console.WriteLine("Surname:");
            worker.Surname = Console.ReadLine();
            Employee.Salarry();


            Console.WriteLine("questionnaire:");
            User user1 = new();
            Console.WriteLine("enter your username:");
            user1.Login = Console.ReadLine();
            Console.WriteLine("enter your name:");
            user1.Name = Console.ReadLine();
            Console.WriteLine("enter your surname:");
            user1.Surname = Console.ReadLine();
            Console.WriteLine($"Username:{user1.Login}\n Name:{user1.Name} \n Surname:{user1.Surname}\n {user1.date} ");




        }

    }
}