using System;

class Program
{
    public const int isFullTime = 1;
    public const int isParttime = 2;
    public const int EmpRatePerHour = 20;
    public const int NoOfWorkingDays = 20;
    public const int MaxHoursInMonths = 10;

    static void Main(string[] args)
    {


        int EmpHours = 0;
        int TotalEmpHours = 0;
        int TotalWorkingDays = 0;

        while(TotalWorkingDays <= MaxHoursInMonths && TotalWorkingDays < NoOfWorkingDays)
        
        {
            TotalWorkingDays++;

            Random rndm = new Random();

            int EmpCheck = rndm.Next(0, 3);

            switch (EmpCheck)
            {
                case isFullTime:
                    EmpHours = 8;
                    break;
                case isParttime:
                    EmpHours = 4;
                    break;
                default:
                    EmpHours = 0;
                    break;
            }

            TotalEmpHours += EmpHours;
     

        }

        int totalEmpWage = TotalEmpHours * EmpRatePerHour;
        Console.WriteLine("Total Employee wage is: " + totalEmpWage); //
    }
}
