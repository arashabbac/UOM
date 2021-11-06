using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UOM.Domain.Models.Dimensions;
using Xunit;

namespace UOM.Domain.Tests.Unit
{
    public class DimensionTests
    {
        [Fact]
        public void Dimension_Constructed_Properly()
        {
            var measurement = new Dimension("Mass", "m");
            
            measurement.Name.Should().Be("Mass");
            measurement.Symbol.Should().Be("m");
        }
    }
}
