using System;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Engine[] engine = new Engine[n];
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                engine[i] = new Engine();
                engine[i].Model = info[0];
                engine[i].Power = int.Parse(info[1]);
                if (info.Length >= 3)
                {
                    int value;
                    if (int.TryParse(info[2], out value))
                    {
                        engine[i].Displacement = int.Parse(info[2]);
                    }
                    else
                    {
                        engine[i].Efficiency = info[2];
                    }
                }
                if (info.Length >= 4)
                {
                    engine[i].Efficiency = info[3];
                }
            }

            int m = int.Parse(Console.ReadLine());

            Car[] car = new Car[m];
            for (int i = 0; i < m; i++)
            {
                string[] info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                car[i] = new Car();
                car[i].Model = info[0];
                for (int j = 0; j < engine.Length; j++)
                {
                    if (info[1] == engine[j].Model)
                    {
                        car[i].Engine = engine[j];
                    }
                }
                if (info.Length >= 3)
                {
                    int value;
                    if (int.TryParse(info[2], out value))
                    {
                        car[i].Weight = int.Parse(info[2]);
                    }
                    else
                    {
                        car[i].Color = info[2];
                    }
                }
                if (info.Length >= 4)
                {
                    car[i].Color = info[3];
                }
            }

            foreach (var vehicle in car)
            {
                Console.WriteLine($"{vehicle.Model}:");
                Console.WriteLine($"  {vehicle.Engine.Model}:");
                Console.WriteLine($"    Power: {vehicle.Engine.Power}");
                if (vehicle.Engine.Displacement == 0)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {vehicle.Engine.Displacement}");
                }
                if (vehicle.Engine.Efficiency == null)
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }
                else
                {
                    Console.WriteLine($"    Efficiency: {vehicle.Engine.Efficiency}");
                }
                if (vehicle.Weight == 0)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {vehicle.Weight}");
                }
                if (vehicle.Color == null)
                {
                    Console.WriteLine($"  Color: n/a");
                }
                else
                {
                    Console.WriteLine($"  Color: {vehicle.Color}");
                }
            }
        }
    }
}
