using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFull
{
    public class King : Piece
    {
        public King(Square sq, PieceColor color) : base(sq, color)
        {
            if (color == PieceColor.White)
            {
                _image = Resources.IMAGE_KING_WHITE;
            }
            else
            {
                _image = Resources.IMAGE_QUEEN_WHITE;
            }
        }
        public bool Moving(Square[,] _square, Square square)
        {
            int x = square.currentRowNumber;
            int y = square.currentColumnNumber;
            int _x = square.nextRowNumber;
            int _y = square.nextColumnNumber;
            if (_square[_x, _y] == _square[x + 1, y + 1] ||
                _square[_x, _y] == _square[x + 1, y - 1] ||
                _square[_x, _y] == _square[x + 1, y] ||
                _square[_x, _y] == _square[x, y + 1] ||
                _square[_x, _y] == _square[x - 1, y + 1])
            {
                return true;
            }
            return false;
        }

    }
}
