using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.employeewage_problem
{
    internal class Company
    {

        public string CompanyName;
        private float EmpRatePerHour;
        private int NoOfWorkingDays;
        private int MaxHoursPerMonth;
        private float TotalEmpWage;
        private bool IsFullTime;

        public Company(string companyName, float empRatePerHour, int noOfWorkingDays, int maxHoursPerMonth, bool isFullTime)
        {
            this.CompanyName = companyName;
            this.EmpRatePerHour = empRatePerHour;
            this.NoOfWorkingDays = noOfWorkingDays;
            this.MaxHoursPerMonth = maxHoursPerMonth;
            this.IsFullTime = isFullTime;
        }

        public float CalcWage()
        {
            int TotalEmpHours = 0;
            int TotalworkingDays = 0;

            if (IsFullTime)
            {
                while( TotalworkingDays < NoOfWorkingDays && TotalEmpHours < MaxHoursPerMonth)
                {
                    TotalworkingDays++;
                    TotalEmpHours += 8;
                }

            }
            else
            {
                while (TotalworkingDays < NoOfWorkingDays && TotalEmpHours < MaxHoursPerMonth)
                {
                    TotalworkingDays++;
                    TotalEmpHours += 4;
                }
            }

            TotalEmpWage = TotalEmpHours * EmpRatePerHour;
            return TotalEmpWage;

        }

    }
}
