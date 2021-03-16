using OpenQA.Selenium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;

namespace SeleniumCsharpDotNetBaisc.Base
{
    [TestFixture]
    public class BaseTest
    {
        public IWebDriver Driver;
        [SetUp]
        public void open() {

            Driver = new ChromeDriver();
        }
        [TearDown]
        public void Close() {
            Driver.Quit();
        }
    }
}
