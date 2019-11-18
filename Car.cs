using System;

namespace ClassIntro
{
    class Car
    {
        //field
        private string _vinNumber;
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public int Mileage { get; private set; }
        public string Color { get; set; }
        public string CountryOfOrigin { get; set; }
        public bool IsInspected { get; set; }
        //computed properties
        public string Description
        {
            get
            {
                return $"{Year} {Make} {Model} with {Mileage} miles";
            }
        }
        //Constructor
        public Car(string make, string model, int mileage)
        {
            Make = make;
            Model = model;
            Mileage = mileage;

            Random rand = new Random();
            _vinNumber = rand.Next(10_000, 1_000_000).ToString();

        }

        public void Drive(int milesDriven)
        {
            Mileage += milesDriven;
        }

    }
}