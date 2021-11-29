using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;
using UOM.Specs.Shared.Constants;
using UOM.Specs.Shared.Models;

namespace UOM.Specs.Shared.Tasks
{
    public abstract class DefineDimension : ITask
    {
        protected readonly MeasurmentDimension Dimension;

        public DefineDimension(MeasurmentDimension dimension)
        {
            Dimension = dimension;
        }

        public void PerformAs<T>(T actor) where T : Actor
        {
            var createdId = Execute(actor);
            actor.Remember(Keys.Dimensions.DimensionId, createdId);
        }

        protected abstract long Execute<T>(T actor) where T : Actor;
    }
}
