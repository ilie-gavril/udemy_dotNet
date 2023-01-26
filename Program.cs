using System;

namespace Udemy_dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num3, num4, num5;
            //int num1;
            //num1 = 13;
            //int num2 = 23;
            //int sum = num1 + num2;
            //// concatenare (+)
            //Console.WriteLine("num1: " + num1 + "+ num2: " + num2 + " is " + sum);

            //double d1 = 3.1415;
            //double d2 = 5.1;
            //double dDiv = d1 / d2;


            //float f1 = 3.1415f;
            //float f2 = 5.1f;

            //float fDiv = f1 / f2;

            //double dIDiv = d1 / num1;

            //Console.WriteLine("d1/d2 =" + dIDiv);
            //Console.WriteLine("f1/f2 =" + fDiv);

            string myname = "Ilie";

            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerMessage = message.ToLower();

            Console.WriteLine(lowerMessage);
        }
    }
}
