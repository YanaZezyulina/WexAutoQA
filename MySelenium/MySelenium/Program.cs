using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MySelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

           
            driver.Url = "https://yandex.by/";
            //if robot test will come up uncomment
            /*IWebElement reCapcha = driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[3]/div/form/div/div[1]/input"));
            reCapcha.Click();

            System.Threading.Thread.Sleep(5000);*/

            IWebElement logInButton = driver.FindElement(By.XPath("//*[@data-statlog-showed='1']"));

            logInButton.Click();

            var email = driver.FindElement(By.XPath("//input[@type = 'text'][@placeholder = 'Телефон или почта']"));
           
            email.SendKeys("123445");

            var loginPageTitle = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div[2]/div/div/div[2]/div[3]/div/div/div/h1/span"));

            var submit = driver.FindElement(By.XPath("//*[@id='passp:sign-in']"));

            submit.Click();

            var errorMessageText = driver.FindElement(By.XPath("//div[@class='Textinput-Line']/following-sibling::div[1]"));
            // driver.Close();

        }
    }
}
