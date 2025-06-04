using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.OOPExtraWork
{
    public class ItalianChef : Chef
    {
        protected int _age;

        public ItalianChef(string namechef,int age) : base(namechef)
        {
            this._age = age;
        }

        public int Age { get { return _age; } set { this._age = value; } }

        public override string cook()
        {
            return "I am cooking pasta!";
        }
    }
}
