using JewelryMaking.Data;
using JewelryMaking.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Services
{
    public class BeadService
    {//___________________Post-Create____________
        public bool CreateBead(BeadCreate model)
        {
            var entity = new Bead()
            {
                Brand = model.Brand,
                Type = model.Type,
                SubType = model.SubType,
                Shape = model.Shape,
                Size = model.Size,
                Color = model.Color,
                Quantity = model.Quantity,
                Cost = model.Cost,
                Description = model.Description,
                LocationId = model.LocationId,
                //Source = model.Source,
                //BeadImage = model.BeadImage
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Beads.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        //___________________Get-Read____________
        public IEnumerable<BeadListAll> GetBeads()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Beads.ToList();
                List<BeadListAll> Result = new
                List<BeadListAll>();
                foreach (Bead e in query)
                {
                    BeadListAll bead = new BeadListAll
                    {
                        BeadId = e.BeadId,
                        Type = e.Type,
                        Shape = e.Shape,
                        Color = e.Color,
                        LocationId = e.LocationId
                        //BeadImage = e.BeadImage
                    };
                    Result.Add(bead);
                }
                return Result;
            }
        }
        //___________________Get-By Id____________
        public BeadDetail GetBeadById(int beadId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Beads.Single(e => e.BeadId == beadId);
                return new BeadDetail
                {
                    BeadId = entity.BeadId,
                    Brand = entity.Brand,
                    Type = entity.Type,
                    SubType = entity.SubType,
                    Shape = entity.Shape,
                    Size = entity.Size,
                    Color = entity.Color,
                    Quantity = entity.Quantity,
                    Cost = entity.Cost,
                    LocationId = entity.LocationId,
                    //Source = entity.Source,
                    Description = entity.Description,
                    //BeadImage = entity.BeadImage
                };
            }
        }
        //___________________Put-Update____________
        public bool UpdateBead(BeadEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Beads
                    .Single(e => e.BeadId == model.BeadId);
                entity.Brand = model.Brand;
                entity.Type = model.Type;
                entity.SubType = model.SubType;
                entity.Shape = model.Shape;
                entity.Size = model.Size;
                entity.Color = model.Color;
                entity.Quantity = model.Quantity;
                entity.Cost = model.Cost;
                entity.LocationId = model.LocationId;
                //entity.Source = model.Source;
                entity.Description = model.Description;
                //entity.BeadImage = model.BeadImage;
                return ctx.SaveChanges() == 1;
            }
        }
        //___________________Delete_____________________
        public bool DeleteBead(int BeadId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Beads
                    .Single(e => e.BeadId == BeadId);
                ctx.Beads.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}