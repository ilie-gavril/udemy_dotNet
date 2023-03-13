using System;
namespace Udemy_dotNet
{
    class MultiDimensional_Arrays
    {
        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };


        public MultiDimensional_Arrays()
        {
        }

        public static void Ex1()
        {
            // declare 2D Array
            string[,] matrix;

            int[,,] threeD;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3}, // row 0
                {4,5,6}, // row 1
                {7,8,9}  // row 2
            };

            //Console.WriteLine("Central Value is {0}", array2D[2, 0]);


            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001"},
                    {"010","011"},
                    {"hi there", "what's upp"}
                },
                {
                    {"100","101"},
                    {"110","111"},
                    {"another one", "last entry"}
                }
            };

            string[,] array2DString = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            array2DString[1, 1] = "chicken";

            int dimensions = array2DString.Rank;

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("Central Value is {0}", array2DString[1, 1]);



        }
        public static void Ex2()
        {
            foreach (int item in matrix)
            {
                
            }

            Console.WriteLine("this is 2D array nested for loop");

            //for (int i = 0; i < matrix.GetLength(0) ; i++)
            //{
            //    for (int x = 0; x < matrix.GetLength(1); x++)
            //    {
            //        if (i == x)
            //        {
            //            Console.Write(matrix[i, x] + " ");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            for (int a = 0, b = matrix.GetLength(1) - 1; a < matrix.GetLength(0); a++, b--)
            { 

                Console.WriteLine(matrix[a,b]);

            }





        }
    }
}
