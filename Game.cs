using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

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
            this.InitBoard();
        }

        private void InitPieces()
        {
            foreach (Type pieceType in new Type[] { 
                typeof(Jiang), typeof(Shi), typeof(Xiang), 
                typeof(Ma), typeof(Ju), typeof(Pao), typeof(Zu) })
            {
                int numOfPieces = 
                    (int)pieceType.GetField("NumOfPieces", BindingFlags.Static).GetValue(null);
                Point[] InitPositions = 
                    (Point[])pieceType.GetField("RelativeInitialPositions", BindingFlags.Static).GetValue(null);
                // TODO
            }
        }

        public void Move(Piece piece, Point targetLocation)
        {
            System.Diagnostics.Debug.Assert(
                piece.IsValidMove(targetLocation));

            if (this.Board[targetLocation] != null)
            {
                this.Board[targetLocation].IsAlive = false;
            }
            piece.Location = targetLocation;
        }
    }
}
