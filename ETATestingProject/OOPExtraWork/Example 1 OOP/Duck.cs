using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.OOPExtraWork
{
    public class Duck : Animal, IFly, IWalk
    {
        public Duck(string name,int age):base(name,age)
        {

        }

        public override string eat()
        {
            return string.Format("Hi my name is {0}, I am {1} years old and I am eating duck food", _name, _age);
        }

        public string fly()
        {
            return string.Format("I am flying like a duck");
        }

        public string walk()
        {
            return string.Format("I am walking like a duck");
        }
    }
}
