using Suzianna.Core.Screenplay.Actors;
using Suzianna.Core.Screenplay.Questions;
using UOM.Specs.Shared.Constants;
using UOM.Specs.Shared.Models;

namespace UOM.Specs.Shared.Questions
{
    public abstract class LastCreatedDimension : IQuestion<MeasurmentDimension>
    {
        public MeasurmentDimension AnsweredBy(Actor actor)
        {
            var id = actor.Recall<long>(Keys.Dimensions.DimensionId);
            return Execute(id, actor);
        }

        protected abstract MeasurmentDimension Execute<T>(long id, T actor) where T : Actor;
    }
}
