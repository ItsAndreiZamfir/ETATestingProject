using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.Inheritance
{
    public class TestOOP
    {
        [Test]
        public void TestPerson()
        {
            Person person = new Person("Andrei Zamfir", 27, 81.5);
            person.DisplayInfo();
        }

        [Test]
        public void TestEmployee()
        {
            Employee employee = new Employee("Andrei Zamfir", 27, 81.5, "Software Engineer", 80000, "Tech Company");
            employee.DisplayInfo();
            employee.DisplayEmployeeInfo();
        }

        [Test]
        public void TestStudent()
        {
            Student student = new Student("Andrei Zamfir", 27, 81.5, "University of Pitesti", "Computer Science", true);
            student.DisplayInfo();
            student.DisplayStudentInfo();
        }

    }
}
