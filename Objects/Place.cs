using System.Collections.Generic;

namespace myPlace.Objects
{
  public class Place
  {
    private string _cityName;
    private static List<Place> _instances = new List<Place>{};
    private static List<string> _cityNames = new List<string>{};
    private int _id;
    public Place(string CityName)
    {
      _cityName = CityName;
      _instances.Add(this);
      _cityNames.Add(CityName);
      _id=_instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }
    public static Place Find(string searchCityName)
    {
      int searchIndex=_cityNames.IndexOf(searchCityName);
      return _instances[searchIndex];
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
