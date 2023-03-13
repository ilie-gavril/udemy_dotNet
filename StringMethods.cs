using System;
namespace Udemy_dotNet
{
    public class StringMethods
    {
        public static void Afisare()
        {
            //string cuv1 = "masina";
            //string cuv2 = cuv1.Substring(2);

            //string fraza1 = "Nu mai am baterie la masina";

            //var name = "ilie";

            //String.Format("My name is {0}, name");

            //Console.WriteLine(fraza1.IndexOf('m'));


            Console.Write("Enter a string here: ");
            string input = Console.ReadLine();
            Console.Write("Enter the character to search: ");
            char searchInput = Console.ReadLine()[0];
            int searchIndex = input.IndexOf(searchInput);

            Console.WriteLine($"Index of character {searchInput} is {searchIndex} ");

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            string fullName = string.Concat(firstName, " ", lastName);

            Console.WriteLine($"Your full name is: {fullName}");
        }
    }
}
