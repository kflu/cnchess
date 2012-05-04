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
        SideType side;
        Piece[] pieces;
        Jiang jiang;
        private Game game;

        public Side(Game game)
        {
            this.game = game;

            // Initialize pieces
            this.pieces = (from piece in this.game.Pieces where piece.Side == this select piece).ToArray();
            Debug.Assert(pieces.Length == 16);
            this.jiang = (Jiang)(from p in this.pieces where p.GetType() == jiang.GetType() select p).First();
        }
        
        public void Move(Piece piece, Point targetLocation) { }

    }
}
