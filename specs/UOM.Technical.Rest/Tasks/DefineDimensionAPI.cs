using Suzianna.Rest.Screenplay.Interactions;
using Suzianna.Rest.Screenplay.Questions;
using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Tasks;

namespace UOM.Technical.Rest.Tasks
{
    public class DefineDimensionAPI : DefineDimension
    {
        public DefineDimensionAPI(MeasurmentDimension dimension) : base(dimension){}

        protected override long Execute<T>(T actor)
        {
            actor.AttemptsTo(Post.DataAsJson(Dimension).To("Dimensions"));
            return actor.AsksFor(LastResponse.Content<long>());
        }
    }
}
