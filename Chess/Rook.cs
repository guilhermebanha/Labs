using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Rook : Piece
    {
        public Rook(Position pos, Color color) : base(pos, color) { }

        public override string ToString()
        {

            return $"T{base.ToString()}";
        }
        public override string Name
        {
            get { return "Rook"; }
        }
    }
}
