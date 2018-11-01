using System;
using Northwind.Persistence;
using Xunit;

namespace Northwind.Application.Tests.Infrastructure
{
    public class QueryTestFixture : IDisposable
    {
        public NorthwindDbContext Context { get; private set; }

        public QueryTestFixture()
        {
            Context = NorthwindContextFactory.Create();
        }

        public void Dispose()
        {
            NorthwindContextFactory.Destroy(Context);
        }
    }

    [CollectionDefinition("QueryCollection")]
    public class QueryCollection : ICollectionFixture<QueryTestFixture> { }
}