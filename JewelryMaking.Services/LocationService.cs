using JewelryMaking.Data;
using JewelryMaking.Models;
using System.Collections.Generic;
using System.Linq;

namespace JewelryMaking.Services
{
    public class LocationService
    { //___________________Post-Create____________
        public bool CreateLocation(LocationCreate model)
        {
            var entity = new Location()
            {
                Kind = model.Kind,
                Size = model.Size,
                Color = model.Color,
                Place = model.Place
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Locations.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        //___________________Get-Read____________
        public IEnumerable<LocationListAll> GetLocations()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Locations.ToList();
                List<LocationListAll> Result = new
                List<LocationListAll>();
                foreach (Location e in query)
                {
                    LocationListAll location = new LocationListAll
                    {
                        LocationId = e.LocationId,
                        Kind = e.Kind,
                        Size = e.Size,
                        Color = e.Color
                    };
                    Result.Add(location);
                }
                return Result;
            }
        }
        //___________________Get-By Id____________
        public LocationDetail GetLocationById(int locationId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Locations.Single(e => e.LocationId == locationId);
                return new LocationDetail
                {
                    LocationId = entity.LocationId,
                    Kind = entity.Kind,
                    Size = entity.Size,
                    Color = entity.Color,
                    Place = entity.Place
                };
            }
        }
        //___________________Edit-Update____________
        public bool UpdateLocation(LocationEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Locations
                    .Single(e => e.LocationId == model.LocationId);
                entity.Kind = model.Kind;
                entity.Size = model.Size;
                entity.Color = model.Color;
                entity.Place = model.Place;
                return ctx.SaveChanges() == 1;
            }
        }
        //___________________Delete____________
        public bool DeleteLocation(int LocationId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Locations
                    .Single(e => e.LocationId == LocationId);
                ctx.Locations.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}