using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.Abstractisation
{
    public abstract class Shape
    {
        private string Color { get; set; }
        private double Area { get; set; }
        private double Perimeter { get; set; }

        public abstract void CalculateArea();
        
        public void Draw()
        {
            Console.WriteLine($"Drawing a shape");
        }

    }
}
