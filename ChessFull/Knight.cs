using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFull
{
    public class Knight : Piece
    {
        public Knight(Square sq, PieceColor color) : base(sq, color)
        {
            if (color == PieceColor.White)
            {
                _image = Resources.IMAGE_KNIGHT_WHITE;
            }
            else
            {
                _image = Resources.IMAGE_KNIGHT_BLACK;
            }
        }
    }
}
