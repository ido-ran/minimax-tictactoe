using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimax.Tictactoe
{
    /// <summary>
    /// A collection of possible moves sorted by their score.
    /// </summary>
    public class PossibleMoves
    {
        private List<PossibleMove> moves = new List<PossibleMove>();

        /// <summary>
        /// Get the number of possible moves.
        /// </summary>
        public int Count
        {
            get
            {
                return moves.Count;
            }
        }

        /// <summary>
        /// Get a specific possible move.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public PossibleMove this[int index]
        {
            get { return moves[index]; }
        }

        internal void Add(PossibleMove possibleMove)
        {
            moves.Add(possibleMove);
        }
    }
}
