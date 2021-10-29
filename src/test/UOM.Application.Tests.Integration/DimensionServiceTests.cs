using FluentAssertions;
using System;
using UOM.Domain.Models.Dimensions;
using UOM.Persistence.EF.Repositories;
using Xunit;

namespace UOM.Application.Tests.Integration
{
    public class DimensionServiceTests
    {
        [Fact]
        public void Save_A_Dimension_Into_Database()
        {
            var repository = new DimensionRepository();
            var service = new DimensionService(repository);
            var dto = new DefineDimensionDto
            {
                Name = "Mass",
                Symbol = "m",
            };

            var expected = new Dimension(1, "Mass", "m");

            service.DefineDimension(dto);

            var actual = repository.GetById(1);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}
