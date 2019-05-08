﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace Selenium.Test
{
    [TestFixture]
    public class BrowserTests
    {
        private static IWebDriver _chrome;
        private static IWebDriver _edge;

        [SetUp]
        public static void SetUp()
        {
            _chrome = new ChromeDriver(@"D:\Chrome");
            _edge = new EdgeDriver(@"D:\Chrome");
        }

        [Test]
        public void GoToIndex()
        {
            _chrome.Navigate().GoToUrl("https://google.com.pe");
            _edge.Navigate().GoToUrl("https://www.microsoft.com");
        }
    }
}
