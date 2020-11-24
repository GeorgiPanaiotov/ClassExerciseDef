using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Person
    {
        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }
        public Person(string name, int age):this()
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
