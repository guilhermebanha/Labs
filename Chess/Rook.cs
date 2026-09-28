using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Rook : Piece
    {
        public Rook(Position pos, Color color) : base(pos, color) { }

        public override void Move(int dx, int dy)
        {
            if(dx != 0) { base.Position.X += dx; }
            else { base.Position.Y += dy; }
        }

        public override string ToString()
        {

            return $"T{base.ToString()}";
        }
        public override string Symbol => "R";

        public override string Name
        {
            get { return "Rook"; }
        }
    }
}