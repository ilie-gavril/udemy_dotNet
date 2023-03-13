using System;
namespace Udemy_dotNet
{
    public class xand0
    {
        static string player;
        static string playerSymbol;
        static string[,] initialTable = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        static string[,] playableTable = { {"1","2","3"}, { "4", "5", "6" }, { "7", "8", "9"}};
        static bool restartGame = false;
        public static void afisare()
        {
            restartGame = CheckTable(playableTable);
            int i = 0;
            PrintTable(initialTable);
            if (restartGame)
            {
                Console.WriteLine("{0} has won the game", player);
                Console.WriteLine("Press any key to restart the game!");
                Console.ReadKey();
                restartGame = false;
            }
            else
            {
                while (!restartGame)
                {
                    player = i % 2 == 0 ? "player1" : "player2";
                    playerSymbol = player == "player1" ? "O" : "X";
                    Console.WriteLine("{0}: Choose your field!", player);
                    string inputField = Console.ReadLine();
                    if (int.TryParse(inputField, out int chosenField))
                    {
                        ChooseField(inputField, playerSymbol);
                        PrintTable(initialTable);
                    }
                    else
                    {
                        Console.WriteLine("Please enter an valid field number!");
                    }
                    i++;
                }
            }
        }

        private static void ChangeField(string field, string playerSymbol)
        {
            for(int i = 0; i < initialTable.GetLength(0); i++)
            {
                for (int j = 0; j < initialTable.GetLength(1); j++)
                {
                    if (playableTable[i, j] == field)
                    {
                        if (playableTable[i, j].Equals("X") && playableTable[i, j].Equals("O"))
                        {
                            Console.WriteLine("Field already marked!");
                            break;
                        }
                        else
                        {
                            playableTable[i, j] = playerSymbol;
                            break;
                        }
                    }
                }
            }
        }

        private static void PrintTable(string[,] table)
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", table[0, 0], table[0, 1], table[0, 2]); ;
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", table[1, 0], table[1, 1], table[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", table[2, 0], table[2, 1], table[2, 2]);
            Console.WriteLine("     |     |     ");
        }

        private static bool CheckTable(string[,] table)
        {
            if (table[0, 0].Equals(table[0, 1]) && table[0, 1].Equals(table[0, 2]))
            {
                return true;
            }
            else if (table[1, 0].Equals(table[1, 1]) && table[1, 1].Equals(table[1, 2]))
            {
                return true;
            }
            else if (table[1, 0].Equals(table[1, 1]) && table[1, 1].Equals(table[1, 2]))
            {
                return true;
            }
            else if (table[0, 0].Equals(table[1, 0]) && table[1, 0].Equals(table[2, 0]))
            {
                return true;
            }
            else if (table[0, 1].Equals(table[1, 1]) && table[1, 1].Equals(table[2, 1]))
            {
                return true;
            }
            else if (table[0, 2].Equals(table[1, 2]) && table[1, 1].Equals(table[2, 2]))
            {
                return true;
            }
            else if (table[2, 0].Equals(table[2, 1]) && table[2, 1].Equals(table[2, 2]))//diagonala (3,5,7)
            {
                return true;
            }
            else if (table[0, 0].Equals(table[1, 1]) && table[2, 2].Equals(table[2, 1]))//diagonala (1,5,9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void ChooseField(string inputField, string playerSymbol)
        {
            switch (inputField)
            {
                case "1":
                    initialTable[0, 0] = playerSymbol;
                    break;

                case "2":
                    initialTable[0, 1] = playerSymbol;
                    break;

                case "3":
                    initialTable[0, 2] = playerSymbol;
                    break;
                
                case "4":
                    initialTable[1, 0] = playerSymbol;
                    break;

                case "5":
                    initialTable[1, 1] = playerSymbol;
                    break;

                case "6":
                    initialTable[1, 2] = playerSymbol;
                    break;
                case "7":
                    initialTable[2, 0] = playerSymbol;
                    break;
                case "8":
                    initialTable[2, 1] = playerSymbol;
                    break;
                case "9":
                    initialTable[2, 2] = playerSymbol;
                    break;
                default:
                    break;
            }
        }
    }
}
