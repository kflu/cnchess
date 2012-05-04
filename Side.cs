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
        public SideType side;
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
        
        public void Move(Piece piece, Point targetLocation) { }

    }
}
