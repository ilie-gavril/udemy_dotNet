using System;
namespace Udemy_dotNet
{
    public class JaggedArrays
    {
        public static void Run()
        {
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 6, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 14, 24 };


            int[][] jaggedArray2 = new int[][]
            {
                new int [] {2,3,5,7,11 },
                new int [] {1,2,3}
            };

            Console.WriteLine("The value in the middle is {0}", jaggedArray2[0][2]);
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Array {0} elements:", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }

            string[][] friendsFamily = new string[][]
            {
                new string[] {"Codrin", "Catalin"},
                new string[] {"Andreea", "Denisa"},
                new string[] {"Adi", "Cornelia"}
            };

            Console.WriteLine("Hello, {0}, I would like to introduce to you, {1}", friendsFamily[0][0], friendsFamily[1][0]);
            Console.WriteLine("Hello, {0}, I would like to introduce to you, {1}", friendsFamily[1][1], friendsFamily[2][0]);
            Console.WriteLine("Hello, {0}, I would like to introduce to you, {1}", friendsFamily[1][0], friendsFamily[0][1]);

        }
    }
}
