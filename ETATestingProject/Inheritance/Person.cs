using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.Inheritance
{
    public class Person
    {
        public string name;
        public int age;
        public double weight;

        public Person(string name, int age, double weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Weight: {weight}");
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{name} is speaking.");
        }
    }
}
