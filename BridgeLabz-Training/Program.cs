using System;

class Program
{
    static void Main(string[] args)
    {
        int isFullTime = 1;

        Random rndm = new Random();

        int EmpCheck = rndm.Next(0, 1);

        if( EmpCheck == isFullTime)
        {
            Console.WriteLine("Employee is present");
        }
        else
        {
            Console.WriteLine("Employee is absent");
        }
    }
}
