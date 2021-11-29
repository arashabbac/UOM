using BoDi;
using Suzianna.Core.Screenplay;
using Suzianna.Rest.Screenplay.Abilities;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UOM.Technical.Rest.Constants;

namespace UOM.Specs.Hooks
{
    [Binding]
    public class StageSetupHooks
    {
        private readonly IObjectContainer _container;

        public StageSetupHooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("API-Level")]
        public void StageSetup()
        {
            var cast = Cast.WhereEveryoneCan(new List<IAbility> { CallAnApi.At(ApiConstants.BaseUrl) });
            var stage = new Stage(cast);
            _container.RegisterInstanceAs(stage);
        }
    }
}
