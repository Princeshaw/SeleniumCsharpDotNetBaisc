using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCsharpDotNetBaisc.Base;
using SeleniumCsharpDotNetBaisc.Utilities;
using System;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace SeleniumCsharpDotNetBaisc
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;
        ExtentReports extent =null;
        [OneTimeSetUp]
        public void ExtentReport() {
            extent = new ExtentReports();
            var htmLReporter = new ExtentHtmlReporter(@"C:\Users\princ\OneDrive\Desktop\Automation\SeleniumCsharpDotNetBaisc\SeleniumCsharpDotNetBaisc\ExtentReports\Tests.html");
            extent.AttachReporter(htmLReporter);

        }

        [OneTimeTearDown]
        public void ExtentClose() {
            extent.Flush();
        }


        [Test,Category("testing")]
        public void Test1()
        {
            ExtentTest test = null;

            test = extent.CreateTest("Test 1").Info("Test started");

            var Driver = new BrowserUtility().Init(driver);

            Driver.Navigate().GoToUrl("https://google.com");

            test.Log(Status.Info, "Launching the app");

            Driver.FindElement(By.Name("q")).SendKeys("Selenium 1");

            test.Log(Status.Info, "Sending search data");
            Thread.Sleep(5000);
            test.Log(Status.Info, "Sleep of 5 sec");

            Driver.Quit();
            test.Log(Status.Pass, "Test 1 passed");


        }
        [Test, Category("testing")]
        public void Test2()
        {
            ExtentTest test = null;

            test = extent.CreateTest("Test 2").Info("Test started");

            var Driver = new BrowserUtility().Init(driver);

            Driver.Navigate().GoToUrl("https://google.com");

            test.Log(Status.Info, "Launching the app");

            Driver.FindElement(By.Name("q")).SendKeys("Selenium 2");

            test.Log(Status.Info, "Sending search data");
            Thread.Sleep(5000);
            test.Log(Status.Info, "Sleep of 5 sec");

            Driver.Quit();
            test.Log(Status.Pass, "Test 1 passed");


        }

        [Test, Category("testing")]
        public void Test3()
        {
            ExtentTest test = null;

            test = extent.CreateTest("Test 3").Info("Test started");

            var Driver = new BrowserUtility().Init(driver);

            Driver.Navigate().GoToUrl("https://google.com");

            test.Log(Status.Info, "Launching the app");

            Driver.FindElement(By.Name("q")).SendKeys("Selenium 1");

            test.Log(Status.Info, "Sending search data");
            Thread.Sleep(5000);
            test.Log(Status.Info, "Sleep of 5 sec");

            Driver.Quit();
            test.Log(Status.Pass, "Test 1 passed");

        }
        [Test, Category("testing")]
        public void Test4()
        {
            ExtentTest test = null;

            test = extent.CreateTest("Test 4").Info("Test started");

            var Driver = new BrowserUtility().Init(driver);

            Driver.Navigate().GoToUrl("https://google.com");

            test.Log(Status.Info, "Launching the app");

            Driver.FindElement(By.Name("q")).SendKeys("Selenium 1");

            test.Log(Status.Info, "Sending search data");
            Thread.Sleep(5000);
            test.Log(Status.Info, "Sleep of 5 sec");

            Driver.Quit();
            test.Log(Status.Pass, "Test 1 passed");

        }
    }
}