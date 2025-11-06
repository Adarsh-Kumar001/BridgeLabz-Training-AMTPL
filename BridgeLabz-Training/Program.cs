using System;

class Program
{
    public const int isFullTime = 1;
    public const int isParttime = 2;
    
    public static int ComputeEmpWage(string company, int empRatePerHour, int noOfWorkingDays, int maxHoursPerMonth)
    {
        int empHours = 0, totalEmpHours = 0, totalWorkingDays = 0;

        while(totalEmpHours <= maxHoursPerMonth && totalWorkingDays < noOfWorkingDays)
        {
            totalWorkingDays++;

            Random rndm = new Random();

            int EmpCheck = rndm.Next(0, 3);

            switch (EmpCheck)
            {
                case isFullTime:
                    empHours = 8;
                    break;
                case isParttime:
                    empHours = 4;
                    break;
                default:
                    empHours = 0;
                    break;
            }

            totalEmpHours += empHours;
        }
        int totalEmpWage = totalEmpHours * empRatePerHour;
        Console.WriteLine("Total Employee wage of company"+ company+" is: " + totalEmpWage);
        return totalEmpWage;    
    }

    static void Main(string[] args)
    {

        ComputeEmpWage("ABC", 20, 2, 10);
    }
}
