using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessFull
{
    public enum SquareColor { White, Black};
    public class Square : PictureBox
    {
        public int currentRowNumber { get; set; }
        public int nextRowNumber { get; set; }
        public int currentColumnNumber { get; set; }
        public int nextColumnNumber { get; set; }
        public bool currentOccupied { get; set; }
        public bool LegalNextMove { get; set; }

        protected Piece _piece;
        public Piece Piece
        {
            get { return _piece; }
            set
            {
                _piece = value;
                if(_piece != null)
                {
                    Image = _piece.Image;
                }
                else
                {
                    Image = null;
                }
            }
        }

        public Square(int x, int y)
        {
            currentRowNumber = x;
            currentColumnNumber = y;
        }
        protected Board _board;
        protected Boolean _selected;
        public Boolean Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                if (value == true)
                {
                    _board.SelectedSquare = this;
                    BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    Color = _color;
                }
            }
        }
        
        

        protected SquareColor _color;
        public SquareColor Color
        {
            get { return _color; }
            set
            {
                _color = value;
                if (_color != SquareColor.White)
                {
                    this.BackColor = System.Drawing.Color.Gray;
                }
                else
                {
                    this.BackColor = System.Drawing.Color.White;
                }
            }
        }
        public Square(Square[,] squareArray,SquareColor c, Board b, Piece p = null)
        {
            _piece = p;
            _board = b;
            Color = c;
            SizeMode = PictureBoxSizeMode.StretchImage;

            this.MouseClick += new MouseEventHandler(OnMouseClick);
            _piece.Moving(squareArray, squareArray[currentRowNumber,currentColumnNumber]);
        }
        static void OnMouseClick(Object sender, MouseEventArgs e)
        {
            Square activeSquare = (Square)sender;
            Board b = activeSquare._board;
            if (e.Button == MouseButtons.Left)
            {
                activeSquare.Selected = true;
            }
            else if(e.Button == MouseButtons.Right)
            {
                //Board b = activeSquare._board;
                if(b.SelectedSquare != null)
                {
                    activeSquare.Piece = b.SelectedSquare.Piece;
                    b.SelectedSquare.Piece = null;
                    activeSquare.Selected = true;
                }
            }
            
        }
    }
}
