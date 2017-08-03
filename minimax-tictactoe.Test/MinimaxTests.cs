using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimax.Tictactoe;

namespace minimax_tictactoe.Test
{
    [TestClass]
    public class MinimaxTests
    {
        [TestMethod]
        public void WhenOnlyLowerLeftCellIsOpenAlgChooseThatCell()
        {
            Board b = BoardBuilder.FromString(
                "XOX",
                "OXO",
                "OX-");
            MiniMaxTictactoeAlg alg = new MiniMaxTictactoeAlg();
            PossibleMoves possibleMoves = alg.PossibleMoves(b, Player.X);
            Assert.AreEqual(1, possibleMoves.Count);
            Assert.AreEqual(8, possibleMoves[0].CellIndex);
        }

        [TestMethod]
        public void WhenOnlyMiddleCellIsOpenAlgChooseThatCell()
        {
            Board b = BoardBuilder.FromString(
                "XOX",
                "O-O",
                "OXO");
            MiniMaxTictactoeAlg alg = new MiniMaxTictactoeAlg();
            PossibleMoves possibleMoves = alg.PossibleMoves(b, Player.X);
            Assert.AreEqual(1, possibleMoves.Count);
            Assert.AreEqual(4, possibleMoves[0].CellIndex);
        }

        [TestMethod]
        public void WinningMoveHasHigherScoreThanTie()
        {
            Board b = BoardBuilder.FromString(
                "XOO",
                "XXO",
                "-X-");
            MiniMaxTictactoeAlg alg = new MiniMaxTictactoeAlg();
            PossibleMoves possibleMoves = alg.PossibleMoves(b, Player.O);
            Assert.AreEqual(2, possibleMoves.Count);
            Assert.AreEqual(8, possibleMoves[0].CellIndex);
            Assert.AreEqual(6, possibleMoves[1].CellIndex);
            Assert.IsTrue(possibleMoves[0].Score > possibleMoves[1].Score, "Winning move should have higher score than tie move");
        }
    }
}
