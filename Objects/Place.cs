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
    public static Place Find(string searchCityName)
    {
      int counter=0;
      int searchIndex=0;
      foreach(var place in _instances)
      {
        if(place.GetCityName()==searchCityName)
        {
          searchIndex=counter;
        }
        counter++;
      }
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
