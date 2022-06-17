using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTutorials.BaseClass
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test, Order(2), Category("OrderSkipAttribute")]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://pl-pl.facebook.com/";
            IWebElement email = driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Order(2), Category("OrderSkipAttribute")]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://pl-pl.facebook.com/";
            IWebElement email = driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium C#");
            driver.Close();
        }

    }
}
