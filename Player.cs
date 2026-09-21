class Player
{

  public int Row { get; set; }
  public int Col { get; set; }

  public Backpack Backpack { get; } = new();

  public Player(int startRow, int startCol)
  {
    Row = startRow;
    Col = startCol;
  }

}