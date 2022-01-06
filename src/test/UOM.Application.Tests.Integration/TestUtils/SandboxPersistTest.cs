using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using UOM.Persistence.EF;

namespace UOM.Application.Tests.Integration.TestUtils
{
    public class SandboxPersistTest : IDisposable
    {
        protected UomContext Context;
        private readonly string _connectionString;
        public SandboxPersistTest()
        {
            _connectionString = RandomConnectionString(Constant.ConnectionString);
            Context = UomContextFactory.Create(new SqlConnection(_connectionString));
            MigrateDatabaseToLatestVersion(Context);
        }

        public void Dispose()
        {
            //Drop Database
            Context.Database.EnsureDeleted();

            //Dispose DbContext
            Context.Dispose();
        }
        private string RandomConnectionString(string connectionString)
        {
            var builder = new SqlConnectionStringBuilder(connectionString);
            builder.InitialCatalog = $"{builder.InitialCatalog}-{Guid.NewGuid():N}";
            return builder.ConnectionString;
        }

        private void MigrateDatabaseToLatestVersion(UomContext context)
        {
            context.Database.Migrate();
        }

    }
}
