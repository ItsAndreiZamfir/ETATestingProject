using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.OOPHomework
{
    public class TestHomework
    {
        [Test]
        public void TestOOPConcepts()
        {
            List<Person> people = new List<Person>();
            Employee employee = new Employee();
            employee.Name = "John Doe";
            employee.EmployeeId = 123;
            employee.Department = "IT";
            employee.SetSalary(50000);
            people.Add(employee);

            Manager manager = new Manager();
            manager.Name = "Jane Smith";
            manager.SetTeamSize(5);
            manager.SetBonus(1000);
            people.Add(manager);

            foreach (var person in people)
            {
                person.DisplayInfo();
                Console.WriteLine();
            }

        }
    }
}
