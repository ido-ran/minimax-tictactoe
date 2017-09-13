using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimax.Tictactoe
{
    /// <summary>
    /// Responsible for building a <see cref="Minimax.Tictactoe.Board" /> instance.
    /// </summary>
    public class BoardBuilder
    {
        /// <summary>
        /// Building Board instance from three strings represents one row each.
        /// </summary>
        /// <param name="boardString"></param>
        /// <returns></returns>
        public static Board FromString(string boardString)
        {
            Board board = new Board();

            for (int index = 0; index < boardString.Length; index++)
            {
                CellContent content;
                char c = boardString[index];
                switch (c)
                {
                    case 'X':
                        content = CellContent.X;
                        break;

                    case 'O':
                        content = CellContent.O;
                        break;

                    default:
                        content = CellContent.Empty;
                        break;
                }

                board.Set((Cells)index, content);
            }

            return board;
        }
    }
}
