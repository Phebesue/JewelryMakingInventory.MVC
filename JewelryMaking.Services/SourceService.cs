using JewelryMaking.Data;
using JewelryMaking.Models;
using System.Collections.Generic;
using System.Linq;

namespace JewelryMaking.Services
{
    public class SourceService
    {
        //___________________Create____________
        public bool CreateSource(SourceCreate model)
        {
            var entity = new Source()
            {
                Name = model.Name,
                WebSite = model.WebSite,
                ShowOrLocation = model.ShowOrLocation,
                Address = model.Address,
                City = model.City,
                State = model.State,
                ZipCode = model.ZipCode,
                Note = model.Note
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Sources.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        //___________________Get-Read____________
        public IEnumerable<SourceListAll> GetSources()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Sources
                    .Select(
                    e =>
                    new SourceListAll
                    {
                        SourceId = e.SourceId,
                        Name = e.Name,
                        ShowOrLocation = e.ShowOrLocation,
                    }
                    );

                return query.ToArray();
            }
        }
        //___________________Get-By Id____________
        public SourceDetail GetSourceById(int sourceId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Sources.Single(e => e.SourceId == sourceId);
                return new SourceDetail
                {
                    SourceId = entity.SourceId,
                    Name = entity.Name,
                    WebSite = entity.WebSite,
                    ShowOrLocation = entity.ShowOrLocation,
                    Address = entity.Address,
                    City = entity.City,
                    State = entity.State,
                    ZipCode = entity.ZipCode,
                    Note = entity.Note
                };
            }
        }
        //___________________Edit-Update____________
        public bool UpdateSource(SourceEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Sources
                    .Single(e => e.SourceId == model.SourceId);
                entity.Name = model.Name;
                entity.WebSite = model.WebSite;
                entity.ShowOrLocation = model.ShowOrLocation;
                entity.Address = model.Address;
                entity.City = model.City;
                entity.State = model.State;
                entity.ZipCode = model.ZipCode;
                entity.Note = model.Note;
                return ctx.SaveChanges() == 1;
            }
        }
        //___________________Delete____________
        public bool DeleteSource(int SourceId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Sources
                    .Single(e => e.SourceId == SourceId);
                ctx.Sources.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}