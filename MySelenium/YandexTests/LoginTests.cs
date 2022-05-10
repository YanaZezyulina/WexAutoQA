using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MySelenium;

namespace YandexTests
{
    [TestClass]
    public class LoginTests 
    {
        [TestMethod]
        public void LoginPageOpenTest()
        {

            //IWebElement reCapcha = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[3]/div/form/div/div[1]/input"));
            //reCapcha.Click();

            //System.Threading.Thread.Sleep(5000);

            WebDriver driver = new ChromeDriver();
            
            driver.Url = "https://yandex.by/";

            driver.Manage().Window.Maximize();

             

            ILogger logger = new FileLogger();
            //----
            HomePage homePage = new HomePage(driver, logger);

            LoginPage loginPage = homePage.GoToLoginPage();
            // Assert.IsTrue(loginPage._driver);
            var loginPageTitleText = loginPage.TitleOnTheLoginPageAppeared();
            //Assert.IsNotNull(loginPageTitleText);
            
            Assert.IsTrue(loginPageTitleText.Contains("Войдите с Яндекс ID"));

            //test when email is incorrect. Negative case
            var errorMessage = loginPage.ErrorMessageOnTheLoginPageAppeared();

            Assert.IsTrue(errorMessage.Contains("Такой логин не подойдет"));

            driver.Close();
        }
    }
}
