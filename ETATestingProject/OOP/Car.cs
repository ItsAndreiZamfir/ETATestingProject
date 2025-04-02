using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ETAProject.OOP
{
    public class Car
    {
        string engine;
        string color;
        int numberOfDoors;
        double cilinder;
        string gearboxtype;

        public Car(string engine, string color, int numberOfDoors, double cilinder)
        {
            this.engine = engine;
            this.color = color;
            this.numberOfDoors = numberOfDoors;
            this.cilinder = cilinder;
        }

        public Car(string engine, string color, int numberOfDoors, double cilinder, string gearboxtype)
        {
            this.engine = engine;
            this.color = color;
            this.numberOfDoors = numberOfDoors;
            this.cilinder = cilinder;
            this.gearboxtype = gearboxtype;
        }



        public void DisplayCarProperties()
        {
            Console.WriteLine("Engine of the car is " + engine);
            Console.WriteLine("Color of the car is " + color);
            Console.WriteLine("Number of car doors is " + numberOfDoors);
            Console.WriteLine("Cilinder of the car is " + cilinder);
            if(gearboxtype != null)
            {
                Console.WriteLine("Gearbox of the car is " + gearboxtype);
            }
        }
    }
}
