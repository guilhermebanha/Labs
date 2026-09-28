namespace Chess
{
    public class Bishop : Piece
    {
        public Bishop() { }
        public override string Symbol => "K";

        public override void Move(int dx, int dy)
        {
            throw new NotImplementedException();
        }
    }
}
