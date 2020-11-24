using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    class DateModifier
    {
        public DateModifier()
        {

        }

        public static void DayDifferenceIn(string firstDate, string secondDate)
        {
            int count = 0;
            int[] datesOne = firstDate.Split(" ").Select(int.Parse).ToArray();
            int[] datesTwo = secondDate.Split(" ").Select(int.Parse).ToArray();
            DateTime date = new DateTime(datesOne[0], datesOne[1], datesOne[2]);
            DateTime dateTwo = new DateTime(datesTwo[0], datesTwo[1], datesTwo[2]);

            TimeSpan diff = new TimeSpan();
            Console.WriteLine(Math.Abs(date.Subtract(dateTwo).TotalDays).ToString());
        }
    }
}
