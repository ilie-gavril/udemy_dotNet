using System;
namespace Udemy_dotNet
{
    public class Params
    {
        public Params()
        {
        }


    public static void Run(params string[] sencence)
        {
            for (int i = 0; i < sencence.Length; i++)
                Console.Write(sencence[i] + " ");
        }
    }
}
