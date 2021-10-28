using System;
using System.Collections.Generic;
using System.Text;

namespace Week2_Worksheet3
{
    class Supervisor: Employee
    {
        public Supervisor() : base() { }
        public List<Employee> EmployeesSupervised { get; set; }
    }
}
