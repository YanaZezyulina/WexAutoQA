using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MySelenium
{
    public class LoginPage : BasePage
    {
        const string EMAIL_INPUT_BOX_XPATH = "//input[@type = 'text'][@placeholder = 'Телефон или почта']";

        const string LOGIN_PAGE_TITLE_XPATH = "//*[@id='root']/div/div[2]/div[2]/div/div/div[2]/div[3]/div/div/div/h1/span";

        const string ERROR_MESSAGE_LOGIN_PAGE_XPATH = "//div[@class='Textinput-Line']/following-sibling::div[1]";

        IWebElement _emailEditBox = null;

        public LoginPage(IWebDriver driver, ILogger logger) : base(driver, logger)
        {
            _emailEditBox = FindElementByXpath(EMAIL_INPUT_BOX_XPATH);

        }

        public void Login(string email)
        {
            _emailEditBox?.SendKeys(email);
            _logger.Log("Clicked");
        }


        public string TitleOnTheLoginPageAppeared()
        {
            IWebElement _loginPageTitle = null;
            _loginPageTitle = FindElementByXpath(LOGIN_PAGE_TITLE_XPATH);
            string loginPageTitleText = _loginPageTitle.Text;
            return loginPageTitleText;
        }

        public string ErrorMessageOnTheLoginPageAppeared()
        {
            IWebElement _errorMessage = null;
            _errorMessage = FindElementByXpath(ERROR_MESSAGE_LOGIN_PAGE_XPATH);
            string errorMessage = _errorMessage.Text;
            return errorMessage;
        }
    }
}
