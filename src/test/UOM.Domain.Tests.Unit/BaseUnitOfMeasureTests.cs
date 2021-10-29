using FluentAssertions;
using UOM.Domain.Models.UnitOfMeasures;
using UOM.Domain.Tests.Unit.TestUtils;
using Xunit;

namespace UOM.Domain.Tests.Unit
{
    public class BaseUnitOfMeasureTests
    {
        [Fact]
        public void Base_UnitOfMeasure_Is_Defined_In_A_Dimension()
        {
            var dimension = DimensionFactory.CreateMassDimension();

            var gram = new BaseUnitOfMeasure(1,"Gram", "gr", dimension);

            gram.Id.Should().Be(1);
            gram.DimensionId.Should().Be(dimension.Id);
            gram.Name.Should().Be("Gram");
            gram.Symbol.Should().Be("gr");
        }
    }
}
