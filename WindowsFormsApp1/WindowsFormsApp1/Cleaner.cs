using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cleaner :Employee
    {
        public Cleaner(int budget = 0, int salary = 0, int rooms = 0) :base(budget, salary)
        {
            amount_of_washed_rooms = rooms;
        }
        public int amount_of_washed_rooms { set; get; }
    }
}
