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

            // find all empty cells
            foreach (Cells cell in b.EmptyCells())
            {
                // create possible move from each one
                moves.Add(new PossibleMove(cell, 1));
            }

            return moves;
        }

    }
}
