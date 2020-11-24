using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string model, double fuel, double consumption)
        {
            Model = model;
            FuelAmount = fuel;
            FuelConsumptionPerKilometer = consumption;
            TravelledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }


        public static void Drive(Car[] cars, string model, double kilometers)
        {
            foreach (var car in cars)
            {
                if (car.Model == model)
                {
                    if (car.FuelAmount - (car.FuelConsumptionPerKilometer * kilometers) < 0)
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                    else
                    {
                        car.TravelledDistance += kilometers;
                        car.FuelAmount = car.FuelAmount - (car.FuelConsumptionPerKilometer * kilometers);
                    }
                }
            }

        }
    }
}
