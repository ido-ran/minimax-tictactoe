using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimax.Tictactoe
{
    /// <summary>
    /// Represents Minimax algorithm for TicTacToe game.
    /// </summary>
    public class MiniMaxTictactoeAlg
    {
        /// <summary>
        /// Calculate the possible next moves for the specificed board and player.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public PossibleMoves PossibleMoves(Board b, Player player)
        {
            PossibleMoves moves = new PossibleMoves();
            moves.Add(new PossibleMove(Cells.BottomRight, 50));
            return moves;
        }

    }
}
