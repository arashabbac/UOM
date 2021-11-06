using FluentAssertions;
using System.Transactions;
using UOM.Domain.Models.Dimensions;
using UOM.Persistence.EF;
using UOM.Persistence.EF.Repositories;
using Xunit;

namespace UOM.Application.Tests.Integration
{
    public class DimensionServiceTests : PersistTest<UomContext>
    {
        [Fact]
        public void Save_A_Dimension_Into_Database()
        {
            var repository = new DimensionRepository(Context);
            var service = new DimensionService(repository);
            var dto = new DefineDimensionDto
            {
                Name = "Mass",
                Symbol = "m",
            };

            var expected = new Dimension("Mass", "m");

            var id =service.DefineDimension(dto);

            DetachAllEntities();
            var actual = repository.GetById(id);
            actual.Should().BeEquivalentTo(expected , a=> a.Excluding(z => z.Id));
        }
    }
}
