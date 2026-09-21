class Player
{

  public int Row { get; set; }
  public int Col { get; set; }

  public Backpack backpack { get; } = new();

  public Player(int startRow, int startCol)
  {
    Row = startRow;
    Col = startCol;
  }

}