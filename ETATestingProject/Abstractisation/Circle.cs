using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.Abstractisation
{
    public class Circle : Shape
    {
        private double Radius { get; set; }
 
        public override void CalculateArea()
        {
            Radius = 5.0;
            double area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine(area);
        }
    }
}
