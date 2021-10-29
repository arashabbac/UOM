using UOM.Domain.Models.UnitOfMeasures;

namespace UOM.Domain.Tests.Unit.TestUtils
{
    internal static class BaseUnitOfMeasureFactory
    {
        public static BaseUnitOfMeasure CreateGram()
        {
            var dimenson = DimensionFactory.CreateMassDimension();

            return new BaseUnitOfMeasure(1, "Gram", "gr", dimenson);
        }
    }
}
