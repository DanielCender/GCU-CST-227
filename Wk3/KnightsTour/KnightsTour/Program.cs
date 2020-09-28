using System;

namespace KnightsTour
{
    class MainClass
    {
        static int BoardSize = 8;
        static int attemptedMoves = 0;

        static int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };
        static int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };

        static int[,] boardGrid = new int[BoardSize, BoardSize];

        // Driver Code
        public static void Main(string[] args)
        {
            solveKT();
            Console.ReadLine();
        }

        static void solveKT()
        {
            /* Initialization of solution matrix. Value of -1 means "not visited yet" */
            for(int x = 0; x < BoardSize; x++)
            {
                for(int y = 0; y < BoardSize; y++)
                {
                    boardGrid[x, y] = -1;
                }
            }

            int startX = 0;
            int startY = 4;
            // starting position for knight
            boardGrid[startX, startY] = 0;

            // for counting number of guesses
            attemptedMoves = 0;

            /*  */
            if (!solveKTUtil(startX, startY, 1))
            {
                Console.WriteLine("Solution does not exist for {0} {1}", startX, startY);
            }
            else
            {
                printSolution(boardGrid);
                Console.Out.WriteLine("Total attempted moves {0}", attemptedMoves);
            }
        }

        static bool solveKTUtil(int x, int y, int moveCount)
        {
            attemptedMoves++;
            if (attemptedMoves % 1000000 == 0) Console.Out.WriteLine("Attempts: {0}", attemptedMoves);

            int k, next_x, next_y;

            // check to see if we have reached a solution. 64 = moveCount
            if (moveCount == BoardSize * BoardSize)
                return true;

            // corresponds to idx of moveset to use next
            int next = CountVisitedNeighbors(x, y);
            next_x = x + xMove[next];
            next_y = y + yMove[next];
            boardGrid[next_x, next_y] = moveCount;
            if (solveKTUtil(next_x, next_y, moveCount + 1))
                return true;
            else
                // backtracking
                boardGrid[next_x, next_y] = -1;
            return false;

            /*
             * Original "Brute Force" method. 
             * Highly inefficient, since there are over 26 billion directed tours of an 8x8 grid :|
             */ 
            //for (k = 0; k < 8; k++)
            //{
            //    next_x = x + xMove[k];
            //    next_y = y + yMove[k];
            //    if (isSquareSafe(next_x, next_y))
            //    {
            //        boardGrid[next_x, next_y] = moveCount;
            //        if (solveKTUtil(next_x, next_y, moveCount + 1))
            //            return true;
            //        else
            //            // backtracking
            //            boardGrid[next_x, next_y] = -1;
            //    }
            //}
            //return false;
        }

        /* A utility function to check if i,j are valid indexes for N*N chessboard */
        static bool isSquareSafe(int x, int y)
        {
            return (x >= 0 && x < BoardSize && y >= 0 && y < BoardSize && boardGrid[x, y] == -1);
        }

        /* A utility function to print solution matrix sol[N][N] */
        static void printSolution(int[,] solution)
        {
            for(int x = 0; x < BoardSize; x++)
                for(int y = 0; y < BoardSize; y++)
                    Console.Write(solution[x, y] + " ");

            Console.WriteLine();
        }

        /* Returns count of all empty, adjacent cells */
        static int GetEmptyAdjacent(int x, int y)
        {
            int allAdjacent = 0;
            for(int i = 0; i < 8; i++)
            {
                if (isSquareSafe(x + xMove[i], y + yMove[i])) allAdjacent++;
            }
            return allAdjacent;
        }

        /* Helper that returns the move of "least resistence", or the route less travelled for the tour. */
        static int CountVisitedNeighbors(int x, int y)
        {
            int minDegree = 9, minDegreeIdx = -1, tmp, nx, ny;

            // iterate through possible neighbors
            for (int k = 0; k < 8; k++)
            {
                nx = x + xMove[k];
                ny = y + yMove[k];
                if(isSquareSafe(nx , ny) && (tmp = GetEmptyAdjacent(nx, ny)) < minDegree)
                {
                    minDegree = tmp;
                    minDegreeIdx = k;
                }
            }

            return minDegreeIdx;
        }
    }
}
