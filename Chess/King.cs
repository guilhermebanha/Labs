namespace Chess
{
    public class King : Piece
    {
        public King() { }
        public override string Symbol => "K";

        public override void Move(int dx, int dy)
        {
            throw new NotImplementedException();
        }
    }
}
