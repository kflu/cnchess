using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChineseChessLib.Pieces
{
    class Pao : Piece
    {
        public const Point[] InitialRelativePositions = new Point[] { new Point(2, 1), new Point(2, 7) };
        public Pao(Game game, Side side) : base(game, side) { }

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
