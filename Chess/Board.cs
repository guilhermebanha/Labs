namespace Chess
{
    public class Board
    {
       private Piece[,] squares = new Piece?[8, 8];
       public Board()
        {
            squares[0, 0] = new Rook(new Position(0, 0), Color.White);
            squares [7, 0] = new Pawn(new Position(7,0), Color.White);
            squares[0, 7] = new Rook(new Position(0, 7), Color.Black);
            squares[7, 7] = new Pawn(new Position(7, 7), Color.Black);

            for (int i=0; i<8; i++)
            {
                squares[i, 1] = new Pawn(new Position(i, 1), Color.White);
                squares[i, 6] = new Pawn(new Position(i, 6), Color.Black);
            }

        }
        public void show()
        {
            for (int y =7;y>=0;y--)
            {
                for (int x=0;x<8;x++)
                {
                    if (squares[x,y] != null)
                    {
                        Console.Write(squares[x,y].Symbol);
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }
        public Piece this[int x, int y]
        {
            get { return squares[x, y]; }
            set { squares[x, y] = value; }
        }
      
    }
    
}