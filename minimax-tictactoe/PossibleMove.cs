using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimax.Tictactoe
{
    /// <summary>
    /// Represents one possible move in TicTacToe game.
    /// </summary>
    public class PossibleMove
    {
        /// <summary>
        /// Zero based cell index.
        /// </summary>
        public Cells CellIndex { get; set; }

        /// <summary>
        /// The score of the move. Higher is better.
        /// </summary>
        public int Score { get; set; }
    }
}
