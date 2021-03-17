using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace OdeToFood.Data
{
    class OdeToFoodDbContext :DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
