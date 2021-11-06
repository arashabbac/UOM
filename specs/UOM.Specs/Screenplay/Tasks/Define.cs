using Suzianna.Core.Screenplay;
using UOM.Specs.Models;

namespace UOM.Specs.Screenplay.Tasks
{
    public static class Define
    {
        public static ITask Dimension(MeasurmentDimension dimension)
        {
            return new DefineDimension(dimension);
        }
    }
}
