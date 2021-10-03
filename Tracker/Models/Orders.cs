using System.Collections.Generic;

namespace Tracker.Models
{
  public class Orders
  {
    public string Contents {get; set;}
    public string OrderDescription {get; set;}
    public string OrderDate {get; set;}
    public int OrderPrice {get; set;}
    public int Id {get;}
    private static List<Orders> _instances = new List<Orders> {};
    public Orders(string contents, string orderDescription, string orderDate, int orderPrice)
    {
      Contents = contents;
      OrderDescription = orderDescription;
      OrderDate = orderDate;
      OrderPrice = orderPrice;
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