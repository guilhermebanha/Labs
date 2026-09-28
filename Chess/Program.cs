using Chess;

Position p1 = new Position();
Position p2 = new Position(1,2);

Console.WriteLine(p1.ToString());
Console.WriteLine(p2.ToString());

Rook rook = new Rook(p1,Color.White);
Pawn pawn = new Pawn(p2, Color.Black);


Console.WriteLine(pawn.ToString());
Console.WriteLine(rook.ToString());
