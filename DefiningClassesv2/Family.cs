using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private string key;
        private int value;
        public Dictionary<string, int> Members { get; set; }


        public void AddMember(Person member)
        {
            Members = new Dictionary<string, int>();
            Members.Add(member.Name, member.Age);
            if (member.Age >= value)
            {
                value = member.Age;
                key = member.Name;
            }
        }
        public Person GetOldestMember()
        {
            Console.WriteLine($"{key} {value}");
            return new Person(key, value);
        }
    }
}
