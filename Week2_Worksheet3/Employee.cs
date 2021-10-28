using System;
using System.Collections.Generic;
using System.Text;

namespace Week2_Worksheet3
{
    class Employee
    {
        public Employee() { }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public DateTime RecruitementDate { get; set; }

        public double Salary { get; set; }
    }
}
