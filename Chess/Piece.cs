using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public abstract class Piece
    {
        Position Position { get; set; }
        Color Color { get; set; }

        public Piece() { }
        public Piece(Position position, Color color) { Position = position; Color = color; }

        public override string ToString()
        {
            return Position.ToString();
        }
        
        public virtual string Name
        {
            get { return "Desconhecida"; }
        }
    
    }
}
    