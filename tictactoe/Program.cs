using System;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            char player = 'X';
            char[,] board = new char[3, 3];

            Initialize(board);

            while (true)
            {
                Console.Clear();
                Print(board);

                Console.Write("Please Enter the Row: ");
                int row = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please Enter the Column: ");
                int col = Convert.ToInt32(Console.ReadLine());

                board[row, col] = player;

                if (player == board[0,0] && player == board[0,1] && player == board[0, 2])
                {
                    Console.WriteLine(player + "has won !");
                    break;
                }

                player = ChangeTurn(player);
            }
        }

        static void Initialize(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        static void Print(char[,] board)
        {
            Console.WriteLine("  | 0 | 1 | 2 |");

            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + " | ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

        static char ChangeTurn(char currentPlayer)
        {
            if (currentPlayer == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }
    }
}