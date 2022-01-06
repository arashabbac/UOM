using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Transactions;
using UOM.Persistence.EF;

namespace UOM.Application.Tests.Integration.TestUtils
{
    public class PersistTest: IDisposable 
    {
        private TransactionScope _scope;
        protected UomContext Context;
        public PersistTest()
        {
            Context = UomContextFactory.Create(new SqlConnection(Constant.ConnectionString));
            _scope = new TransactionScope();
            //begin transaction
        }

        public void Dispose()
        {
            _scope.Dispose();
            Context.Dispose();
        }
    }
}
