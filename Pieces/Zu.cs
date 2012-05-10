using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChineseChessLib.Pieces
{
    class Zu : Piece
    {
        public const Point[] InitialRelativePositions = new Point[] { 
            new Point(3, 0),
            new Point(3, 2),
            new Point(3, 4),
            new Point(3, 6),
            new Point(3, 8),
        };

        public Zu(Game game, Side side) : base(game, side) { }

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
