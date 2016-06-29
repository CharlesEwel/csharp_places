using System.Collections.Generic;

namespace myPlace.Objects
{
  public class Place
  {
    private string _cityName;
    private static List<Place> _instances = new List<Place>{};
    private int _id;
    public Place(string CityName)
    {
      _cityName = CityName;
      _instances.Add(this);
      _id=_instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static Place Find(int searchID)
    {
      return _instances[searchID - 1];
    }
    public int GetID()
    {
      return _id;
    }
    public string GetCityName()
    {
      return _cityName;
    }
    public void SetCityName(string newCityName)
    {
      _cityName = newCityName;
    }

  }
}
