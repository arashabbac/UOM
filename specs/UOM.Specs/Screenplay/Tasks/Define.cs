using Suzianna.Core.Screenplay;
using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Tasks;

namespace UOM.Specs.Screenplay.Tasks
{
    public static class Define
    {
        public static ITask Dimension(MeasurmentDimension dimension)
        {
            return Factory.CreateTask<DefineDimension>(dimension);
        }
    }
}
