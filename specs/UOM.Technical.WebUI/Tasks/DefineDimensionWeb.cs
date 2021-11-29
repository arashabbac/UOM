using OpenQA.Selenium;
using UOM.Specs.Shared.Models;
using UOM.Specs.Shared.Tasks;
using UOM.Technical.WebUI.Framework.Interactions;

namespace UOM.Technical.WebUI.Tasks
{
    public class DefineDimensionWeb : DefineDimension
    {
        public DefineDimensionWeb(MeasurmentDimension dimension) : base(dimension) { }

        protected override long Execute<T>(T actor)
        {
            //TODO ... add UI project
            actor.AttemptsTo(
                new NavigateToUrl(""),
                new Click(By.Id("addDimensionBtn")),
                new FillInput(By.Id("name"),Dimension.Name),
                new FillInput(By.Id("symbol"), Dimension.Symbol),
                new Click(By.Id("saveBtn"))
                );

            
            return 0; //TODO
        }
    }
}
