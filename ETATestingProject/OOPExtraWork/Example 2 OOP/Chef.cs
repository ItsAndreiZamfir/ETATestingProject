using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.OOPExtraWork
{
    public class Chef
    {
        protected string _nameChef;

        public string NameChef { get { return _nameChef; } set { _nameChef = value; } }

        public Chef(string _nameChef)
        {
            this._nameChef = _nameChef;
        }

        public virtual string introduction()
        {
            return string.Format("Hi I am chef {0}", this._nameChef);
        }

        public virtual string cook()
        {
            return "Start cooking!";
        }
    }
}
