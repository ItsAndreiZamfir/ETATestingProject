using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.OOPExtraWork
{
    public class Dog : Animal, IWalk
    {
        protected string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }

        }

        public Dog(string name, int age, string breed) : base(name,age)
        {
            this.breed = breed;
        }

        public override string eat()
        {
            return string.Format("Hi my name is {0} and I am eating dog food", _name);
        }

        public string walk()
        {
            return string.Format("Hi my name is {0}, I am {1} years old and I am walking like a dog!", _name, _age);
        }
    }
}
