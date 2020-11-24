using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                string[] names = Console.ReadLine().Split(' ').ToArray();
                people[i] = new Person(names[0], int.Parse(names[1]));
            }
            people = people.Where(x => x.Age > 30).ToArray();
            people = people.OrderBy(x => x.Name).ToArray();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
