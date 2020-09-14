using System;
using ChessBoardModel;

namespace ChessBoardConsoleApp
{
    class MainClass
    {
        static Board myBoard;
        public static void Main(string[] args)
        {
            // show the empty chess board
            myBoard = new Board(8);
            PrintBoard(myBoard);

            // get the location of the chess piece
            Cell myLocation = SetCurrentCell();

            // calculate and mark the cells where
            // legal moves are possible.
            myBoard.MarkNextLegalMoves(myLocation, "Knight");
            // show the chess board. Use. for an
            //empty square, X for the piece
            // location and + for a possible legal
            // move
            PrintBoard(myBoard);


            // wait for another return key to end the program
            Console.ReadLine();

        }

        static void PrintBoard(Board g)
        {
            for(int i = 0; i < myBoard.Size; i++)
            {
                for(int j = 0; j < myBoard.Size; j++)
                {
                    if(myBoard.theGrid[i, j].CurrentlyOccupied)
                    {
                        Console.Write("X");
                    } else if (myBoard.theGrid[i,j].LegalNextMove)
                    {
                        Console.Write("+");
                    } else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("=============================================");
        }

        static public Cell SetCurrentCell()
        {
            Console.Out.Write("Enter your current row number ");
            int currentRow = GetIntInput();
            Console.Out.Write("Enter your current column number ");
            int currentCol = GetIntInput();

            myBoard.theGrid[currentRow, currentCol].CurrentlyOccupied = true;

            return myBoard.theGrid[currentRow, currentCol];
        }

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
    }
}
