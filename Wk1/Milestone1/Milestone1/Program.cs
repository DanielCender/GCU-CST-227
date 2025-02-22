﻿using System;

namespace Milestone1
{
    class MainClass
    {
        public static Board board;

        public static void Main(string[] args)
        {
            int response = 1;
            Console.Out.WriteLine("Welcome to Minesweeper!");
            while (response != 0)
            {
                Console.Out.WriteLine("Please enter the desired size of the grid: ");
                int size = getIntInput();
                if (size == -1) continue; // check for invalid input
                board = new Board(size);

                // Play game
                Console.Clear();
                printBoard();
            }
        }

        public static int getIntInput()
        {
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                Console.Out.WriteLine(string.Format("Here's the input: ${0}", choice));
            }
            else
            {
                Console.Out.WriteLine("The input must be an integer. The value you entered was invalid.");
                return -1;
            }
            return choice;
        }

        public static void printBoard()
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
            printLineSeparator(cols);
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
                printLineSeparator(cols); // next row
            }
        }

        private static void printLineSeparator(int nbr)
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
            printLineSeparator(cols);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    // Print row element
                    if (board.Grid[row, col].Visited)
                    {
                        if (board.Grid[row, col].LiveNeighbors > 0)
                        {
                            Console.Out.Write(board.Grid[row, col].LiveNeighbors);
                        }
                        else
                        {
                            Console.Out.Write(" ");
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
                printLineSeparator(cols); // next row
            }
        }
    }
}
