using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Manager :Employee
    {
        public Manager(int budget = 0, int salary = 0, int employees_1 = 0): base(budget, salary)
        {
            employees = employees_1;
        }

        public int employees { set; get; }
    }
}
