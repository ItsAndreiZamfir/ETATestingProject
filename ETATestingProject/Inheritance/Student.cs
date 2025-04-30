using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.Inheritance
{
    public class Student : Person
    {
        public string university;
        public string profile;
        public bool haveScholarship;

        public Student(string name, int age, double weight, string university, string profile, bool haveScholarship) : base(name, age, weight)
        {
            this.university = university;
            this.profile = profile;
            this.haveScholarship = haveScholarship;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"University: {university}, Profile: {profile}, Have Scholarship: {haveScholarship}");
        }
    }
}
