using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carLot = new List<Car>();
            Car ford = new Car("Ford", "Bronco", 80_000);
            //ford.Make = "Ford";
            //ford.Model = "Bronco";
            ford.Year = 1986;
            ford.Color = "Pearl";
            // ford.Mileage = 80_000;
            ford.IsInspected = true;
            ford.CountryOfOrigin = "USA";

            Car toyota = new Car("Toyota", "4Runner", 300)
            {
                // Make = "Toyota",
                //Model = "4Runner",
                Year = 2019,
                Color = "White",
                //Mileage = 300,
                IsInspected = false,
                CountryOfOrigin = "Japan"
            };

            Car chevy = new Car("Chevy", "Malibu", 200_000)
            {
                // Make = "Chevy",
                // Model = "Malibu",
                Year = 1995,
                Color = "red",
                // Mileage = 200_000,
                IsInspected = false,
                CountryOfOrigin = "USA"
            };
            carLot.Add(ford);
            carLot.Add(toyota);
            carLot.Add(chevy);

            Console.WriteLine($"The ford has {ford.Mileage} miles");
            ford.Drive(10);
            Console.WriteLine($"The ford has now driven {ford.Mileage}");
            Console.WriteLine(ford.Description);
            Console.WriteLine(chevy.Description);
            Console.WriteLine(toyota.Description);
            toyota.Drive(3000);
            Console.WriteLine(toyota.Description);

        }

    }
}