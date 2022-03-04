using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Report_Using_Oops
{
    public class Prblm_10
    {
        private string company;
        public int emprateperhr;
        public int NumOfWorkingPerDays;
        public int MaxHourPerMonth;
        public int TotalEmpWage;


        public Prblm_10(string company, int emprateperhr, int NumOfWorkingDays, int MaxHourPerMonth)
        {
            this.company = company;
            this.emprateperhr = emprateperhr;
            this.NumOfWorkingPerDays = NumOfWorkingPerDays;
            this.MaxHourPerMonth = MaxHourPerMonth;

        }


        public void setTotalEmpWage(int TotalEmpwage)
        {
            this.TotalEmpWage = TotalEmpWage;
        }




    }
}
