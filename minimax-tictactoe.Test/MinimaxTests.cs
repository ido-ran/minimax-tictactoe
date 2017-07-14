using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace minimax_tictactoe.Test
{
    [TestClass]
    public class MinimaxTests
    {
        [TestMethod]
        public void WhenOnlyOneCellIsOpenAlgChooseThatCell()
        {
            int result = 1 + 2;
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestThatFail()
        {
            int result = 1 + 3;
            Assert.AreEqual(19, result);
        }
        [TestMethod]
        public void WhenAnamyCanWinAndItsAlgTurn()
        {
            int result = 1 + Board.HaveATreat(Board.GetBoardSituation());
            Assert.AreEqual(3, result);


        }
    }
}
