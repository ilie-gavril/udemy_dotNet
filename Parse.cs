using System;
namespace Udemy_dotNet
{
    public class Parse
    {
        public Parse()
        {
            string stringForFloat = "0.85";
            string stringForInt = "12345";
            float num1 = Int32.Parse(stringForFloat);
            int num2 = Int32.Parse(stringForInt);
        }
    }
}
