using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.Structure
{
    class StringGrid
    {
        private string[,] ioStringGrid;

        private string[,] printStringGrid;

        public int RowCount => ioStringGrid.GetLength(0);

        public int ColCount => ioStringGrid.GetLength(1);

        public StringGrid(int colCount, int rowCount)
        {
            ioStringGrid = new string[rowCount, colCount];
            printStringGrid = new string[rowCount, colCount];
        }

        public string this[int row, int col]
        {
            get => ioStringGrid[row, col] ?? "";
            set => ioStringGrid[row, col] = value;
        }

        public override string ToString()
        {
            for (int col = 0; col < ColCount; col++)
            {
                int maxStrWidth = 0;
                for (int row = 0; row < RowCount; row++)
                    if (this[row, col].Length > maxStrWidth)
                        maxStrWidth = this[row, col].Length;

                for (int row = 0; row < RowCount; row++)
                    printStringGrid[row, col] = this[row, col].PadLeft(maxStrWidth);
            }

            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < RowCount; row++)
            {
                for (int col = 0; col < ColCount; col++)
                {
                    sb.Append(printStringGrid[row, col] + "|");
                }
                sb.Append("\r\n");
            }

            return sb.ToString();
        }

    }
}
