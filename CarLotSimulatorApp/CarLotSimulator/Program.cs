using System;

namespace CarLotSimulator
{
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
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            // Standard member initialization
            CarLot lot = new CarLot();
            


            Car ferrari = new Car();
            lot.CarList.Add(ferrari);

            ferrari.Year = 1999;
            ferrari.Make = "Ferrari";
            ferrari.Model = "Spider";
            ferrari.EngineNoise = "EEEEE";
            ferrari.HonkNoise = "Move get out the way!";
            ferrari.IsDrivable = true;

            ferrari.MakeEngineNoise();
            ferrari.MakeHonkNoise();

            // Object intializer syntax
            Car mcClarren = new Car() { Year = 2022, Make = "McClarren", Model = "F1", EngineNoise = "Waaaammm", HonkNoise = "And I Ooop!", IsDrivable = true};
            lot.CarList.Add(mcClarren);

            mcClarren.MakeEngineNoise();
            mcClarren.MakeHonkNoise();


            //Constructor initialization
            Car someOtherCar = new Car(1985, "Metal Gear", "Zeke", "Thud", "You don't want to know... <.<");
            lot.CarList.Add(someOtherCar);

            someOtherCar.MakeEngineNoise();
            someOtherCar.MakeHonkNoise();

            Console.WriteLine("-----------");

            //*************BONUS X 2*************//

            foreach(var car in lot.CarList)
            {
                Console.WriteLine($"{car.Make}, {car.Year}, {car.Model}");
            }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            
        }

    }
}
