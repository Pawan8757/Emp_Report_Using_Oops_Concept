using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Report_Using_Oops
{
    public class ConditionalWages
    {
        public static void CalculatingWages()
        {
            int IsPartTime = 1;
            int IsFullTime = 2;
            int WageRatePerHour = 20;
            int NumberofWorkingDay = 20;
            int TotalSalary = 0;
            int EmpWage = 0;
            int EmpHour = 0;
            int MaxHourInMonth = 100;
            int TotalEmpHour = 0;
            int WorkingDay = 0;

            while (EmpHour < MaxHourInMonth && WorkingDay < NumberofWorkingDay) ;
            {
                NumberofWorkingDay++;
                    {
                 Random random = new Random();
                    int number = random.Next(3);

                    if (number == IsPartTime)
                    {
                        EmpHour = 4;
                    }
                    else if (number == IsFullTime)
                    {
                        EmpHour = 8;
                    }
                    else
                    {
                        EmpHour = 0;
                    }

                      TotalEmpHour = EmpHour + EmpHour;

                     int EmpEarning = EmpHour * WageRatePerHour;
                    TotalSalary = EmpEarning + EmpWage;

                    Console.WriteLine("Total employee working hour =" + TotalEmpHour);
                    Console.WriteLine("Total Salary is " + TotalSalary);
                }

            }


        }
        }
    }

