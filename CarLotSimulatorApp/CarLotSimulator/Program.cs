using System;

namespace CarLotSimulator
{ using CarLotSimulator;
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            Car car1 = new Car();
            car1.Year = 2015;
            car1.Make = "Lexus";
            car1.Model = "RX";
            car1.EngineNoise = "Normal";
            car1.HonkNoise = "Loud";
            car1.IsDriveable = true;

            Car car2 = new Car(2008, "Toyota", "Rav4", "Normal", "Low", false);

            var car3 = new Car() { Year = 1999, Make = "Honda", Model = "CR-V", EngineNoise = "Loud", HonkNoise = "Low", IsDriveable = false };
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Methods.MakeEngineNoise(car1.EngineNoise);
            Methods.MakeHonkNoise(car1.HonkNoise);
            Console.WriteLine("-----------------------");

            Methods.MakeEngineNoise(car2.EngineNoise);
            Methods.MakeHonkNoise(car2.HonkNoise);
            Console.WriteLine("-----------------------");

            Methods.MakeEngineNoise(car3.EngineNoise);
            Methods.MakeHonkNoise(car3.HonkNoise);
            Console.WriteLine("-----------------------");
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            var allCars = new CarLot();
            allCars.Cars.Add(car1);
            allCars.Cars.Add(car2);
            allCars.Cars.Add(car3);

            foreach (var car in allCars.Cars)
            {
                Console.WriteLine($"A {car.Year} {car.Make} {car.Model} engine noise is {car.EngineNoise} and the honk noise is {car.HonkNoise}. \nIs Driveable? {car.IsDriveable}\n");
            }
            Console.WriteLine("---------------------");
            CarLot.NumberOfCars = allCars.Cars.Count;
            Console.WriteLine($"The total amount of cars is {CarLot.NumberOfCars}");
        }
    }
}
