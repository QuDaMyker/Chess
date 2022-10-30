using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessFull
{
    public class Board
    {
        public const int Default_Square_Width = 100;
        public const int Default_Square_Height = 100;

        protected Square[,] _squares;
        protected int _squareWidth;
        protected int _squareHeight;

        public Form ParentForm { get; set; }
        public Board(Form parentForm, int squareWidth = Default_Square_Width, int squareHeight = Default_Square_Height)
        {
            _squares = new Square[10, 10];
            _squareWidth = squareWidth;
            _squareHeight = squareHeight;
            ParentForm = parentForm;

            init();
        }
        public void init()
        {
            int left = 0;
            int top = 20;
            SquareColor c = SquareColor.White;
            for (int i = 1; i < 9; i++)
            {
                left = 45;
                for (int j = 1; j < 9; j++)
                {
                    Square sq = new Square(_squares, c, this);
                    sq.Size = new System.Drawing.Size(_squareWidth, _squareHeight);
                    sq.Left = left;
                    sq.Top = top;

                    left += _squareWidth;
                    if(c == SquareColor.White)
                    {
                        c = SquareColor.Black;
                    }
                    else
                    {
                        c = SquareColor.White;
                    }

                    _squares[i, j] = sq;
                    ParentForm.Controls.Add(sq);
                }
                top += _squareHeight;
                if (c == SquareColor.White)
                {
                    c = SquareColor.Black;
                }
                else
                {
                    c = SquareColor.White;
                }
            }

            this[0, 0] = new Rook(_squares[0, 0], PieceColor.White);
            this[7,0] = new Rook(_squares[0,7], PieceColor.Black);

            this[0, 1] = new Knight(_squares[0, 1], PieceColor.White);
            this[7, 1] = new Knight(_squares[0, 0], PieceColor.Black);

            this[0, 2] = new Bishop(_squares[0, 2], PieceColor.White);
            this[7, 2] = new Bishop(_squares[7, 2], PieceColor.Black);

            this[0, 3] = new Queen(_squares[0, 3], PieceColor.White);
            this[7, 3] = new Queen(_squares[7, 3], PieceColor.Black);

            this[0, 4] = new King(_squares[0, 4], PieceColor.White);
            this[7, 4] = new King(_squares[7, 4], PieceColor.Black);

            this[0, 5] = new Bishop(_squares[0, 5], PieceColor.White);
            this[7, 5] = new Bishop(_squares[7, 5], PieceColor.Black);

            this[0, 6] = new Knight(_squares[0, 6], PieceColor.White);
            this[7, 6] = new Knight(_squares[7, 6], PieceColor.Black);

            this[0, 7] = new Rook(_squares[0, 7], PieceColor.White);
            this[7, 7] = new Rook(_squares[7, 7], PieceColor.Black);

            for (int i = 0; i < 8; i++)
            {
                this[1, i] = new Pawn(_squares[1, i], PieceColor.White);
            }
            for (int j = 0; j < 8; j++) 
            {
                this[6, j] = new Pawn(_squares[6, j], PieceColor.Black);
            }
            
        }

        protected Square _selectedSquare;
        public Square SelectedSquare
        {
            get { return _selectedSquare; }
            set
            {
                if(_selectedSquare != null)
                {
                    _selectedSquare.Selected = false;
                }
                _selectedSquare = value;
            }
        }
        public Piece this[int i, int j]
        {
            get { return _squares[i, j].Piece; }
            set { _squares[i, j].Piece = value; }
        }
    }
}
