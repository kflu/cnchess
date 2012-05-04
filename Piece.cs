using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChineseChessLib
{
    abstract class Piece
    {
        protected Game Game;
        public Point Location;
        public bool IsAlive;
        abstract public void Move(Point target);
        abstract public bool IsValidMove(Point target);
        public Side Side;
    }
}
