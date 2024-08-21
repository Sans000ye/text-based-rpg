using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {private List<Places> places = new List<Places> { };
        internal void AddPlaces(int x, int y, string name, string description, string imgname)
        {
            Places place = new Places();
            place.X = x; 
            place.Y = y;
            place.Name = name;
            place.ImgName = imgname;
            place.Description = description;

            places.Add(place);
        }
        public Places PlacesAt(int x,int y)
        {
            foreach (Places places in places)
            { if (places.X == x && places.Y == y) 
                {
                    return places;
                }
            }
            return null;
        }
    }
}
