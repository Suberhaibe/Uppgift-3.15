using System;
namespace Uppgift_3._15
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många timman tänkar du dig att hyra bilen");
            int timmar = int.Parse(Console.ReadLine());
            int kostnad = timmar * 80;
            if (kostnad > 950)
            {
                kostnad = 950;
            }
            Console.WriteLine($"Kosnaden för att du hyra bilen i (timmar) timmar är (kostnad) kr.");
        }
    }
}


