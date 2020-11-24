using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
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
                Engine engine = new Engine();
                engine.Speed = int.Parse(info[1]);
                engine.Power = int.Parse(info[2]);
                Cargo cargo = new Cargo();
                cargo.Weight = int.Parse(info[3]);
                cargo.Type = info[4];
                Tires[] tires = new Tires[4];
                List<string> tireInfo = new List<string> { info[5], info[6], info[7], info[8], info[9], info[10], info[11], info[12] };
                for (int j = 0; j < tires.Length; j++)
                {
                    tires[j] = new Tires();
                    tires[j].Pressure = double.Parse(tireInfo[j]);
                    tires[j].Age = int.Parse(tireInfo[j + 1]);
                    tireInfo.RemoveAt(0);
                }

                cars[i] = new Car(info[0], engine, cargo, tires);
            }

            Car[] newCar = new Car[n];
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                newCar = cars.Where(x => x.Cargo.Type == "fragile").ToArray();
                for (int i = 0; i < newCar.Length; i++)
                {
                    for (int j = 0; j < newCar[i].Tires.Length; j++)
                    {
                        if (newCar[i].Tires[j].Pressure < 1)
                        {
                            Console.WriteLine(newCar[i].Model);
                            break;
                        }
                    }
                }

            }
            else if (command == "flamable")
            {
                newCar = cars.Where(x => x.Cargo.Type == "flamable").ToArray();

                for (int i = 0; i < newCar.Length; i++)
                {
                    if (newCar[i].Engine.Power > 250)
                    {
                        Console.WriteLine(newCar[i].Model);
                        continue;
                    }
                }
            }


        }
    }
}
