using System;
namespace Udemy_dotNet
{
    public class MediaAritmetica
    {
        public MediaAritmetica()
        {
        }

        public static void Calcul()
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries is {0}", count);
                Console.WriteLine("Please enter '-1' once you are ready to calculate the average");

                input = Console.ReadLine();

                if (input.Equals("-1"))
                {
                    if (count == 0)
                    {
                        Console.WriteLine("You need to add scores!");
                        Console.WriteLine("Start over!");
                        break;
                    }
                    else
                    {
                        double average = (double)total / (double)count;
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Average of your numbers is {0}", average);
                        break;
                    }
                } else if (int.TryParse(input, out currentNumber))
                {
                    if (currentNumber > 0 && currentNumber <= 20)
                    {
                        total += currentNumber;
                        count += 1;
                    }
                    else
                    {
                        Console.WriteLine("You need to add scores between 0 and 20!");
                        Console.WriteLine("Start over!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You have entered a wrong type of score!");
                    Console.WriteLine("Start over!");
                    break;
                }
            }
        }
    }
}
