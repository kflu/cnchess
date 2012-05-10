using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChineseChessLib.Pieces
{
    class Ma : Piece
    {
        public const Point[] InitialRelativePositions = new Point[] { new Point(0, 1), new Point(0, 7) };
        public Ma(Game game, Side side) : base(game, side) { }

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
