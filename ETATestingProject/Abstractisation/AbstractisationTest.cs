using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.Abstractisation
{
    public class AbstractisationTest
    {
        [Test]
        public void ShapeTest()
        {
            Circle circle = new Circle();
            circle.CalculateArea();
            circle.Draw();
            Square square = new Square();
            square.CalculateArea();
            square.Draw();
        }
    }
}
