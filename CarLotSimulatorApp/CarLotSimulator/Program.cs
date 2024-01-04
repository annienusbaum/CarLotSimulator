using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace CarLotSimulator
{
        class Program
        {
            static void Main(string[] args)
            {
                var carLot = new CarLot();

                var mazda = new Car();
                mazda.Make = "Lamborghini";
                mazda.Model = "CX-5";
                mazda.Year = 2023;
                mazda.EngineNoise = "Zoom zoom zoom";
                mazda.HonkNoise = "beeeep";
                mazda.IsDrivable = true;

                var ford = new Car()
                {
                    Make = "Ford",
                    Model = "Focus",
                    Year = 2013,
                    EngineNoise = "shake shake shake die",
                    HonkNoise = " Beep beep",
                    IsDrivable = true
                };
                Car impala = new Car(2001, "Impala", "Vrooom", "Loud beep", true, "Chevy");


                carLot.ParkingLot = new List<Car>() { mazda, ford, impala };

            foreach (var car in carLot.ParkingLot)
                {
                    Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                    car.MakeEngineNoise();
                    car.MakeHonkNoise();
                    Console.WriteLine("---------------------------");
                }


            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (var car in carLot.ParkingLot)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
            }
        }
    }
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

//*************BONUS X 2*************//

//Create a CarLot class
//It should have at least one property: a List of cars
//Instanciate the a Carlot at the beginning of the program
//and as you create a car add the car to the list.
//At the end iterate through the list printing each of car's Year, Make, and Model to the console

/*
 * Inside the CarLot class from the previous exercise, create a static field called numberOfCars.
Have this number only increment when in our program we create a new Car.
From there, use the 3 cars in the Main() (from the previous exercise)
and then each time you create a car do a Console.WriteLine()
printing the current number of cars in the car lot. 
 */