using BoDi;
using Suzianna.Core.Screenplay;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UOM.Technical.WebUI.Framework;

namespace UOM.Specs.Hooks
{
    [Binding]
    public class StageSetupWebHook
    {
        private readonly IObjectContainer _container;
        private BrowseTheWeb _browseTheWeb;
        public StageSetupWebHook(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("UI-Level")]
        public void StageSetup()
        {
            _browseTheWeb = new BrowseTheWeb();
            var cast = Cast.WhereEveryoneCan(new List<IAbility> { _browseTheWeb });
            var stage = new Stage(cast);
            _container.RegisterInstanceAs(stage);
        }

        [AfterScenario("UI-Level")]
        public void DisposeAbility()
        {
            _browseTheWeb.Dispose();
        }
    }
}
