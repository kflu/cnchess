using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChineseChessLib
{
    class Board
    {
        Game game;
        private Piece[,] boardTable = new Piece[10,9];

        public Piece this[int x, int y]
        {
            get
            {
                return this.boardTable[x, y];
            }
            private set
            {
                this.boardTable[x, y] = value;
            }
        }

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
            this.UpdateBoard();
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

    }
}
