using System;
namespace Udemy_dotNet
{
    public class LoopsAndSwitch_Practice
    {
        public LoopsAndSwitch_Practice()
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
                        bool validString = true;
                        foreach (char x in input)
                        {
                            if (!char.IsLetter(x))
                            {
                                Console.WriteLine("You have entered the value: {0}", input);
                                Console.WriteLine("It is not valid: String");
                                validString = false;
                                break;
                            }
                            else
                            {
                                validString = true;
                            }
                        }
                        if (validString)
                        {
                            Console.WriteLine("You have entered the value: {0}", input);
                            Console.WriteLine("It is a valid: String");
                        }
                        break;
                    case 2:
                        if (int.TryParse(input, out int number))
                        {
                            Console.WriteLine("You have entered the value: {0}", number);
                            Console.WriteLine("It is a valid: Integer");
                        }
                        else
                        {
                            Console.WriteLine("You have entered the value: {0}", input);
                            Console.WriteLine("It is not valid: Integer");
                        }

                        break;
                    case 3:
                        if (bool.TryParse(input, out bool valid))
                        {
                            Console.WriteLine("You have entered the value: {0}", input);
                            Console.WriteLine("It is valid: Boolean");
                        }
                        else
                        {
                            Console.WriteLine("You have entered the value: {0}", input);
                            Console.WriteLine("It is not valid: Boolean");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("You have entered wrong input!");
            }
        }
    }
}