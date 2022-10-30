using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFull
{
    public class Pawn : Piece
    {
        public Pawn(Square sq, PieceColor color) : base(sq, color)
        {
            if (color == PieceColor.White)
            {
                _image = Resources.IMAGE_PAWN_WHITE;
            }
            else
            {
                _image = Resources.IMAGE_PAWN_BLACK;
            }
        }
    }
}
