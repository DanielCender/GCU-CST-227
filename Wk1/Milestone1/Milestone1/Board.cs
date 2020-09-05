﻿using System;
namespace Milestone1
{
    public class Board
    {
        public int Size { get; set; }
        public Cell[,] Grid { get; set; }
        public int Difficulty { get; set; }

        public Board()
        {
            Size = 1;
            Difficulty = 1;
            Grid = new Cell[Size, Size];
        }
        public Board(int size)
        {
            Size = size;
            Difficulty = 12; // 12% of board is bombs to start
            Grid = new Cell[Size, Size];
            SetupLiveNeighbors();
        }

        public void SetupLiveNeighbors()
        {
            int squareSpace = (int) Math.Pow(Size, 2);
            int totalAllowedBombs = squareSpace * (Difficulty / 100);
            // Create 2D array to calculate which cells are live/dead
            Random rand = new Random();
            bool[] liveCells = new bool[squareSpace];
            // Setup and populate sorting set, used to randomize the liveCells array
            Double[] sortOrder = new Double[squareSpace];
            for (int idx = 0; idx < sortOrder.Length; idx++)
                sortOrder[idx] = rand.NextDouble();
            for (int idx = 0; idx < squareSpace; idx++)
            {
                // guarantee that all allowed bombs are set
                // in accord with the difficulty setting
                liveCells[idx] = idx < totalAllowedBombs;
            }
            // Randomize the liveCells placement through sortOrder
            Array.Sort(sortOrder, liveCells);

            Console.Out.WriteLine(string.Format("Sorted live cell array: ${0}", liveCells.ToString()));

            // Now iter through 2D array and initialize all cells
            int liveCellSeedIdx = 0;
            for (int row = 0; row < Grid.GetLength(0); row++)
            {
                for (int col = 0; col < Grid.GetLength(1); col++)
                {
                    Grid[row, col] = new Cell(col, row, false, liveCells[liveCellSeedIdx], 0);
                    liveCellSeedIdx++;
                }
            }

            // Make a second pass over the Grid and calculate all live neighbors for each cell
            CalculateLiveNeighbors();
        }

        public void CalculateLiveNeighbors()
        {
            // Create 2D array to calculate which cells are live/dead
            //Random rand = new Random();
            //bool[] liveCells = new bool[] {};

            //int liveCellSeedIdx = 0;
            for (int row = 0; row < Grid.GetLength(0); row++)
            {
                for (int col = 0; col < Grid.GetLength(1); col++)
                {
                    calculateLiveCellNeighbors(Grid[row, col]);
                }
            }
        }

        private void calculateLiveCellNeighbors(Cell c)
        {
            // Set to 0 automatically, per rules, if cell itself is live
            if (c.Live)
            {
                c.LiveNeighbors = 9;
                return;
            }

            // test if any array index is going to cause out-of-bounds errs
            // If it would, just add a default (!Live)
            Cell def = new Cell(0, 0, false, false, 0);
            Cell left = (c.Column - 1 >= 0) ? Grid[c.Row, c.Column - 1] : def;
            Cell right = (c.Column + 1 < Size) ? Grid[c.Row, c.Column + 1] : def;
            Cell top = (c.Row - 1 >= 0) ? Grid[c.Row - 1, c.Column] : def;
            Cell bottom = (c.Row + 1 < Size) ? Grid[c.Row + 1, c.Column] : def;
            Cell topRight = (c.Row - 1 >= 0 && c.Column + 1 < Size) ? Grid[c.Row - 1, c.Column + 1] : def;
            Cell topLeft = (c.Row - 1 >= 0 && c.Column - 1 >= 0) ? Grid[c.Row - 1, c.Column - 1] : def;
            Cell bottomRight = (c.Row + 1 < Size && c.Column + 1 < Size) ? Grid[c.Row + 1, c.Column + 1] : def;
            Cell bottomLeft = (c.Row + 1 < Size && c.Column - 1 >= 0) ? Grid[c.Row + 1, c.Column - 1] : def;

            int liveNeighbors = 0;
            foreach(Cell neighbor in new Cell[] { left, right, top, bottom, topRight, topLeft, bottomRight, bottomLeft })
            {
                liveNeighbors += neighbor.Live ? 1 : 0;
            }
            c.LiveNeighbors = liveNeighbors;
        }
    }
}
