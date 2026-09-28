using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Chess
{
    public class Pawn : Piece
    {
        public Pawn(Position pos, Color color) : base(pos,color) { }

        public override void Move(int dx, int dy)
        {
            base.Position.X += dx;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public override string Name
        {
            get { return "Pawn"; }
        }

        public override string Symbol => "P";

        public static Pawn operator ++(Pawn pawn)
        {
            if (pawn.isWhite)
            {
                pawn.Move(0, pawn.Position.Y++);
            }
            else
            {
                pawn.Move(0, pawn.Position.Y--);

            }
            return pawn;
        }

        
    }
}