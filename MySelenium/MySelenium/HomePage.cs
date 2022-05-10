using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MySelenium
{
    //POM page object model
    public class HomePage: BasePage
    {
        const string LOGIN_BUTTON_XPATH = "/html/body/div[1]/div[1]/div/div[1]/div/div/a[1]";

        IWebElement _logInButton = null;

        public HomePage(IWebDriver driver, ILogger logger) : base (driver, logger)
        {
            _logInButton = FindElementByXpath(LOGIN_BUTTON_XPATH);
        }

        public LoginPage GoToLoginPage()
        {
            _logInButton?.Click();
            return new LoginPage(_driver, _logger);
        }

        

        public string GetLoginButtonColor()
        {
            return _logInButton?.GetCssValue("color");
        }
    }
}
