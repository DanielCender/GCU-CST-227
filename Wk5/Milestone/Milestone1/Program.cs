using MinesweeperClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    class MainClass
    {
        public static Board board;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LevelSelect());
            }

    //public static void Main(string[] args)
    //{
    //    int size = -1;
    //    Console.Out.WriteLine("Welcome to Minesweeper!");
    //    while (size == -1)
    //    {
    //        Console.Out.WriteLine("Please enter the desired size of the grid: ");
    //        size = GetIntInput();
    //        if (size == -1) continue; // check for invalid input
    //        board = new Board(size);

    //        // Play game
    //        Console.Clear();
    //    }

    //    bool gameEnd = false;
    //    while (!gameEnd)
    //    {
    //        Console.Out.WriteLine("Enter a Row Number");
    //        int row = GetIntInput();
    //        Console.Out.WriteLine("Enter a Column Number");
    //        int col = GetIntInput();
    //        // Check for invalid index values
    //        if (row < 0 || col < 0 || row >= size || col >= size)
    //        {
    //            Console.Out.WriteLine("A Row or Column number goes beyond the scope of the board. Please try again.");
    //            continue;
    //        }

    //        // Hitting a bomb triggers a game failure, obviously.
    //        if (board.Grid[row, col].Live)
    //        {
    //            Console.Out.WriteLine("**** You selected an armed tile! Game Over ****");
    //            gameEnd = true;
    //            continue;
    //        }
    //        else
    //        {
    //            // Check if all the unarmed tiles have been revealed so far. Constitutes a won game.
    //            if(AllSafeTilesVisited())
    //            {
    //                Console.Out.WriteLine("**** You have visited all the safe tiles! Game Completed ****");
    //                gameEnd = true;
    //                continue;
    //            }
    //        }

    //        // If no game-changing states are found, set tile to visited and fill out buffer cells
    //        board.floodFill(row, col);

    //        // Print the grid
    //        PrintBoardDuringGame();

    //        //PrintBoardDuringTest(); // for dev purposes
    //    }
    //}

    public static int GetIntInput()
        {
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Out.WriteLine("The input must be an integer. The value you entered was invalid.");
                return -1;
            }
            return choice;
        }

        public static void PrintBoard()
        {
            Console.Out.WriteLine(string.Format("*** BOARD {0}x{0} ***", board.Size));
            int rows = board.Grid.GetLength(0);
            int cols = board.Grid.GetLength(1);
            // Print the top line of column headers
            for (int idx = 0; idx < cols; idx++)
            {
                if (idx == 0) Console.Out.Write("+");
                Console.Out.Write(string.Format(" {0} +", idx));
            }
            // NewLine to actual grid
            PrintLineSeparator(cols);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    // Print row col element
                    Console.Out.Write(": ");
                    if (board.Grid[row, col].Visited)
                    {
                        Console.Out.Write(board.Grid[row, col].LiveNeighbors);
                    }
                    else
                    {
                        Console.Out.Write("*");
                    }
                    Console.Out.Write(" ");
                    // If end of row, print the column number
                    if (col == cols - 1) Console.Out.Write(string.Format(": {0} ", row));
                }
                PrintLineSeparator(cols); // next row
            }
        }

        private static void PrintLineSeparator(int nbr)
        {
            Console.Out.Write("\n+");
            for (int idx = 0; idx < nbr; idx++)
            {
                Console.Out.Write("---+");
            }
            Console.Out.Write("\n");
        }

        public static void PrintBoardDuringGame()
        {
            int rows = board.Grid.GetLength(0);
            int cols = board.Grid.GetLength(1);
            // Print the top line of column headers
            for (int idx = 0; idx < cols; idx++)
            {
                if (idx == 0) Console.Out.Write("+");
                Console.Out.Write(string.Format(" {0} +", idx));
            }
            // NewLine to actual grid
            PrintLineSeparator(cols);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    // Print row col element
                    Console.Out.Write(": ");
                    // Print row element
                    if (board.Grid[row, col].Visited)
                    {
                        if (board.Grid[row, col].LiveNeighbors > 0)
                        {
                            Console.Out.Write(board.Grid[row, col].LiveNeighbors);
                        }
                        else
                        {
                            Console.Out.Write("~");
                        }
                    }
                    else
                    {
                        Console.Out.Write("?");
                    }
                    Console.Out.Write(" ");
                    // If end of row, print the column number
                    if (col == cols - 1) Console.Out.Write(string.Format(": {0} ", row));
                }
                PrintLineSeparator(cols); // next row
            }
        }

        public static void PrintBoardDuringTest()
        {
            int rows = board.Grid.GetLength(0);
            int cols = board.Grid.GetLength(1);
            // Print the top line of column headers
            for (int idx = 0; idx < cols; idx++)
            {
                if (idx == 0) Console.Out.Write("+");
                Console.Out.Write(string.Format(" {0} +", idx));
            }
            // NewLine to actual grid
            PrintLineSeparator(cols);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    // Print row col element
                    Console.Out.Write(": ");
                    // Print row element
                        if (board.Grid[row, col].LiveNeighbors > 0)
                        {
                            Console.Out.Write(board.Grid[row, col].Live ? "*" : string.Format("{0}", board.Grid[row, col].LiveNeighbors));
                        }
                        else
                        {
                            Console.Out.Write("~");
                        }
                    Console.Out.Write(" ");
                    // If end of row, print the column number
                    if (col == cols - 1) Console.Out.Write(string.Format(": {0} ", row));
                }
                PrintLineSeparator(cols); // next row
            }
        }

        public static bool AllSafeTilesVisited()
        {
            int rows = board.Grid.GetLength(0);
            int cols = board.Grid.GetLength(1);
            bool someUnvisited = false;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (!board.Grid[row, col].Visited && !board.Grid[row, col].Live) someUnvisited = true;
                }
            }
            return !someUnvisited;
        }
    }
}
