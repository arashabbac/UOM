using FluentAssertions;
using UOM.Domain.Models.UnitOfMeasures;
using UOM.Domain.Tests.Unit.TestUtils;
using Xunit;

namespace UOM.Domain.Tests.Unit
{
    public class ScaledUnitOfMeasureTests
    {
        private readonly BaseUnitOfMeasure _gram;

        public ScaledUnitOfMeasureTests()
        {
            _gram = BaseUnitOfMeasureFactory.CreateGram();
        }

        [Fact]
        public void Scaled_UnitOfMeasure_Constructed_Properly()
        {
            var kilogram = new ScaledUnitOfMeasure(2, "Kilogram", "KG",1000, _gram);

            kilogram.Id.Should().Be(2);
            kilogram.Name.Should().Be("Kilogram");
            kilogram.Symbol.Should().Be("KG");
            kilogram.ConversionRate.Should().Be(1000);
            kilogram.BaseUnitOfMeasureId.Should().Be(_gram.Id);
        }

        [Fact]
        public void Scaled_UnitOfMeasure_Convert_To_Base_When_ItIs_On_Higher_Scale()
        {
            var kilogram = new ScaledUnitOfMeasure(2, "Kilogram", "KG", 1000, _gram);

            var amountInBase = kilogram.ConvertToBase(3);
            amountInBase.Should().Be(3000);
        }

        [Fact]
        public void Scaled_UnitOfMeasure_Convert_To_Base_When_ItIs_On_Lower_Scale()
        {
            var milligram = new ScaledUnitOfMeasure(2, "Milligram", "mg", 0.001M, _gram);

            var amountInBase = milligram.ConvertToBase(3);
            amountInBase.Should().Be(0.003M);
        }

        [Fact]
        public void Scaled_UnitOfMeasure_Convert_To_Bigger_Scaled_UOM()
        {
            var milligram = new ScaledUnitOfMeasure(2, "Milligram", "mg", 0.001M, _gram);
            var kilogram = new ScaledUnitOfMeasure(3, "Kilogram", "KG", 1000, _gram);

            var amountInKg = milligram.ConvertTo(kilogram,2000);
            amountInKg.Should().Be(0.002M);
        }

        [Fact]
        public void Scaled_UnitOfMeasure_Convert_To_Smaller_Scaled_UOM()
        {
            var milligram = new ScaledUnitOfMeasure(2, "Milligram", "mg", 0.001M, _gram);
            var kilogram = new ScaledUnitOfMeasure(3, "Kilogram", "KG", 1000, _gram);

            var amountInMg = kilogram.ConvertTo(milligram, 2);
            amountInMg.Should().Be(2000000);
        }
    }
}
