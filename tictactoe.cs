using System;
namespace Udemy_dotNet
{
    public class TicTacToeProgram
    {
        static string[,] board = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        static string player;
        static string playerSymbol;
        static int i = 0;
        public static void Run()
        {
            do
            {
                Console.Clear();
                PrintBoard();
                PlayerTurn();
            } while (!CheckWin());
        }


        public static bool CheckWin()
        {
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
            {
                return WinGame();
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                return WinGame();
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                return WinGame();
            }
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            {
                return WinGame();
            }
            else if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
            {
                return WinGame();
            }
            else if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                return WinGame();
            }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return WinGame();
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return WinGame();
            }
            else if (
                !board[0, 0].Equals("1") && !board[0, 1].Equals("2") &&
                !board[0, 2].Equals("3") && !board[1, 0].Equals("4") &&
                !board[1, 1].Equals("5") && !board[1, 2].Equals("6") &&
                !board[2, 0].Equals("7") && !board[2, 1].Equals("8") &&
                !board[2, 2].Equals("9"))
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine("Draw!");
                Console.WriteLine("Press any key to restart the game!", player);
                Console.ReadKey();
                RestartGame();
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void PrintBoard()
        {
            Console.WriteLine($"   |   |   " +
    $"\n {board[0, 0]} | {board[0, 1]} | {board[0, 2]} " +
    $"\n___|___|___" +
    $"\n   |   |   " +
    $"\n {board[1, 0]} | {board[1, 1]} | {board[1, 2]} " +
    $"\n___|___|___" +
    $"\n   |   |   " +
    $"\n {board[2, 0]} | {board[2, 1]} | {board[2, 2]} " +
    $"\n   |   |   ");
        }

        public static void PlayerTurn()
        {

            player = i % 2 == 0 ? "player1" : "player2";
            playerSymbol = player == "player1" ? "O" : "X";
            Console.WriteLine("{0}, please enter field number:", player);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (player.Equals("player1"))
                {
                    boardUpdate0(input, board);
                }
                else
                {
                    boardUpdateX(input, board);
                }
            }
            else
            {
                PrintBoard();
                Console.WriteLine("Please enter valid filed value!");
            }
        }

        public static void boardUpdate0(string field, string[,] board)
        {
            switch (field)
            {
                case "1":
                    if (board[0, 0].Equals("X") || board[0, 0].Equals("O"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[0, 0] = "O";
                        i++;
                    }
                    break;
                case "2":
                    if (board[0, 1].Equals("X") || board[0, 1].Equals("O"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[0, 1] = "O";
                        i++;
                    }
                    break;
                case "3":
                    if (board[0, 2].Equals("X") || board[0, 2].Equals("O"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[0, 2] = "O";
                        i++;
                    }
                    break;
                case "4":
                    if (board[1, 0].Equals("X") || board[1, 0].Equals("O"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[1, 0] = "O";
                        i++;
                    }
                    break;
                case "5":
                    if (board[1, 1].Equals("X") || board[1, 1].Equals("O"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[1, 1] = "O";
                        i++;
                    }
                    break;
                case "6":
                    if (board[1, 2].Equals("X") || board[1, 2].Equals("O"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[1, 2] = "O";
                        i++;
                    }
                    break;
                case "7":
                    if (board[2, 0].Equals("X") || board[2, 0].Equals("O"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[2, 0] = "O";
                        i++;
                    }
                    break;
                case "8":
                    if (board[2, 1].Equals("X") || board[2, 1].Equals("O"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[2, 1] = "O";
                        i++;
                    }
                    break;
                case "9":
                    if (board[2, 2].Equals("X") || board[2, 2].Equals("O"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[2, 2] = "O";
                        i++;
                    }
                    break;
                default:
                    PrintBoard();
                    Console.WriteLine("You entered an value out of fields! Try Again");
                    PlayerTurn();
                    break;
            }
        }
        public static void boardUpdateX(string field, string[,] board)
        {
            switch (field)
            {
                case "1":
                    if (board[0, 0].Equals("O") || board[0, 0].Equals("X"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[0, 0] = "X";
                        i++;
                    }
                    break;
                case "2":
                    if (board[0, 1].Equals("O") || board[0, 1].Equals("X"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[0, 1] = "X";
                        i++;
                    }
                    break;
                case "3":
                    if (board[0, 2].Equals("O") || board[0, 2].Equals("X"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[0, 2] = "X";
                        i++;
                    }
                    break;
                case "4":
                    if (board[1, 0].Equals("O") || board[1, 0].Equals("X"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[1, 0] = "X";
                        i++;
                    }
                    break;
                case "5":
                    if (board[1, 1].Equals("O") || board[1, 1].Equals("X"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[1, 1] = "X";
                        i++;
                    }
                    break;
                case "6":
                    if (board[1, 2].Equals("O") || board[1, 2].Equals("X"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[1, 2] = "X";
                        i++;
                    }
                    break;
                case "7":
                    if (board[2, 0].Equals("O") || board[2, 0].Equals("X"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[2, 0] = "X";
                        i++;
                    }
                    break;
                case "8":
                    if (board[2, 1].Equals("O") || board[2, 1].Equals("X"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[2, 1] = "X";
                        i++;
                    }
                    break;
                case "9":
                    if (board[2, 2].Equals("O") || board[2, 2].Equals("X"))
                    {
                        Console.WriteLine("Field already filled!");
                        PlayerTurn();
                    }
                    else
                    {
                        board[2, 2] = "X";
                        i++;
                    }
                    break;
                default:
                    PrintBoard();
                    Console.WriteLine("You entered an value out of fields! Try Again");
                    PlayerTurn();
                    break;
            }
        }

        public static bool WinGame()
        {
            Console.Clear();
            PrintBoard();
            Console.WriteLine("{0}, has won the game!", player);
            Console.WriteLine("Press any key to restart the game!", player);
            Console.ReadKey();
            RestartGame();
            return true;
        }
        public static void RestartGame()
        {
            board = new string[,] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            i = 0;
            Console.Clear();
            Run();
        }
    }
}