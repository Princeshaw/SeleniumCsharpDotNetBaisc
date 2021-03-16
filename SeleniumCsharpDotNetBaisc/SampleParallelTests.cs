using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCsharpDotNetBaisc.Base;
using SeleniumCsharpDotNetBaisc.NewFolder;
using System;
using System.Threading;

namespace SeleniumCsharpDotNetBaisc
{
    [TestFixture]
  
    public class Tests
    {
        IWebDriver driver;
        [Test,Category("testing")]
        public void Test1()
        {
            var Driver = new BrowserUtility().Init(driver);
            Driver.Navigate().GoToUrl("https://google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium 1");
            Thread.Sleep(5000);
            Driver.Quit();
           
        }
        [Test, Category("testing")]
        public void Test2()
        {
            var Driver = new BrowserUtility().Init(driver);
            Driver.Navigate().GoToUrl("https://google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium 2");
            Thread.Sleep(5000);
            Driver.Quit();

        }

        [Test, Category("testing")]
        public void Test3()
        {
            var Driver = new BrowserUtility().Init(driver);
            Driver.Navigate().GoToUrl("https://google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium 3");
            Thread.Sleep(5000);
            Driver.Quit();

        }
        [Test, Category("testing")]
        public void Test4()
        {
            var Driver = new BrowserUtility().Init(driver);
            Driver.Navigate().GoToUrl("https://google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium 4");
            Thread.Sleep(5000);
            Driver.Quit();

        }
    }
}