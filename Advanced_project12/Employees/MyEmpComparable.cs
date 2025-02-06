using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class MyEmpComparable : Comparer<Employee>
    {
        public override int Compare(Employee? em1, Employee? em2)
        {
            return em1.Age.CompareTo(em2.Age);
        }
    }
}
