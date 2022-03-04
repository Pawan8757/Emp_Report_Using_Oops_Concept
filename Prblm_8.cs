using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Report_Using_Oops
{
    public class UC_8_MultipleCompanyWage
    {
        public const int IsPartTime = 1;
        public const int IsFulltime = 2;

        private string company;
        private int EmpRatePerHour;
        private int NumOfWorkingDays;
        private int MaxHourPerMonth;
        private int TotalEmpWage;

        public UC_8_MultipleCompanyWage(string compancy, int EmpRatePerHour, int NumOfWorkingDays, int MaxHourPerMonth)
        {
            this.company = compancy;
            this.EmpRatePerHour = EmpRatePerHour;
            this.NumOfWorkingDays = NumOfWorkingDays;
            this.MaxHourPerMonth = MaxHourPerMonth;
        }

        public void ComputeEmpWage()
        {
            int EmpHrs = 0, TotalEmpHrs = 0, TotalWorkingDays = 0;
            while (TotalEmpHrs < this.MaxHourPerMonth && TotalWorkingDays < this.NumOfWorkingDays)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmpCheck = random.Next(3);
                switch (EmpCheck)
                {
                    case IsPartTime:
                        EmpHrs = 4;
                        break;
                    case IsFulltime:
                        EmpHrs = 8;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }
                TotalEmpHrs += EmpHrs;
                Console.WriteLine("Day# " + TotalWorkingDays + " Emphrs " + EmpHrs);
            }
            TotalEmpWage = TotalEmpHrs * this.EmpRatePerHour;
            Console.WriteLine("Total Wage for Comapany :- " + company + " is " + TotalEmpWage);
        }

    }
}