using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChineseChessLib
{
    class Board
    {
        public const int NumRows = 10;
        public const int NumCols = 9;
        Game game;
        private Piece[,] boardTable;

        public Piece this[Point location]
        {
            get
            {
                return this.boardTable[location.X, location.Y];
            }
            private set
            {
                this.boardTable[location.X, location.Y] = value;
            }
        }

        public Board(Game game)
        {
            this.game = game;
            this.InitBoard();
            this.UpdatePiecePositionOnBoard();
        }

        private void InitBoard()
        {
            this.boardTable = new Piece[10,9];
        }

        public void UpdatePiecePositionOnBoard()
        {
            foreach (var piece in this.game.Pieces)
            {
                int x = piece.Position.X;
                int y = piece.Position.Y;
                this.boardTable[x,y] = piece;
            }
        }

        public const Point[] BottomJiuGong = new Point[] {
            new Point(0, 3),
            new Point(0, 4),
            new Point(0, 5),
            new Point(1, 3),
            new Point(1, 4),
            new Point(1, 5),
            new Point(2, 3),
            new Point(2, 4),
            new Point(2, 5)};

        public const Point[] TopJiuGong = new Point[] {
            new Point(7, 3),
            new Point(7, 4),
            new Point(7, 5),
            new Point(8, 3),
            new Point(8, 4),
            new Point(8, 5),
            new Point(9, 3),
            new Point(9, 4),
            new Point(9, 5)};
    }
}
