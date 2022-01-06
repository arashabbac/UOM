using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace UOM.Persistence.EF
{
    public static class UomContextFactory
    {
        public static UomContext Create(DbConnection dbConnection)
        {
            var builder = new DbContextOptionsBuilder();
            builder.UseSqlServer(dbConnection);
            return new UomContext(builder.Options);
        }
    }
}
