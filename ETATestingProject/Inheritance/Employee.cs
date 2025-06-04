using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.Inheritance
{
    public class Employee : Person
    {
        public string jobTitle;

        public double salary;

        public string company;

        public Employee(string name, int age, double weight, string jobTitle, double salary, string company) : base(name, age, weight)
        {
            this.jobTitle = jobTitle;
            this.salary = salary;
            this.company = company;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Job Title: {jobTitle}, Salary: {salary}, Company: {company}");
        }

        public override void Speak()
        {
           Console.WriteLine($"{name} is speaking about their job as a {jobTitle} at {company}.");
        }
    }
}
