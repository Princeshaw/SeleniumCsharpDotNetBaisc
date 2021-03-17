using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace SeleniumCsharpDotNetBaisc.Utilities
{
    [TestFixture]
    public class BrowserUtility
    {
        
        public IWebDriver Init(IWebDriver driver) {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");
            chromeOptions.AddArgument("maximize");

            driver = new ChromeDriver(chromeOptions);
            return driver;
        }

    }
}
