using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Report_Using_Oops
{
    public class EmpBui
    {
        public const int IS_Part_Time = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private int CompanyEmpWage = 0;


        private CompanyEmpWage[] CompanyEmpWageArr;

        public EmpBui()
        {
            this.CompanyEmpWageArr = new CompanyEmpWage[5];
        }

        public void U10C(string company, int emprateperhr, int NumOfWorkingDays, int MaxHourPerMonth, int salary)
        {

            CompanyEmpWageArr[this.numOfCompany] = new CompanyEmpWage(company, emprateperhr, NumOfWorkingDays, MaxHourPerMonth, salary);

            numOfCompany++;
        }


        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                CompanyEmpWageArr[i].setTotalEmpWage(this.Computeempwage(this.CompanyEmpWageArr[i]));

                Console.WriteLine(this.CompanyEmpWageArr[i].ToString());

            }
        }

        private int Computeempwage(CompanyEmpWage companyEmpWage)
        {
            int emphrs = 0, totalhrs = 0, totalworkingdays = 0;


            while (totalhrs <= companyEmpWage.MaxHourPerMonth && totalworkingdays <= companyEmpWage.NumOfWorkingPerDays)

            {
                totalworkingdays++;

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

                totalhrs = totalhrs + emphrs;
                companyEmpWage.salary = companyEmpWage.emprateperhr * emphrs;

                Console.WriteLine(companyEmpWage.salary);

                Console.WriteLine("Days" + totalworkingdays + "Hrs" + emphrs);
            }

            return totalhrs * companyEmpWage.emprateperhr;

            int totalsalary = (totalsalary + companyEmpWage.salary);

            Console.WriteLine("total salary" + totalsalary);

        }


    }
}