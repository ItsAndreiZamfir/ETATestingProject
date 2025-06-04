using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.OOPExtraWork
{
    public class GreekChef : Chef
    {
        public GreekChef (string nameChef) : base(nameChef)
        {

        }

        public override string cook()
        {
            return "I am cooking gyros!";
        }

        public override string introduction()
        {
            return string.Format("Hi I am greek chef {0}", this._nameChef);
        }
    }
}
