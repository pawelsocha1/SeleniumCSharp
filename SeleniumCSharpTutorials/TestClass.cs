// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;
namespace SeleniumCSharpTutorials
{
	[TestFixture]
	public class TestClass : BaseTest
	{
		[Test]
		public void TestMethod()
		{
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Celenium C#");
		}
        [Test]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Celenium C#");
        }
        [Test]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Celenium C#");
            Thread.Sleep(5000);
        }

    }
}
