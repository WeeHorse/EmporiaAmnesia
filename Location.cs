class Location
{
  public string Name { get; protected set; } = "";
  public string Description { get; protected set; } = "";

  // added after monday class, as part of adding basic menu functionality
  public List<Item> Items = [];

  public string[] Directions { get; protected set; } = [""];

}