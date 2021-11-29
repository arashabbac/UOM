using OpenQA.Selenium;
using Suzianna.Core.Screenplay;
using Suzianna.Core.Screenplay.Actors;

namespace UOM.Technical.WebUI.Framework.Interactions
{
    public class NavigateToUrl : WebInteraction
    {
        private readonly string _url;

        public NavigateToUrl(string url)
        {
            _url = url;
        }

        public override void Execute(IWebDriver webDriver)
        {
            webDriver.Navigate().GoToUrl(_url);
        }
    }
}
