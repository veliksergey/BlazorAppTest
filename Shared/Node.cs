namespace BlazorApp2.Shared;

public class Node
{
  public string? name { get; set; }
  public string? status { get; set; }
  public string? type { get; set; }
  public List<Node>? children { get; set; }
}