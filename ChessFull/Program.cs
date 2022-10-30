using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ChessFull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form mForm = new Form();

            Board mBoard = new Board(mForm);
            mForm.Size = new Size(100 * 9, 100 * 9);
            Application.Run(mForm);
        }
    }
}
