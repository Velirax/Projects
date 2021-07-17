using System;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] carTokens = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double initialFuel = double.Parse(carTokens[1]);
            double litersPerKM = double.Parse(carTokens[2]);
            double tankCapacity = double.Parse(carTokens[3]);

            Vehicle car = new Car(initialFuel, litersPerKM, tankCapacity);

            string[] truckTokens = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Vehicle truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]), double.Parse(truckTokens[3]));

            string[] busTokens = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Bus bus = new Bus(double.Parse(busTokens[1]), double.Parse(busTokens[2]), double.Parse(busTokens[3]));

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                string[] commands = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                if (commands[0] == "Drive")
                {
                    double distance = double.Parse(commands[2]);
                    if (commands[1] is "Car")
                    {
                        car.Drive(distance);
                    }
                    else if (commands[1] is "Truck")
                    {
                        truck.Drive(distance);
                    }
                    else if (commands[1] is "Bus")
                    {
                        bus.IsEmpty = false;
                        bus.Drive(distance);
                    }
                }

                else if (commands[0] == "Refuel")
                {
                    try
                    {
                        double liters = double.Parse(commands[2]);
                        if (commands[1] is "Car")
                        {
                            car.Refuel(liters);
                        }
                        else if (commands[1] is "Truck")
                        {
                            truck.Refuel(liters);
                        }
                        else if (commands[1] is "Bus")
                        {
                            bus.Refuel(liters);
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
                else if (commands[0] == "DriveEmpty")
                {
                    if (commands[1] == "Bus")
                    {
                        double distance = double.Parse(commands[2]);
                        bus.IsEmpty = true;
                        bus.Drive(distance);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
