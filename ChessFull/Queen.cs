using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFull
{
    public class Queen : Piece
    {
        public Queen(Square sq, PieceColor color) : base(sq, color)
        {
            if (color == PieceColor.White)
            {
                _image = Resources.IMAGE_QUEEN_WHITE;
            }
            else
            {
                _image = Resources.IMAGE_QUEEN_BLACK;
            }
        }
    }
}
