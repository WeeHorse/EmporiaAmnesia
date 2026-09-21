class Game
{

  bool isRunning = true;
  Player player = new(2, 0); // starting position
  Map map = new();
  Menu menu = new();


  public void Start()
  {
    // game start
    Console.WriteLine("Emporia Amnesia...");
    while (isRunning)
    {
      PlayTurn();
    }
  }

  Location CurrentLocation() // location is an object of type Location (i e Toilet stall, Foyer, ...)
  {
    return map.GetLocation(player.Row, player.Col); // player.Row and playerCol is the player position - not player location...
  }

  void PlayTurn()
  {
    Location location = CurrentLocation();

    Console.WriteLine($"\n === {location.Name} === ");
    Console.WriteLine(location.Description);

    // temporary shut down
    isRunning = false;

  }

}