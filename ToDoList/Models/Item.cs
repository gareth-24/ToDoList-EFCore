using System.Collections.Generic;
using MySqlConnector;

namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }   //Foreign Key for Item
    public Category Category { get; set; }    //Navigation Property for Item, not stored in our database
  }
}