using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Transactions;
using UOM.Persistence.EF;

namespace UOM.Application.Tests.Integration
{
    public class PersistTest<T> : IDisposable where T : DbContext , new()
    {
        private TransactionScope _scope;
        protected T Context;
        public PersistTest()
        {
            Context = new T();
            _scope = new TransactionScope();
            //begin transaction
        }

        public void DetachAllEntities()
        {
            var changedEntriesCopy = Context.ChangeTracker.Entries()
                .Where(current => current.State == EntityState.Added ||
                                current.State == EntityState.Modified ||
                                current.State == EntityState.Deleted)
                .ToList();

            foreach (var entry in changedEntriesCopy)
            {
                entry.State = EntityState.Detached;
            }
        }

        public void Dispose()
        {
            _scope.Dispose();
            Context.Dispose();
        }
    }
}
