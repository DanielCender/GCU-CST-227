using System;
namespace ChessBoardModel
{
    public class Board
    {
        public int Size { get; set; }
        public Cell[,] theGrid { get; set; }
        public Board(int s)
        {
            Size = s;
            theGrid = new Cell[s, s];
            for(int i = 0; i < s; i++)
            {
                for(int j = 0; j < s; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public Board()
        {
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            // Clear all legal moves from board
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                }
            }

            // Re-calculate all new legal moves
            switch(chessPiece)
            {
                case "Knight":
                    if(CheckValidSpace(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1)) theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if(CheckValidSpace(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1)) theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if(CheckValidSpace(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2)) theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if(CheckValidSpace(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2)) theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    if(CheckValidSpace(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1)) theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if(CheckValidSpace(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1)) theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if(CheckValidSpace(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2)) theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    if(CheckValidSpace(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2)) theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    break;
                case "King":
                    // Check all omni-directions top -> top-left, clockwise
                    if (CheckValidSpace(currentCell.RowNumber - 1, currentCell.ColumnNumber)) theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (CheckValidSpace(currentCell.RowNumber, currentCell.ColumnNumber + 1)) theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (CheckValidSpace(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1)) theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    if (CheckValidSpace(currentCell.RowNumber + 1, currentCell.ColumnNumber)) theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    if (CheckValidSpace(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1)) theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (CheckValidSpace(currentCell.RowNumber, currentCell.ColumnNumber - 1)) theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    if (CheckValidSpace(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1)) theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    break;
                case "Rook":
                    // Check all directions up to edge of grid
                    MarkValidRookSpaces(currentCell);
                    break;
                case "Bishop":
                    // Check all diagonal directions up to edge of grid
                    MarkValidBishopSpaces(currentCell);
                    break;
                case "Queen":
                    // Just a blend of the Rook and Bishop's abilities
                    MarkValidRookSpaces(currentCell);
                    MarkValidBishopSpaces(currentCell);
                    break;
                default:
                    break;
            }


        }

        public bool CheckValidSpace(int r, int c)
        {
            // Check if row and column settings are within the grid
            return (r < theGrid.GetLength(0) && r >= 0) && (c < theGrid.GetLength(1) && c >= 0);
        }


        public void MarkValidRookSpaces(Cell current)
        {
            // Check all directions up to edge of grid
            int col = current.ColumnNumber;
            int row = current.RowNumber;

            // Right
            for (int s = col; s < Size; s++)
            {
                if (CheckValidSpace(row, s)) theGrid[row, s].LegalNextMove = true;
            }
            // Left
            for (int s = col; s >= 0; s--)
            {
                if (CheckValidSpace(row, s)) theGrid[row, s].LegalNextMove = true;
            }
            // Top
            for (int s = row; s >= 0; s--)
            {
                if (CheckValidSpace(row, s)) theGrid[s, col].LegalNextMove = true;
            }
            // Bottom
            for (int s = row; s < Size; s++)
            {
                if (CheckValidSpace(row, s)) theGrid[s, col].LegalNextMove = true;
            }
        }

        public void MarkValidBishopSpaces(Cell current)
        {
            // Check all directions up to edge of grid
            int col = current.ColumnNumber;
            int row = current.RowNumber;

            // Top Right
            for (int s = row; s >= 0; s--)
            {
                if (CheckValidSpace(s, col + (current.RowNumber - s))) theGrid[s, col + (current.RowNumber - s)].LegalNextMove = true;
            }
            // Top Left
            for (int s = row; s >= 0; s--)
            {
                if (CheckValidSpace(s, col - (current.RowNumber - s))) theGrid[s, col - (current.RowNumber - s)].LegalNextMove = true;
            }
            // Bottom Right
            for (int s = row; s < Size; s++)
            {
                if (CheckValidSpace(s, col + (current.RowNumber - s))) theGrid[s, col + (current.RowNumber - s)].LegalNextMove = true;
            }
            // Bottom Left
            for (int s = row; s < Size; s++)
            {
                if (CheckValidSpace(s, col - (current.RowNumber - s))) theGrid[s, col - (current.RowNumber - s)].LegalNextMove = true;
            }
        }
    }
}
