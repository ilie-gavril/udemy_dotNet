using System;
namespace Udemy_dotNet
{
    public class LoopsAndSwitch_Practice2
    {
        public LoopsAndSwitch_Practice2()
        {
        }

        public static void Run()
        {
            Console.WriteLine("Enter a value:");
            string input = Console.ReadLine();
            Console.WriteLine("Select the data type to validate the input you have entered.");
            Console.WriteLine("Press 1 for String;");
            Console.WriteLine("Press 2 for Integer;");
            Console.WriteLine("Press 3 for Boolean;");
            string caseInput = Console.ReadLine();
            if (int.TryParse(caseInput, out int type))
            {
                int dataType = type;
                switch (dataType)
                {
                    case 1:
                        if (IsAllAlphabetic(input))
                        {
                            Console.WriteLine("You have entered the value: {0}", input);
                            Console.WriteLine("It is a valid: String");
                        }
                        else
                        {
                            Console.WriteLine("You have entered the value: {0}", input);
                            Console.WriteLine("It is not a valid: String");
                        }
                       
                        break;
                    case 2:
                        if (IsAValidInteger(input))
                        {
                            Console.WriteLine("You have entered the value: {0}", input);
                            Console.WriteLine("It is a valid: integer");
                        }
                        else
                        {
                            Console.WriteLine("You have entered the value: {0}", input);
                            Console.WriteLine("It is not a valid: integer");
                        }
                        break;
                    case 3:
                        if (IsAValidBool(input))
                        {
                            Console.WriteLine("You have entered the value: {0}", input);
                            Console.WriteLine("It is a valid: boolean");
                        }
                        else
                        {
                            Console.WriteLine("You have entered the value: {0}", input);
                            Console.WriteLine("It is not a valid: boolean");
                        }
                        break;
                    default:
                        Console.WriteLine("Something is wrong!");
                        break;
                   
                }

            }
        }

        private static bool IsAllAlphabetic(string value)
        {
            foreach( char x in value)
            {
                if (!char.IsLetter(x))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsAValidInteger(string value)
        {
            if(int.TryParse(value, out int number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsAValidBool(string value)
        {
            if(bool.TryParse(value, out bool boolean))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
