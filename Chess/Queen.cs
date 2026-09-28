namespace Chess
{
    public class Queen : Piece
    {
        public Queen() { }
        public override string Symbol => "Q";

        public override void Move(int dx, int dy)
        {
            throw new NotImplementedException();
        }
    }
}
