using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.OOPHomework
{
    public class Employee : Person
    {
        private decimal _salary;

        public int EmployeeId { get; set; }
        public string Department { get; set; }

        public decimal GetSalary()
        {
            return _salary;
        }
        public void SetSalary(decimal salary)
        {
            if (salary < 0)
            {
                throw new ArgumentException("Salary cannot be negative.");
            }
            _salary = salary;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Salary: {_salary}");
        }
    }
}
