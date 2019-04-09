using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Director :Manager
    {
        public Director(int budget = 0, int salary = 0, int employees = 0, int goal_1 = 0, int realGain_1 = 0) :base(budget, salary, employees)
        {
            goal = goal_1;
            realGain = realGain_1;
        }

        public int goal { set; get; }
        public int realGain { set; get; }
    }
}
