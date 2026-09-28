using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public abstract class Piece : IMovable
    {
        public Position Position { get; set; }
        public Color Color { get; set; }
        public bool isWhite { get; set; }
        public bool isBlack { get; set;  }

        public abstract string Symbol { get; }

        public Piece() { }
        public Piece(Position position, Color color) { Position = position; Color = color; }

        public override string ToString()
        {
            return Position.ToString();
        }

        public abstract void Move(int dx, int dy);
    }
}
