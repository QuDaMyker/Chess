using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChessFull
{   
    public enum PieceColor { White, Black};
    public class Resources
    {
        public static Image IMAGE_PAWN_BLACK = Image.FromFile("images\\pawn_black.png");
        public static Image IMAGE_ROOK_BLACK = Image.FromFile("images\\rook_black.png");
        public static Image IMAGE_KNIGHT_BLACK = Image.FromFile("images\\knight_black.png");
        public static Image IMAGE_BISHOP_BLACK = Image.FromFile("images\\bishop_black.png");
        public static Image IMAGE_QUEEN_BLACK = Image.FromFile("images\\queen_black.png");
        public static Image IMAGE_KING_BLACK = Image.FromFile("images\\king_black.png");

        public static Image IMAGE_PAWN_WHITE = Image.FromFile("images\\pawn_white.png");
        public static Image IMAGE_ROOK_WHITE = Image.FromFile("images\\rook_white.png");
        public static Image IMAGE_KNIGHT_WHITE = Image.FromFile("images\\knight_white.png");
        public static Image IMAGE_BISHOP_WHITE = Image.FromFile("images\\bishop_white.png");
        public static Image IMAGE_QUEEN_WHITE = Image.FromFile("images\\queen_white.png");
        public static Image IMAGE_KING_WHITE = Image.FromFile("images\\king_white.png");
    }
    public class Piece
    {

        protected Image _image;
        protected Square _square;
        
        public Square Square
        {
            get { return _square; }
        }
        public Image Image
        {
            get { return _image; }
        }
        protected PieceColor _color;
        public PieceColor Color
        {
            get { return _color; }
        }
        /*public Piece(Image image, Square square, PieceColor color)
        {
            _image = image;
            _square = square;
            _color = color;
        }*/
        public Piece(Square sq, PieceColor color)
        {
            _square = sq;
            _color = color;
        }
        public bool Moving(Square[,] b, Square square) { return true; }
    }
    
}
