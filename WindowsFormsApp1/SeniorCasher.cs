using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SeniorCasher :Casher
    {
        public SeniorCasher(int budget = 0, int salary = 0, int gain = 0, int Juns = 0) :base(budget, salary, gain)
        {
            amountOfJuniors = Juns;
        }

        public int amountOfJuniors { set; get; }
    }
}
