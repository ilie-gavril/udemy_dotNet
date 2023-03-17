using System;

namespace Udemy_dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human ilie = new Human("Ilie","Gavril", "brown", 25);

            ////access public variable from outside, and even change it;
            ////call method
            //ilie.IntroduceMyself();
            //Human andreea = new Human("Andreea","Caprian", "brown");
            //andreea.IntroduceMyself();

            //Human codrin = new Human("Leonte", "Codrin");
            //codrin.IntroduceMyself();

            //Human basicHuman = new Human();

            //basicHuman.IntroduceMyself();

            //Human alexandra = new Human("Alexandra");
            //alexandra.IntroduceMyself();

            //Box box = new Box(4,6,2);
            //Console.WriteLine("Width = {0}", box.Width);
            //box.Width = 10;
            //Console.WriteLine("Width = {0}", box.Width);
            //Console.WriteLine("FrontSurface = {0}", box.FrontSurface);

            //Console.WriteLine("Volume = {0}", box.Volume);
            //box.DisplayInfo();


            //Members member1 = new Members();
            //member1.Introducing(true);

            // declare and initialize
            //int[] grades = new int[5];

            //grades[0] = 10;
            //grades[1] = 6;
            //grades[2] = 5;
            //grades[3] = 7;
            //grades[4] = 9;

            //Console.WriteLine("Grades at index 0: {0}", grades[0]);

            //string input = Console.ReadLine();
            //grades[0] = int.Parse(input);

            //Console.WriteLine("Grades at index 0: {0}", grades[0]);



            ////second way
            //int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 7 };
            //// third way

            //int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 16, 18, 15 };

            //Console.WriteLine("Lenght of array: {0}", gradesOfMathStudentsB.Length);


            //int[] nums = new int[10];

            //for(int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i + 10;
            //}

            //for (int x = 0; x < nums.Length; x++)
            //{
            //    Console.WriteLine("Element{0}: {1}", x, nums[x]);
            //}
            //int counter = 0;
            //foreach(int a in nums)
            //{   
            //    Console.WriteLine("Element{0}: {1}", counter, a);
            //    counter++;
            //}


            //string[] bestFriends = { "Codrin", "Alex", "Andrei", "Vlad", "Adi" };

            //foreach(string i in bestFriends)
            //{
            //    Console.WriteLine("Hello, {0}!", i);
            //}
            //LoopsAndSwitch_Practice2.Run();


            //MultiDimensional_Arrays.Ex2();
            //TicTacToeProgram.Run();
            //JaggedArrays.Run();
            //ArraysAsParams.Run();
            Params.Run("this", "is", "something");
        }
    }
}
