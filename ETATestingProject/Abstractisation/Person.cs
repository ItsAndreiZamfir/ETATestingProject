using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.Abstractisation
{
    public class Person
    {
        private string Nume { get; set; }
        private string Prenume { get; set; }
        private int Varsta { get; set; }

        public Person(string nume, string prenume, int varsta)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Nume: {Nume}");
            Console.WriteLine($"Prenume: {Prenume}");
            Console.WriteLine($"Varsta: {Varsta}");
        }

    }
}
