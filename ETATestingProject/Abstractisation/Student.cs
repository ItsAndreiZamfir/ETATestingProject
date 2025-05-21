using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ETATestingProject.Abstractisation
{
    public class Student : Person, IStudent
    {
        
        private string University { get; set; }

        private string Profile { get; set; }

        private bool HaveScholarship { get; set; }

        public Student(string nume, string prenume, int varsta, string university, string profile, bool haveScholarship) : base(nume, prenume, varsta)
        {
            University = university;
            Profile = profile;
            HaveScholarship = haveScholarship;
        }

        public void DisplayStudentInfo()
        {
            DisplayInfo();
            Console.WriteLine($"University: {University}");
            Console.WriteLine($"Profile: {Profile}");
            Console.WriteLine($"Have Scholarship: {HaveScholarship}");
        }
        public void Study()
        {
            Console.WriteLine($"Student is studying.");
        }
        public void AttendClass()
        {
            Console.WriteLine($"Student is attending class.");
        }
        public void TakeExam()
        {
            Console.WriteLine($"Student is taking an exam.");
        }


    }
}
