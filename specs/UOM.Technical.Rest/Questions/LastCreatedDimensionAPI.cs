using Suzianna.Core.Screenplay.Actors;
using Suzianna.Core.Screenplay.Questions;
using Suzianna.Rest.Screenplay.Interactions;
using Suzianna.Rest.Screenplay.Questions;
using UOM.Specs.Shared.Constants;
using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Questions;

namespace UOM.Technical.Rest.Questions
{
    public class LastCreatedDimensionAPI : LastCreatedDimension
    {
        protected override MeasurmentDimension Execute<T>(long id, T actor)
        {
            actor.AttemptsTo(Get.ResourceAt($"Dimensions/{id}"));
            return actor.AsksFor(LastResponse.Content<MeasurmentDimension>());
        }
    }
}
