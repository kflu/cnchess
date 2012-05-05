using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ChineseChessLib.Pieces;
namespace ChineseChessLib
{
    class Game
    {
        public Board Board;
        public Side[] Sides;
        public Side Top;
        public Side Bottom;
        public Piece[] Pieces;

        public Game()
        {
            this.Board = new Board(this);
            this.Sides = new Side[] { new Side(this), new Side(this) };
            this.Sides[0].side = SideType.Bottom;
            this.Sides[1].side = SideType.Top;
            this.Top = this.Sides[0];
            this.Bottom = this.Sides[1];
            this.InitPieces();
        }

        public void InitPieces()
        {
            this.Pieces = new Piece[32];
            foreach (int i in new int[] { 0, 1 })
            {
            }
            
            
        }
    }
}
