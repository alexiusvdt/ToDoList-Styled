using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Tag
  {
    public int TagId { get; set; }
    public string Title { get; set; }
    // public string Color { get; set; }
    public List<ItemTag> JoinEntities { get; }
  }
}