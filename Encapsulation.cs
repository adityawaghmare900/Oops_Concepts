using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept
{
    internal class Encapsulation
    {
        private String EmployeeName;
        private int Salary;
        public String Name
        {
            get { return EmployeeName; }
            set { EmployeeName = value; }
        }
        public int salary
        {
            get { return Salary; }
            set { Salary= value; }
        }

    }

}
