using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "identyfikator.txt";


        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            if (IsPrimeString(line))
            {
                Console.WriteLine(line);
            }
        }
    }

    static bool IsPrimeString(string input)
    {
        string numericPart = input.Substring(3);

        foreach (char digit in numericPart)
        {
            if (!IsPrime(int.Parse(digit.ToString())))
            {
                return false;
            }
        }
        return true;
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}