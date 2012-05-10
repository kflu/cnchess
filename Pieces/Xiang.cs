using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChineseChessLib.Pieces
{
    class Xiang : Piece
    {
        public const Point[] InitialRelativePositions = new Point[] { new Point(0, 2), new Point(0, 6) };
        public Xiang(Game game, Side side) : base(game, side) { }

        public override bool IsValidMove(Point target)
        {
            throw new NotImplementedException();
        }

        public override bool PointInAttackRange(Point point)
        {
            throw new NotImplementedException();
        }

        public override void InitPosition()
        {
            throw new NotImplementedException();
        }
    }
}
