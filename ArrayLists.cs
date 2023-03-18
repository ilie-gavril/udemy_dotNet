using System;
using System.Collections;
namespace Udemy_dotNet
{
    public class ArraysPractices
    {
        public static void Run()
        {
            //declaring an Arraylist with undefined amount of object
            ArrayList myArrayList = new ArrayList();
            // with defined amound of object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(14.235);
            myArrayList.Add(13);
            myArrayList.Add(13);
            myArrayList.Add(13);
            myArrayList.Add(128);


            //delete element with spicific value from the arraylist
            myArrayList.Remove(13);
            myArrayList.Remove(13);

            //delete element at specific index

            myArrayList.RemoveAt(0);


            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double){
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine(sum);
        }
    }
}
