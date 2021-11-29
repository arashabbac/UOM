using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Suzianna.Core.Screenplay;

namespace UOM.Technical.WebUI.Framework
{
    public class BrowseTheWeb : IAbility,IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public BrowseTheWeb()
        {
            //TODO  : remove hard coded path
            string path = @"C:\Users\Arash\source\repos\UOM\specs\UOM.Technical.WebUI\bin\Debug\net6.0";
            Driver = new ChromeDriver(path);
        }

        public void Dispose()
        {
            Driver?.Close(); 
            Driver?.Dispose();
        }
    }
}
