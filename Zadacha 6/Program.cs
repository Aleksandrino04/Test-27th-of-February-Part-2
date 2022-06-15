using System;

namespace Zadacha_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double goldDug = 0;
            double count = 0;
            double averageGold = 0;
            double locations = double.Parse(Console.ReadLine());


            while (locations > 0)
            {
                double expectedGold = double.Parse(Console.ReadLine());
                int miningDays = int.Parse(Console.ReadLine());
                while (miningDays > 0)
                {
                    goldDug += double.Parse(Console.ReadLine());
                    miningDays -= 1;
                    count += 1;
                }
                if (miningDays == 0)
                {
                    averageGold = goldDug / count;
                }
                if (averageGold >= expectedGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGold:f2}.");
                    goldDug -= goldDug;
                    averageGold = 0;
                    count = 0;
                    locations -= 1;
                }
                else
                {
                    averageGold = expectedGold - averageGold;
                    Console.WriteLine(($"You need {averageGold:f2} gold."));
                    goldDug = 0;
                    averageGold = 0;
                    count = 0;
                    locations -= 1;
                }







            }
        }
    }
}
