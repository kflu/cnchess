using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChineseChessLib
{
    abstract class Piece
    {
        protected Game Game;
        public Point Position;
        public bool IsAlive;
        public Side Side;
        abstract public bool IsValidMove(Point target);
        abstract public bool PointInAttackRange(Point point);
        
        public Piece(Game game, Side side)
        {
            this.Game = game;
            this.Side = side;
        }
    }
}
