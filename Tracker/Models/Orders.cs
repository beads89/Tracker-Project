using System.Collections.Generic;

namespace Tracker.Models
{
  public class Orders
  {
    public string Contents {get; set;}
    public int Id {get;}
    private static List<Orders> _instances = new List<Orders> {};
    public Orders(string contents)
    {
      Contents = contents;
      _instances.Add(this);
      Id = _instances.Count;

    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Orders> GetAll()
    {
      return _instances;
    }

    public static Orders Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}