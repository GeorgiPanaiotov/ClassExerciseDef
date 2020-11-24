using System;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Car[] cars = new Car[n];

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();
                cars[i] = new Car(info[0], double.Parse(info[1]), double.Parse(info[2]));

            }

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while(command[0] != "End")
            {
                Car.Drive(cars, command[1], double.Parse(command[2]));
                command = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
        
    }
}
