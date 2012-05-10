using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChineseChessLib
{
    class Ju : Piece
    {
        public const Point[] InitialRelativePositions = new Point[] { new Point(0, 0), new Point(0, 8) };
        public Ju(Game game, Side side) : base(game, side) { }

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
            
        }
    }
}
