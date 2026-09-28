using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Chess
{
    public class Position
    {
        public int X { get; set;  } // Intervalo 0-7
        public int Y { get; set; } // Intervalo 0-7

        public Position ()
        {
            X = 0;
            Y = 0;
        }

        public Position (int x, int y)
        {
            X = x; Y = y;
        }

        public override string ToString()
        {
            char column = (char)('a' + X);
            int row = Y + 1;
            return $"{column}{row}";
        }

    }
}
