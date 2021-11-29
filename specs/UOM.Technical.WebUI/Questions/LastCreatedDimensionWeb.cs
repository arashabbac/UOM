using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Questions;

namespace UOM.Technical.WebUI.Questions
{
    public class LastCreatedDimensionWeb : LastCreatedDimension
    {
        protected override MeasurmentDimension Execute<T>(long id, T actor)
        {
            throw new NotImplementedException();
        }
    }
}
