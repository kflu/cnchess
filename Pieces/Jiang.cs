using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChineseChessLib.Pieces
{
    class Jiang : Piece
    {
        public Jiang(Game game)
        {
            this.Game = game;
        }

        public override bool IsValidMove(Point target)
        {
            Point[] jiugong = this.Side.side == SideType.Bottom ?
                this.Game.Board.BottomJiuGong : this.Game.Board.TopJiuGong;
            if (!jiugong.Contains(target)) return false;
            if (target.Equals(this.Location)) return false;

            // * can horizontally or vertically move 1 position
            // * the target position must NOT be under attack
            if (((target.X == this.Location.X && Math.Abs(target.Y - this.Location.Y) == 1)
                || (target.Y == this.Location.Y && Math.Abs(target.X - this.Location.X) == 1))
                && !this.Side.Opponent.PointInAttackRange(target))
                return true;
            //otherwise...
            return false;
        }

        public override bool PointInAttackRange(Point point)
        {
            Point[] jiugong = this.Side.side == SideType.Bottom ?
                this.Game.Board.BottomJiuGong : this.Game.Board.TopJiuGong;
            if (!jiugong.Contains(point)) return false;
            // TODO
        }
    }
}
