using System.IO;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = readFile("identyfikator.txt");
            foreach (string line in lines)

            {
                Console.WriteLine(line);
                Console.WriteLine(" ");
            }

            foreach (var liczba in lines)
            {
                string bezZnakow = liczba.Substring(3);

                if (CzyLiczbaPierwsza(int.Parse(bezZnakow)))
                {
                    Console.WriteLine($"{bezZnakow} jest liczbą pierwszą.");
                }
            }
        }
        static string[] readFile(String file)
        {
            string[] lines = File.ReadAllLines(file);
            return lines;
        }
        static bool CzyLiczbaPierwsza(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}