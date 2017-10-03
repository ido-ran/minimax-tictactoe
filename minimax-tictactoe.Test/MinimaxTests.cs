using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimax.Tictactoe;
using System;
using System.Collections.Generic;

namespace minimax_tictactoe.Test
{
    [TestClass]
    public class MinimaxTests
    {
        [TestMethod]
        public void WhenOnlyLowerLeftCellIsOpenAlgChooseThatCell()
        {
            Board b = BoardBuilder.FromString(
                "XOX" +
                "OXO" +
                "OX-");
            MiniMaxTictactoeAlg alg = new MiniMaxTictactoeAlg();
            PossibleMoves possibleMoves = alg.PossibleMoves(b, Player.X);
            Assert.AreEqual(1, possibleMoves.Count);
            Assert.AreEqual(Cells.BottomRight, possibleMoves[0].CellIndex);
        }

        [TestMethod]
        public void WhenOnlyMiddleCellIsOpenAlgChooseThatCell()
        {
            Board b = BoardBuilder.FromString(
                "XOX" +
                "O-O" +
                "OXO");
            MiniMaxTictactoeAlg alg = new MiniMaxTictactoeAlg();
            PossibleMoves possibleMoves = alg.PossibleMoves(b, Player.X);
            Assert.AreEqual(1, possibleMoves.Count);
            Assert.AreEqual(Cells.CenterMiddle, possibleMoves[0].CellIndex);
        }

        [TestMethod]
        public void WinningMoveHasHigherScoreThanTie()
        {
            Board b = BoardBuilder.FromString(
                "XOO" +
                "XXO" +
                "-X-");
            MiniMaxTictactoeAlg alg = new MiniMaxTictactoeAlg();
            PossibleMoves possibleMoves = alg.PossibleMoves(b, Player.O);
            Assert.AreEqual(2, possibleMoves.Count);
            Assert.AreEqual(Cells.BottomLeft, possibleMoves[0].CellIndex);
            Assert.AreEqual(Cells.BottomRight, possibleMoves[1].CellIndex);
            Assert.IsTrue(possibleMoves[0].Score > possibleMoves[1].Score, "Winning move should have higher score than tie move");
        }
    }
}
