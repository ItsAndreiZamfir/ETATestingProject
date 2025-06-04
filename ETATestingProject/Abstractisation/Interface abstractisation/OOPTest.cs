using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.Abstractisation
{
    public class OOPTest
    {
        [Test]
        public void Test()
        {
            Employee employee = new Employee("John", "Doe", 30, "TechCorp", 60000);
            employee.GoToWork();
            employee.TakeBreak();

            EmployeeStudent employeeStudent = new EmployeeStudent("Jane", "Smith", 22, "TechCorp", 50000, "Tech University", "Computer Science");
            employeeStudent.GoToWork();
            employeeStudent.Study();

        }

        
    }
}
