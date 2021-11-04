using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using UOM.Domain.Models.Dimensions;

namespace UOM.Persistence.EF.Repositories
{
    public class DimensionRepository : IDimensionRepository
    {
        private readonly UomContext _context;

        public DimensionRepository(UomContext uomContext)
        {
            _context = uomContext;
        }
        public int NextId()
        {
            return 1; 
            //using var context = new UomContext();
            //var p = new SqlParameter("@result", System.Data.SqlDbType.Int);
            //p.Direction = System.Data.ParameterDirection.Output;
            //context.Database.ExecuteSqlRaw("set @result = next value for dimension_seq", p);
            //return (int)p.Value;
        }

        public void Add(Dimension dimension)
        {
            _context.Dimensions.Add(dimension);
            _context.SaveChanges();
        }

        public Dimension GetById(long id)
        {
            return _context.Dimensions.Find(id);
        }
    }
}
