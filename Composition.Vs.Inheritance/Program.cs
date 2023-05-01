// See https://aka.ms/new-console-template for more information


using Composition.Vs.Inheritance;

Car myCar = new Car("Toyota", "Corolla", 2022);
SportsCar mySportsCar = new SportsCar("Ferrari", "488 GTB", 2021, "Red");

//myCar.Start(); // Outputs "Starting the car..." 
//myCar.Stop(); // Outputs "Stopping the car..."

//mySportsCar.Start(); // Outputs "Starting the sports car..." 
//mySportsCar.Stop(); // Outputs "Stopping the sports car..."
//mySportsCar.OpenConvertibleRoof(); // Outputs "Opening convertible roof..." 
//mySportsCar.CloseConvertibleRoof(); // Outputs "Closing convertible roof..."

CarDealer myDealer = new CarDealer(myCar);
CarDealer mySportsCarDealer = new CarDealer(mySportsCar);

myDealer.Sell(); // Outputs "Starting the car..." and "Stopping the car..."
mySportsCarDealer.Sell(); // Outputs "Starting the sports car..." and "Stopping the sports car..."

Console.ReadKey();