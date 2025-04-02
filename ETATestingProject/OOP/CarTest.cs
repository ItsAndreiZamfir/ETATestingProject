using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAProject.OOP
{
    public class CarTest
    {
        [Test]
        public void TestCar()
        {
            Car myCar = new Car("benzina", "red", 4, 2.5);
            myCar.DisplayCarProperties();

            Console.WriteLine();

            var secondCar = new Car("diesel", "black", 2, 2.0);
            secondCar.DisplayCarProperties();

            Console.WriteLine();

            var thridCar = new Car("diesel", "black", 2, 2.0, "automata");
            thridCar.DisplayCarProperties();
        }
        
    }
}
