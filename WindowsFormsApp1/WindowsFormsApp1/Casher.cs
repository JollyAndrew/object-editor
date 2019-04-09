using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Casher :Employee
    {
        public Casher(int budget = 0, int salary = 0, int gain_1 = 0) : base(budget, salary)
        {
            gain = gain_1;
        }

        public int gain { set; get; }
    }
}
