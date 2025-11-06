using System;

class Program
{
    public const int isFullTime = 1;
    public const int isParttime = 2;
    public const int EmpRatePerHour = 20;

    static void Main(string[] args)
    {


        int EmpHours = 0;
        int EmpWage = 0;

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

        EmpWage = EmpHours * EmpRatePerHour;

        Console.WriteLine("Employee wage is: " + EmpWage); //
    }
}
