﻿using JewelryMaking.Data;
using JewelryMaking.Models;
using System.Collections.Generic;
using System.Linq;

namespace JewelryMaking.Services
{
    public class StringingMaterialService
    {
        //___________________Post-Create____________

        FileUploadService _FileService = new FileUploadService();

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
                Description = model.Description,
                LocationId = model.LocationId,
                SourceId = model.SourceId,
                File = _FileService.ConvertToBytes(model.File),
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
                        LocationId = e.LocationId,
                    };
                    Result.Add(stringingMaterial);
                }
                return Result;
            }
        }
        //___________________Get-Read SubTotal___________________________
        public IEnumerable<StringingMaterialSubTotal> GetStringingMaterialSubTotal()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.StringingMaterials.ToList();
                List<StringingMaterialSubTotal> Result = new
                List<StringingMaterialSubTotal>();
                foreach (StringingMaterial e in query)
                {
                    StringingMaterialSubTotal stringingMaterial = new StringingMaterialSubTotal
                    {
                        StringingMaterialId = e.StringingMaterialId,
                        Type = e.Type,
                        Material = e.Material,
                        Size = e.Size,
                        Color = e.Color,
                        Length = e.Length,
                        Cost = e.Cost,
                        SubTotal = e.SubTotal
                    };
                    Result.Add(stringingMaterial);
                }
                return Result;
            }
        }
        //___________________Get/Read-By Id____________
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
                    SubTotal = entity.SubTotal,
                    Description = entity.Description,
                    LocationId = entity.LocationId,
                    SourceId = entity.SourceId,
                    FileAsBytes = entity.File
                };
            }
        }
        //___________________Put-Update____________
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
                entity.Description = model.Description;
                entity.LocationId = model.LocationId;
                entity.SourceId = model.SourceId;
                entity.File = _FileService.ConvertToBytes(model.File);

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