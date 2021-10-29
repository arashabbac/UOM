using UOM.Domain.Models.Dimensions;

namespace UOM.Domain.Tests.Unit.TestUtils
{
    internal static class DimensionFactory
    {
        public static Dimension CreateMassDimension()
        {
            return new Dimension(1,"Mass", "m");
        }

    }
}
