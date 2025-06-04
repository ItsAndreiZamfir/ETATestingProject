using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.Abstractisation
{
    public class Square : Shape
    {
        private double SideLength { get; set; }
        public override void CalculateArea()
        {
            SideLength = 4.0;
            double area = Math.Pow(SideLength, 2);
            Console.WriteLine($"Area of the square: {area}");
        }
    }
}
