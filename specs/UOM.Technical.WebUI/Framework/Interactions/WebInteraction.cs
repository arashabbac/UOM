using OpenQA.Selenium;
using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;

namespace UOM.Technical.WebUI.Framework.Interactions
{
    public abstract class WebInteraction : IInteraction
    {
        public void PerformAs<T>(T actor) where T : Actor
        {
            var ability = actor.FindAbility<BrowseTheWeb>();

            if (ability == null) throw new ActorIsUnableException<BrowseTheWeb>(actor);

            Execute(ability.Driver);
        }

        public abstract void Execute(IWebDriver webDriver);
    }
}
