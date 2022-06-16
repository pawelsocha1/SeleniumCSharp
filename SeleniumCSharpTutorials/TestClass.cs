﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTutorials.BaseClass;
namespace SeleniumCSharpTutorials
{
	[TestFixture]
	public class TestClass : BaseTest
	{
		[Test, Category("Smoke Testing")]
		public void TestMethod()
		{
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
			emailTextField.SendKeys("Celenium C#");
            IWebElement monthDropDownList=driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropDownList);
            element.SelectByIndex(1);
            element.SelectByText("Mar");
            element.SelectByValue("6");
		}
        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Celenium C#");
        }
        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Celenium C#");
            Thread.Sleep(5000);

        }

    }
}
