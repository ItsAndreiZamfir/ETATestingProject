﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.Access
{
    public partial class PracticeFormData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string DateOfBirth { get; set; }
        public string Subjects { get; set; }
        public List<string> Hobbies { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }

    }
}
