using System;
namespace Udemy_dotNet
{
    public class ArraysAsParams
    {
        public static void Run()
        {
            int[] studentsGrades = new int[] { 15, 13, 7, 12, 7, 16 };

            double averageResult = GetAverage(studentsGrades);

            foreach(int grade in studentsGrades)
            {
                Console.WriteLine("{0}", grade);
            }

            Console.WriteLine("The average is {0}", averageResult);

            int[] happyness = new int[] { 10, 12, 16, 18, 20 };

            happyness = SunIsShining(happyness);

            foreach (int happy in happyness)
            {
                Console.WriteLine("{0}", happy);
            }


        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / (double)size;
            return average;
        }

        static int[] SunIsShining(int [] arrayToIncrease)
        {
            int[] doubleHappyness;
            doubleHappyness = arrayToIncrease;
            for(int i = 0; i < arrayToIncrease.Length; i++)
            {
                doubleHappyness[i] += 2;
            }
            return doubleHappyness;
        }
    }
}
