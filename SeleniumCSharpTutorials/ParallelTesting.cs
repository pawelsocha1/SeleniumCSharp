// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTutorials.BaseClass;
using SeleniumCSharpTutorials.Utilities;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class ParallelTesting
    {

        IWebDriver driver;
        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test1()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement email = Driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium C#");
            Driver.Close();


        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test2()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement email = Driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium C#");
            Driver.Close();


        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test3()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement email = Driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium C#");
            Driver.Close();


        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test4()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement email = Driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium C#");
            Driver.Close();


        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test5()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement email = Driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium C#");
            Driver.Close();


        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test6()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement email = Driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium C#");
            Driver.Close();


        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test7()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement email = Driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium C#");
            Driver.Close();


        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test8()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement email = Driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium C#");
            Driver.Close();


        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test9()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement email = Driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium C#");
            Driver.Close();


        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test10()
        {
            var Driver = new BrowserUtility().Init(driver);
            IWebElement email = Driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium C#");
            Driver.Close();


        }
    }
}
