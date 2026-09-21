class Game
{

  bool isRunning = true;
  Player player = new(2, 0); // starting position
  Map map = new();
  Menu menu = new();


  public void Start()
  {
    // game start
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

    Console.WriteLine($"\n=== {location.Name} ===");
    Console.WriteLine(location.Description);

    Console.WriteLine("\n== Vad vill du göra?");

    // Todo, move the menu logic to menu...

    List<string> options = [
        "1. Förflytta dig",
        "2. Undersök platsen",
        "3. Ta ett föremål", // put it straight into the backpack for now
        "4. Interagera",     // When a location has an action, start it
        "5. Titta i ryggsäcken",
        "9. Avsluta spelet"
    ];

    Console.WriteLine(string.Join("\n", options));

    Console.Write("> ");
    string? input = Console.ReadLine();

    int.TryParse(input, out int choice);

    switch (choice)
    {
      case 1:
        // Available directions are defined in each location
        List<string> directions = location.Directions.ToList();

        Console.WriteLine("Vart vill du gå?", directions);
        string selectedDirection = Console.ReadLine();

        switch (selectedDirection)
        {
          case "Norr":
            TryMovePlayer(-1, 0);
            break;
          case "Söder":
            TryMovePlayer(1, 0);
            break;
          case "Väster":
            TryMovePlayer(0, -1);
            break;
          case "Öster":
            TryMovePlayer(0, 1);
            break;
        }
        break;
      case 2:
        Console.WriteLine(location.Description); // we could change this for a more detailed description
        break;
      case 3:
        // Show take item logic (if there are items)
        break;
      case 4:
        // Call location action (if there is any)
        break;
      case 5:
        // Show player backback
        break;
      case 9:
        isRunning = false; // stop game loop and exit
        Console.WriteLine("Spelet avslutas.");
        break;
    }
  }

  private void TryMovePlayer(int rowMove, int colMove)
  {
    if (rowMove != 0 && colMove != 0)
    {
      Console.WriteLine("Du kan bara flytta dig i en rikning i taget");
    }
    else if (map.PositionExists(player.Row + rowMove, player.Col + colMove))
    {
      player.Row = player.Row + rowMove;
      player.Col = player.Col + colMove;
    }
    else
    {
      Console.WriteLine("Ogiltig position");
    }

  }

}