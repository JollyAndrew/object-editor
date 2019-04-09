using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Customer
    {
        public Customer(int money = 0)
        {
            if (money >= 0)
                budget = money;
            else
                budget = 0;
        }

        //public int getBudget() { return budget; }
        //public int setBudget(int money)
        //{
        //    if (money < 0)
        //        return budget = 0;
        //    else
        //        return budget = money;
        //}
        public int budget { set; get; }
    }
}
