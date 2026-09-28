using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public abstract class Piece
    {
        Position position { get; set; }
        Color color { get; set; }

        public Piece() { }
        public Piece(Position position, Color color) { position = position; color = color; }

        public override string ToString()
        {
            return position.ToString();
        }
    
    }
}
