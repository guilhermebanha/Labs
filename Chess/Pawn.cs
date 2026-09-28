using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Pawn : Piece
    {
        public Pawn(Position pos, Color color) : base(pos,color) { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
