using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimax.Tictactoe
{
    /// <summary>
    /// Represents a board to TicTacToe game.
    /// </summary>
    public class Board
    {
        private CellContent[] cells;

        public Board()
        {
            cells = new CellContent[9];
        }

        public void Set(Cells cell, CellContent content)
        {
            cells[(int)cell] = content;
        }

        public IEnumerable<Cells> EmptyCells()
        {
            List<Cells> emptyCells = new List<Cells>();

            for (int index = 0; index < cells.Length; index++)
            {
                if (cells[index] == CellContent.Empty)
                {
                    emptyCells.Add((Cells)index);
                }
            }

            return emptyCells;
        }
    }
}
