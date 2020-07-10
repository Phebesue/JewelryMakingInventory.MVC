using JewelryMaking.Data;
using JewelryMaking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryMaking.Services
{
    public class FindingService
    {//___________________Create____________
        public bool CreateFinding(FindingCreate model)
        {
            var entity = new Finding()
            {
                Category = model.Category,
                SubType = model.SubType,
                Size = model.Size,
                Color = model.Color,
                Association = model.Association,
                Quantity = model.Quantity,
                Cost = model.Cost,
                LocationId = model.LocationId,
                SourceId = model.SourceId,
                Description = model.Description,
                //FindingImage = model.FindingImage
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Findings.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        //___________________Get-Read____________
        public IEnumerable<FindingListAll> GetFindings()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Findings.ToList();
                List<FindingListAll> Result = new
                List<FindingListAll>();
                foreach (Finding e in query)
                {
                    FindingListAll finding = new FindingListAll
                    {
                        FindingId = e.FindingId,
                        Category = e.Category,
                        SubType = e.SubType,
                        Color = e.Color,
                        Quantity = e.Quantity,
                    };
                    Result.Add(finding);
                }
                return Result;
            }
        }
        //___________________Get-Read SubTotal____________
        public IEnumerable<FindingSubTotal> GetFindingSubTotal()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Findings.ToList();
                List<FindingSubTotal> Result = new
                List<FindingSubTotal>();
                foreach (Finding e in query)
                {
                    FindingSubTotal finding = new FindingSubTotal
                    {
                        FindingId = e.FindingId,
                        Category = e.Category,
                        SubType = e.SubType,
                        Color = e.Color,
                        Quantity = e.Quantity,
                        Cost = e.Cost,
                        SubTotal = e.SubTotal
                    };
                    Result.Add(finding);
                }
                return Result;
            }
        }
        //___________________Get-By Id____________
        public FindingDetail GetFindingById(int beadId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Findings.Single(e => e.FindingId == beadId);
                return new FindingDetail
                {
                    FindingId = entity.FindingId,
                    Category = entity.Category,
                    SubType = entity.SubType,
                    Size = entity.Size,
                    Color = entity.Color,
                    Association = entity.Association,
                    Quantity = entity.Quantity,
                    Cost = entity.Cost,
                    SubTotal = entity.SubTotal,
                    LocationId = entity.LocationId,
                    SourceId = entity.SourceId,
                    Description = entity.Description,
                    //FindingImage = entity.FindingImage
                };
            }
        }
        //___________________Edit-Update____________
        public bool UpdateFinding(FindingEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Findings
                    .Single(e => e.FindingId == model.FindingId);
                entity.Category = model.Category;
                entity.SubType = model.SubType;
                entity.Size = model.Size;
                entity.Color = model.Color;
                entity.Association = model.Association;
                entity.Quantity = model.Quantity;
                entity.Cost = model.Cost;
                entity.LocationId = model.LocationId;
                entity.SourceId = model.SourceId;
                entity.Description = model.Description;
                //entity.FindingImage = model.FindingImage;

                return ctx.SaveChanges() == 1;
            }
        }
        //___________________Delete____________
        public bool DeleteFinding(int FindingId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Findings
                    .Single(e => e.FindingId == FindingId);
                ctx.Findings.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}