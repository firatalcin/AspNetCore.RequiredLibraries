using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
   

    public class LowSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 2;
        }
    }

    public class MiddleSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 4;
        }
    }

    public class HighSalaryCalculate 
    {
        public decimal Calculate(decimal salary)
        {
            return salary * 6;
        }
    }


    public class BestPractise2
    {
        public decimal Calculate(decimal salary, Func<decimal,decimal> calculateDelege)
        {
            return calculateDelege(salary);
        }
    }
}
