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
            this.UpdateBoard();
        }

        private void InitBoard()
        {
            this.boardTable = new Piece[10,9];
            this.InitPieces();
        }

        private void InitPieces()
        {
            // TODO;
        }

        private void UpdateBoard()
        {
            foreach (var piece in this.game.Pieces)
            {
                int x = piece.Location.X;
                int y = piece.Location.Y;
                this.boardTable[x,y] = piece;
            }
        }

        public void Move(Piece piece, Point targetLocation)
        {
            System.Diagnostics.Debug.Assert(
                piece.IsValidMove(targetLocation));

            if (this[targetLocation] != null)
            {
                this[targetLocation].IsAlive = false;
            }
            piece.Location = targetLocation;
        }

        public bool IsValidMove(Piece piece, Point targetLocation)
        {
            return piece.IsValidMove(targetLocation);
        }

        public Point[] BottomJiuGong = new Point[] {
            new Point(0, 3),
            new Point(0, 4),
            new Point(0, 5),
            new Point(1, 3),
            new Point(1, 4),
            new Point(1, 5),
            new Point(2, 3),
            new Point(2, 4),
            new Point(2, 5)};

        public Point[] TopJiuGong = new Point[] {
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
