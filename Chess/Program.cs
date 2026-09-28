using Chess;

Position p1 = new Position();
Position p2 = new Position(1,2);

Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());

Rook rook = new Rook(p1,Color.White);
Pawn pawn = new Pawn(p2, Color.Black);


Console.WriteLine(pawn.ToString());
Console.WriteLine(rook.ToString());

List<Piece> pieces = new List<Piece>();
pieces.Add(new Rook(new Position(0,1), Color.White));
pieces.Add(new Pawn(new Position(0,0), Color.White));
foreach (Piece piece in pieces)
{
    Console.WriteLine($"{piece.Name} - {piece}");
}
Board board = new Board();
board.show();