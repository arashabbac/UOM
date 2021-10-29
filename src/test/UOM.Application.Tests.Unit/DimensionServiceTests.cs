using FluentAssertions;
using NSubstitute;
using PAP.NSubstitute.FluentAssertionsBridge;
using UOM.Domain.Models.Dimensions;
using Xunit;

namespace UOM.Application.Tests.Unit
{
    public class DimensionServiceTests
    {
        [Fact]
        public void Save_A_Dimension_Into_Database()
        {
            var repository = Substitute.For<IDimensionRepository>();
            repository.NextId().Returns(1);
            var service = new DimensionService(repository);
            var dto = new DefineDimensionDto
            {
                Name = "Mass",
                Symbol = "m",
            };

            var expected = new Dimension(1, "Mass", "m");

            service.DefineDimension(dto);

            repository.Received(1).Add(Verify.That<Dimension>(a=> a.Should().BeEquivalentTo(expected)));
        }
    }
}
