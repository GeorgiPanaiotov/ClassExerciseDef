using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            Person person = new Person();

            for (int i = 0; i < n; i++)
            {
                string[] names = Console.ReadLine().Split(" ").ToArray();
                person = new Person(names[0], int.Parse(names[1]));
                family.AddMember(person);

            }
            family.GetOldestMember();
            
        }
    }
}
