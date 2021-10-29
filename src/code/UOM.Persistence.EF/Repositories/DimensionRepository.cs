using System;
using UOM.Domain.Models.Dimensions;

namespace UOM.Persistence.EF.Repositories
{
    public class DimensionRepository : IDimensionRepository
    {
        public int NextId()
        {
            return new Random().Next(1, 10000000);
        }

        public void Add(Dimension dimension)
        {
            using var context = new UomContext();
            context.Dimensions.Add(dimension);
            context.SaveChanges();
        }
    }
}
