using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Report_Using_Oops
{
    public class Prblm_9
    {
        public const int IS_Part_Time = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        public int emprateperhr;
        public int NumOfWorkingPerDays;
        public int MaxHourPerMonth;
        public int TotalEmpWage;

        public Prblm_9(string company, int emprateperhr, int NumOfWorkingDays, int MaxHourPerMonth)
        {
            this.company = company;
            this.emprateperhr = emprateperhr;
            this.NumOfWorkingPerDays = NumOfWorkingPerDays;
            this.MaxHourPerMonth = MaxHourPerMonth;

        }
        public void ComputeWage()
        {
            int emphrs = 0, totalemphrs = 0, totalWorkingDays = 0;

            while (totalemphrs <= this.MaxHourPerMonth && totalWorkingDays <= this.NumOfWorkingPerDays)
            {
                totalWorkingDays++;

                Random random = new Random();
                int num = random.Next(0, 3);

                switch (num)
                {
                    case IS_Part_Time:
                        emphrs = 4;
                        break;

                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;

                    default:
                        emphrs = 0;
                        break;
                }
                totalemphrs = totalemphrs + emphrs;
                Console.WriteLine("workday" + totalWorkingDays + "Totalhrs" + totalemphrs);
            }
            TotalEmpWage = totalemphrs * this.emprateperhr;
            Console.WriteLine("TotalEmployeewage" + this.company + "is" + TotalEmpWage);
        }
    }
}