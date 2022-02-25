using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Report_Using_Oops
{
    public class EmplyAbsenty
    {
        public void CheckingAbsenty()
        {
            int number;
            Random random = new Random();   
            number = random.Next(2);

            if(number == 0)
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");
            }
        }
    }
}
