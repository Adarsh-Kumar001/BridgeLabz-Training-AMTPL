using System;
using System.Text.RegularExpressions;

class RegularExpression
{

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a phone number: ");
        string phoneNumber  = Console.ReadLine();

        string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{2}-[0-9]{10}$)";

        Regex rg = new Regex(strRegex);

        if (rg.IsMatch(phoneNumber))
        {
            Console.WriteLine("Its a valid phone number");
        }
        else
        {
            Console.WriteLine("Its not a valid phone number");
        }

    }
}
