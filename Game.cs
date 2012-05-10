using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using ChineseChessLib.Pieces;
namespace ChineseChessLib
{
    class Game
    {
        public Board Board;
        public Side[] Sides;
        public Piece[] Pieces;
        public SideType WhosFirst = SideType.Bottom;
        public SideType WhosTurn;

        public Game()
        {
            this.Board = new Board(this);
            this.Sides = new Side[] { new Side(this), new Side(this) };
            this.Sides[0].sideType = SideType.Bottom;
            this.Sides[1].sideType = SideType.Top;
            this.InitPieces();
            this.InitBoard();
            this.WhosTurn = this.WhosFirst;
        }

        /// <summary>
        /// Instantiates the board object and sets the board table's initial state
        /// </summary>
        private void InitBoard()
        {
            Board board = new Board(this);
            board.UpdatePiecePositionOnBoard();
        }

        /// <summary>
        /// Instantiate pieces and set their initial position
        /// </summary>
        private void InitPieces()
        {
            int i = 0;
            foreach (Type pieceType in new Type[] { 
                typeof(Jiang), typeof(Shi), typeof(Xiang), 
                typeof(Ma), typeof(Ju), typeof(Pao), typeof(Zu) })
            {
                Point[] initPositions = 
                    (Point[])pieceType.GetField("RelativeInitialPositions", BindingFlags.Static).GetValue(null);
                foreach (var side in this.Sides)
                {
                    foreach (var position in initPositions)
                    {
                        Piece piece = (Piece)Activator.CreateInstance(pieceType, this, side);
                        piece.Position = side.AbsolutePosition(position);
                        this.Pieces[i] = piece;
                        i++;
                    }
                }
            }
            System.Diagnostics.Debug.Assert(i == 32,
                string.Format("Actual number of pieces to be {0}", i));
        }

        public void Move(Piece piece, Point targetLocation)
        {
            if (piece.Side.sideType != this.WhosTurn)
            {
                throw new InvalidMoveException(
                    string.Format("Its not {0}'s turn to move.", piece.Side.sideType));
            }

            if (piece.IsValidMove(targetLocation))
            {
                throw new InvalidMoveException("Not an invalid move.");
            }

            if (this.Board[targetLocation] != null)
            {
                this.Board[targetLocation].IsAlive = false;
            }
            piece.Position = targetLocation;

            // judge if it wins
            // TODO...
        }
    }
}
