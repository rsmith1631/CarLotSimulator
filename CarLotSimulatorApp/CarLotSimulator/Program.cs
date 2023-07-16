using System;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Done
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            var lot = new CarLot();
            
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var corolla = new Car();
            corolla.Make = "Toyota";
            corolla.Model = "Corolla";
            corolla.Year = 2023;
            corolla.IsDriveable = true;
            corolla.EngineNoise = "Silent";
            corolla.HonkNoise = "Loud";
            Console.WriteLine($"{corolla.Make}      {corolla.Model}     {corolla.Year}      {corolla.IsDriveable}       {corolla.HonkNoise}       {corolla.EngineNoise}");
            corolla.MakeEngineNoise("Can barely hear it!");
            corolla.MakeHornNoice("Horn works great! It's very loud, just the way you need it!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            lot.Cars.Add( corolla );

            var equinox = new Car()
            {
                Year = 2019,
                Make = "Chevrolet",
                Model = "Equinox",
                IsDriveable = true,
                HonkNoise = "Loud and clear",
                EngineNoise = "Loud"
            };
            equinox.MakeEngineNoise("It can be very loud at times.");
            equinox.MakeHornNoice("Works great and can be loud and clear.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            lot.Cars.Add(equinox);

            var maxima = new Car(2019, "Nissan", "Maxima", "Mild", "kind of Loud", true);
            equinox.MakeEngineNoise("You can hear the engine, but it's not too loud.");
            equinox.MakeHornNoice("The horn is pretty good. It's not as loud as most will like, but sounds good.");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            lot.Cars.Add(maxima);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} || Make: {car.Make} || Model: {car.Model}");
            }
        }
    }
}
