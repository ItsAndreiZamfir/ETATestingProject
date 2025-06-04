﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETATestingProject.OOPExtraWork
{
    public abstract class Animal
    {
        protected string _name;
        protected int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Animal(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public DateTime TodayDate()
        {
            return DateTime.Now;
        }

        public abstract string eat();
    }
}
