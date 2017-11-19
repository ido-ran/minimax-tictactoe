﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimax.Tictactoe
{
    /// <summary>
    /// Represents a board to TicTacToe game.
    /// </summary>
    /// 

    public class Board
    {
        private CellContent[] cells;

        public Board()
        {
            cells = new CellContent[9];
        }

        public void Set(Cells cell, CellContent content)
        {
            cells[(int)cell] = content;
        }

        public IEnumerable<Cells> EmptyCells()
        {
            List<Cells> emptyCells = new List<Cells>();

            for (int index = 0; index < cells.Length; index++)
            {
                if (cells[index] == CellContent.Empty)
                {
                    emptyCells.Add((Cells)index);
                }
            }

            return emptyCells;
        }

        private IEnumerable<Cells> PlayerCellS(CellContent playerType)
        {
            List<Cells> cells = new List<Cells>();
            for (int index = 0; index < this.cells.Length; index++)
            {
                if (this.cells[index] == playerType)
                {
                    cells.Add((Cells)index);
                }
            }
            return cells;
        }

        public IEnumerable<Cells> XCells()
        {
            return (PlayerCellS(CellContent.X));
        }

        public IEnumerable<Cells> OCells()
        {
            return (PlayerCellS(CellContent.O));
        }

        public bool IsTheLastMoveHaveWon(Cells theLastMove)
        {

            DiractionRecord[] diractionMatrix = new[]
            {
                new DiractionRecord() { row1 =1,col1=1,row2=-1,col2=-1,checkDiagonal =true},
                new DiractionRecord() { row1 =1,col1=-1,row2=-1,col2=1,checkDiagonal =true},
                new DiractionRecord() { row1 =0,col1=1,row2=0,col2=-1,checkDiagonal =false},
                new DiractionRecord() { row1 =1,col1=0,row2=-1,col2=0,checkDiagonal =false},
            };

            int row = (int)theLastMove / 3;
            int col = (int)theLastMove % 3;
            foreach (var dir in diractionMatrix)
            {
                if (!dir.checkDiagonal || dir.checkDiagonal)
                {
                    if (dir.Contains(theLastMove) == "left")
                    {

                    }
                    else if (dir.Contains(theLastMove) == "right")
                    {

                    }
                    int cell1Row = (row + dir.row1) % 3;
                    int cell1Col = (col + dir.col1) % 3;
                    Cells cell1 = (Cells)(cell1Row * 3 + cell1Col);

                    int cell2Row = (row + dir.row2) % 3;
                    int cell2Col = (col + dir.col2) % 3;
                    Cells cell2 = (Cells)(cell2Row * 3 + cell2Col);

                    CellContent LastContent = cells[(int)theLastMove];
                    CellContent cell1Content = cells[(int)cell1];
                    CellContent cell2Content = cells[(int)cell2];

                    if(LastContent == cell1Content && LastContent == cell2Content)
                    {
                        return true;
                    }

                }

            }

            return false;
        }

        private class DiractionRecord
        {
            public int row1, row2, col1, col2;
            public bool checkDiagonal;

            public string Contains(Cells cell)
            {
                if((int)cell == 4)
                {
                    return "left and right";
                }
                if ((int)cell == 2 || (int)cell == 6)
                {
                    return "left";
                }
                else if((int)cell == 0 || (int)cell == 8)
                {
                    return "right";
                }
                else
                {
                    return "not Diagonal";
                }
            }


        }

    }

}
