using OdeToFood.Core;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {  Id = 1, Name = "Henry's Pizza", Location = "Lansing", Cuisine = CuisineType.Italian},
                new Restaurant {  Id = 2, Name = "Bob's Burgers", Location = "Detroit", Cuisine = CuisineType.Mexican},
                new Restaurant {  Id = 3, Name = "Leeroy's Lemons", Location = "Budapest", Cuisine = CuisineType.Indian}
            };
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
