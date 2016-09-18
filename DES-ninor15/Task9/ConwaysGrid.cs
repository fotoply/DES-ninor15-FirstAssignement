using System;
using System.Text;

namespace DES_ninor15.Task9
{
    public class ConwaysGrid
    {
        private Cell[][] Cells;
        private int GridWidth;
        private int GridHeight;

        public ConwaysGrid(int gridWidth, int gridHeight)
        {
            GridWidth = gridWidth;
            GridHeight = gridHeight;
            Cells = new Cell[GridWidth][];
            for (int i = 0; i < GridWidth; i++)
            {
                Cells[i] = new Cell[GridHeight];
            }
        }

        public void InitializeRandomState()
        {
            Random rnd = new Random();
            for (int x = 0; x < GridWidth; x++)
            {
                for (int y = 0; y < GridHeight; y++)
                {
                    Cells[x][y] = new Cell();

                    if (rnd.Next(2) == 1)
                    {
                        GetCell(x, y).Revive();
                    }
                    else
                    {
                        GetCell(x, y).Kill();
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder state = new StringBuilder(GridWidth*GridHeight);
            foreach (Cell[] subCellsArray in Cells)
            {
                foreach (Cell cell in subCellsArray)
                {
                    if (cell.IsAlive)
                    {
                        state.Append("*");
                    }
                    else
                    {
                        state.Append("-");
                    }
                }
                state.AppendLine();
            }
            return state.ToString();
        }

        public Cell[][] Tick()
        {
            Cell[][] newStatus = new Cell[GridWidth][];
            for (int x = 0; x < GridWidth; x++)
            {
                newStatus[x] = new Cell[GridHeight];
                for (int y = 0; y < GridHeight; y++)
                {
                    newStatus[x][y] = new Cell();
                    newStatus[x][y].IsAlive = GetCellStatus(x, y);
                }
            }
            Cells = newStatus;
            return Cells;
        }

        private bool GetCellStatus(int x, int y)
        {
            int neighbors = CountNeighbors(x, y);
            return GetCell(x, y).GetStatusForNeighborCount(neighbors);
        }

        private Cell GetCell(int x , int y )
        {
            if (IsOutsideGrid(x,y))
            {
                throw new CustomLifeException("Was outside of bounds");
            }
            return Cells[x][y];
        }

        private bool IsOutsideGrid(int x, int y)
        {
            return x >= GridWidth || y >= GridHeight || x < 0 || y < 0;
        }

        private int CountNeighbors(int x, int y)
        {
            int neighbors = 0;
            for (int xOffset = -1; xOffset < 2; xOffset++)
            {
                for (int yOffset = -1; yOffset < 2; yOffset++)
                {
                    if (xOffset == 0 && yOffset == 0)
                    {
                        continue;
                    }

                    if (!IsOutsideGrid(x + xOffset, y + yOffset))
                    {
                        if (GetCell(x + xOffset, y + yOffset).IsAlive)
                        {
                            neighbors++;
                        }
                    }
                }
            }

            return neighbors;
        }
    }
}