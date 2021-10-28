using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumTesting
{
    class Program
    {
        static void Main(string[] args)
            {
                IWebDriver driver = new ChromeDriver(@"C:\Users\ss3");
                string url = "http://localhost:21591/";

                driver.Navigate().GoToUrl(url);
                Thread.Sleep(2000);

            IWebElement element = driver.FindElement(By.Id("pizzaList"));
            element.Click();
            Thread.Sleep(2000);


            IWebElement order = driver.FindElement(By.Id("1"));
                order.Click();
                Thread.Sleep(2000);
                IWebElement purchase = driver.FindElement(By.Id("purchase"));
                purchase.Click();

                Thread.Sleep(2000);
                IWebElement back = driver.FindElement(By.Id("back"));
                back.Click();
                Thread.Sleep(5000);
                driver.Quit();
            }
        }
}
