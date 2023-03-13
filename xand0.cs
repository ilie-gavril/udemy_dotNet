using System;
namespace Udemy_dotNet
{
    public class xand0
    {
        static string[,] initialTable = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        static string[,] playableTable = { {"1","2","3"}, { "4", "5", "6" }, { "7", "8", "9"}};
        public static void afisare()
        {
            int i = 0;
            PrintTable(initialTable);
            while (!CheckTable(playableTable))
            {
                string player = i % 2 == 0 ? "player1" : "player2";
                string playerSymbol = player == "player1" ? "0" : "X";
                Console.WriteLine("{0}: Choose your field!", player);
                string inputField = Console.ReadLine();
                if (int.TryParse(inputField, out int chosenField))
                {
                    ChangeField(inputField, playerSymbol);
                    PrintTable(playableTable);
                }
                else
                {
                   Console.WriteLine("Please enter an valid field number!");
                }
                i++;
            }
        }

        private static void ChangeField(string field, string playerSymbol)
        {
            for(int i = 0; i < initialTable.GetLength(0); i++)
            {
                for (int j = 0; j < initialTable.GetLength(1); j++)
                {
                    if (initialTable[i, j] == field)
                    {
                        playableTable[i, j] = playerSymbol;
                        break;
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

    }
}
