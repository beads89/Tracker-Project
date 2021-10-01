using System.Collections.Generic;

namespace Tracker.Models
{
  public class Vendors
  {
    public string Name {get; set;}
    public int Id {get;}
    private static List<Vendors> _instances = new List<Vendors> {};
    public Vendors(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendors> GetAll()
    {
      return _instances;
    }

    public static Vendors Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}