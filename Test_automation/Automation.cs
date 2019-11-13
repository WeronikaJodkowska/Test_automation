using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_automation
{
    class Automation
    {
        IWebDriver SeleniumDriver;

        [SetUp]
        public void Start()
        {
            SeleniumDriver = new ChromeDriver();
        }

        [Test]
        public void Test()
        {
            SeleniumDriver.Url = "https://www.google.by";
            string text = "iTechArt";

            IWebElement element1 = SeleniumDriver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));
            element1.SendKeys(text);
            element1.Submit();
            Console.WriteLine("Page title is: " + SeleniumDriver.Title);
            IWebElement element2 = SeleniumDriver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div/div[1]/a/h3"));
            IWebElement element3 = SeleniumDriver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div/div[2]/div/span"));
            Console.WriteLine(element2.Text.Contains(text));
            Console.WriteLine(element3.Text.Contains(text));
        }

        [TearDown]
        public void Stop()
        {
            SeleniumDriver.Close();
        }
    }
}