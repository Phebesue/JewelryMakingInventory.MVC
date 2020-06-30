using JewelryMaking.Data;
using JewelryMaking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Services
{
    public class StringingMaterialService
    {
        //___________________Create____________
        public bool CreateStringingMaterial(StringingMaterialCreate model)
        {
            var entity = new StringingMaterial()
            {
                Type = model.Type,
                Material = model.Material,
                Size = model.Size,
                Color = model.Color,
                Length = model.Length,
                Cost = model.Cost,
                Location = model.Location,
                Source = model.Source,
                Description = model.Description,
                //StringingImage = model.StringingImage
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.StringingMaterials.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        //___________________Get-Read____________
        public IEnumerable<StringingMaterialListAll> GetStringingMaterials()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.StringingMaterials.ToList();
                List<StringingMaterialListAll> Result = new
                List<StringingMaterialListAll>();
                foreach (StringingMaterial e in query)
                {
                    StringingMaterialListAll stringingMaterial = new StringingMaterialListAll
                    {
                        StringingMaterialId = e.StringingMaterialId,
                        Type = e.Type,
                        Material = e.Material,
                        Size = e.Size,
                        Color = e.Color,
                        Location = e.Location,
                        //StringingImage = e.StringingImage
                    };
                    Result.Add(stringingMaterial);
                }
                return Result;
            }
        }
        //___________________Get-By Id____________
        public StringingMaterialDetail GetStringingMaterialById(int stringingMaterialId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.StringingMaterials.Single(e => e.StringingMaterialId == stringingMaterialId);
                return new StringingMaterialDetail
                {
                    StringingMaterialId = entity.StringingMaterialId,
                    Type = entity.Type,
                    Material = entity.Material,
                    Size = entity.Size,
                    Color = entity.Color,
                    Length = entity.Length,
                    Cost = entity.Cost,
                    Location = entity.Location,
                    Source = entity.Source,
                    Description = entity.Description,
                    //StringingImage = entity.StringingImage
                };
            }
        }
        //___________________Edit-Update____________
        public bool UpdateStringingMaterial(StringingMaterialEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.StringingMaterials
                    .Single(e => e.StringingMaterialId == model.StringingMaterialId);
                entity.Type = model.Type;
                entity.Material = model.Material;
                entity.Size = model.Size;
                entity.Color = model.Color;
                entity.Length = model.Length;
                entity.Cost = model.Cost;
                entity.Location = model.Location;
                entity.Source = model.Source;
                entity.Description = model.Description;
                //entity.StringingImage = model.StringingImage;

                return ctx.SaveChanges() == 1;
            }
        }
        //___________________Delete____________
        public bool DeleteStringingMaterial(int StringingMaterialId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.StringingMaterials
                    .Single(e => e.StringingMaterialId == StringingMaterialId);
                ctx.StringingMaterials.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}