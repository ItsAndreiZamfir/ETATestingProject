using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETATestingProject.Inheritance;

namespace ETATestingProject.Polimorphysm
{
    public class PolymorphismTest
    {
        [Test]
        public void TestStaticPolymorphism()
        {
            Console.WriteLine(Add(2, 3));
            Console.WriteLine(Add(2.5, 3.5));
            Console.WriteLine(Add("Hello, ", "World!"));
            Console.WriteLine(Add(1, 2, 3));
        }

        [Test]
        public void TestDynamicPolymorphism()
        {
            Employee employee = new Employee("Andrei Zamfir", 27, 81.5, "Software Engineer", 80000, "Tech Company");
            employee.Speak();
            Student student = new Student("Andrei Zamfir", 27, 81.5, "University of Pitesti", "Computer Science", true);
            student.Speak();
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public string Add(string a, string b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
