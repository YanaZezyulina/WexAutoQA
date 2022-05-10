using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace MySelenium
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;
        protected ILogger _logger;

        public BasePage(IWebDriver driver, ILogger logger)
        {
            _driver = driver;
            _logger = logger;
        }
        public IWebElement FindElementByXpath(string xPath)
        {
            //var titleText = _driver.FindElements(By.XPath("//*[@id='root']/div/div[2]/div[2]/div/div/div[2]/div[3]/div/div/div/h1/span"));

            IWebElement element = null;

            int attempsNumber = 0;
            
            while (attempsNumber < 10)
            {
                try
                {
                    element = _driver.FindElement(By.XPath(xPath));
                }
                catch (Exception exp)
                {
                    Thread.Sleep(1000);
                    _logger.Log("Can't find element, will try again");
                }
                if (element != null)
                {
                    break;
                }
                attempsNumber++;
            }
            return element;
        }
    }
}
