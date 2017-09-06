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
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <returns></returns>
        public static Board FromString(string v1, string v2, string v3)
        {
            return new Board();
        }
    }
}
