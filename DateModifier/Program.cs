﻿using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            DateModifier.DayDifferenceIn(firstDate, secondDate);
        }
    }
}
