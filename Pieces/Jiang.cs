using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChineseChessLib.Pieces
{
    class Jiang : Piece
    {
        public const Point[] InitialRelativePositions = new Point[] { new Point(0, 4) };

        public Jiang(Game game, Side side) : base(game, side) { }

        public override bool IsValidMove(Point target)
        {
            Point[] jiugong = this.Side.sideType == SideType.Bottom ?
                Board.BottomJiuGong : Board.TopJiuGong;
            if (!jiugong.Contains(target)) return false;
            if (target.Equals(this.Position)) return false;

            // * can horizontally or vertically move 1 position
            // * the target position must NOT be under attack
            if (((target.X == this.Position.X && Math.Abs(target.Y - this.Position.Y) == 1)
                || (target.Y == this.Position.Y && Math.Abs(target.X - this.Position.X) == 1))
                && !this.Side.Opponent.PointInAttackRange(target))
                return true;
            //otherwise...
            return false;
        }

        public override bool PointInAttackRange(Point point)
        {
            throw new NotImplementedException();
        }

        public override void InitPosition()
        {
            this.Position = this.Side.AbsolutePosition(new Point(0, 5));
        }
    }
}
