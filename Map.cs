class Map
{
  private Location?[][] locations =
  {
    new Location?[5] {null,               null,               new Escalator1(),         new Roof(),           null},
    new Location?[5] {new Foyer(),        new Escalator2(),   new CorridorA(),          null,                 null},
    new Location?[5] {new ToiletStall(),  null,               new OutsideDryCleaner(),  new CorridorB(),      null},
    new Location?[5] {null,               null,               new DryCleaner(),         new SecurityOffice(), new TaxiStation()}
  };



  public Location GetLocation(int row, int col)
  {
    return locations[row][col]!; // ! assertion, we promise this will exist
  }



}