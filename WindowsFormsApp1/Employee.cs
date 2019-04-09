using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee
    {
        public Employee(int budget=0, int salary_1 = 0) { 
            if (salary_1 >= 0)
                salary = salary_1;
            else
                salary = 0;
            cust = new Customer(budget);
        }
        public int salary { set; get; }
        public Customer cust;
    }
}
