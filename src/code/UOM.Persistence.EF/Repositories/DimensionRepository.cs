using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using UOM.Domain.Models.Dimensions;

namespace UOM.Persistence.EF.Repositories
{
    public class DimensionRepository : IDimensionRepository
    {
        public int NextId()
        {
            using var context = new UomContext();
            var p = new SqlParameter("@result", System.Data.SqlDbType.Int);
            p.Direction = System.Data.ParameterDirection.Output;
            context.Database.ExecuteSqlRaw("set @result = next value for dimension_seq", p);
            return (int)p.Value;
        }

        public void Add(Dimension dimension)
        {
            using var context = new UomContext();
            context.Dimensions.Add(dimension);
            context.SaveChanges();
        }

        public Dimension GetById(long id)
        {
            using var context = new UomContext();
            return context.Dimensions.Find(id);
        }
    }
}
