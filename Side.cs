using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using ChineseChessLib.Pieces;

namespace ChineseChessLib
{
    class Side
    {
        public SideType sideType;
        Piece[] pieces;
        Jiang jiang;
        private Game game;
        public Side Opponent;

        public Side(Game game)
        {
            this.game = game;

            // Initialize pieces
            this.pieces = (from piece in this.game.Pieces where piece.Side == this select piece).ToArray();
            Debug.Assert(pieces.Length == 16);
            this.jiang = (Jiang)(from p in this.pieces where p.GetType() == jiang.GetType() select p).First();

            // Initialize Oppopent
            int i = Array.IndexOf(this.game.Sides, this);
            this.Opponent = this.game.Sides[Math.Abs(1 - i)]; // this = 1 then opponent = 0, and vice versa
        }

        public bool PointInAttackRange(Point point)
        {
            foreach (var piece in this.pieces)
            {
                if (!piece.IsAlive) continue;
                if (piece.PointInAttackRange(point))
                    return true;
            }
            return false;
        }

        public void Move(Piece piece, Point targetLocation)
        {
            this.game.Board.Move(piece, targetLocation);
        }

        /// <summary>
        /// Transform the position specified as if the player is bottom to the absolute position
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Point AbsolutePosition(Point p)
        {
            if (this.sideType == SideType.Bottom) return p;
            int x = Board.NumRows - p.X - 1;
            int y = Board.NumCols - p.Y - 1;
            return new Point(x, y);
        }

    }
}
