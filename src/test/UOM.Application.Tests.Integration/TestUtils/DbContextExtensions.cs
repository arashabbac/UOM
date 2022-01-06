using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace UOM.Application.Tests.Integration.TestUtils
{
    public static class DbContextExtensions
    {
        public static void DetachAllEntities(this DbContext context)
        {
            var changedEntriesCopy = context.ChangeTracker.Entries()
                .Where(current => current.State == EntityState.Added ||
                                current.State == EntityState.Modified ||
                                current.State == EntityState.Deleted)
                .ToList();

            foreach (var entry in changedEntriesCopy)
            {
                entry.State = EntityState.Detached;
            }
        }
    }
}
