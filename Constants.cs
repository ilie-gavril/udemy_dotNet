using System;
namespace Udemy_dotNet
{
    public class Constants
    {
        // constants as fields

        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;

        const string myBirthday = "20.07.1997";

        public static void Afisare()
        {
            Console.WriteLine($"Ziua mea o sa fie mereu {myBirthday}");
        }
    }

    class MyCar
    {
        public static void Manufacturer(string Manf)
        {
            Console.WriteLine(Manf);
        }
    }
}
