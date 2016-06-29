using System.Collections.Generic;
using Nancy;
using myPlace.Objects;

namespace myPlaces
{
  public class HomeModule:NancyModule
  {
    public HomeModule()
    {
      Get["/"]=_=>View["index.cshtml"];
      Get["/add_place"]=_=>View["add_place.cshtml"];
      Get["/places"] =_=>{
        List<Place> placeList = Place.GetAll();
        return View["view_all_places.cshtml", placeList];
      };
      Post["/places"] = _ => {
        Place newPlace = new Place (Request.Form["new-place"]);
        List<Place> placeList = Place.GetAll();
        return View["view_all_places.cshtml", placeList];
      };
      Get["/places/{cityName}"] = parameters => {
        Place place = Place.Find(parameters.cityName);
        return View["/place_details.cshtml", place];
      };
    }
  }
}
