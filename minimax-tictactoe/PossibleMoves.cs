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
        /// <summary>
        /// Get the number of possible moves.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Get a specific possible move.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public PossibleMove this[int index]
        {
            get { return null; }
        }
    }
}
