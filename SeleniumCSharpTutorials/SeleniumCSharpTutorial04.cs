using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        [Test]
        [Author("Pawel Socha 12908", "pawel.socha@microsoft.wsei.edu.pl")]
        [Description("Facebook login verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://pl-pl.facebook.com/";

                driver.Url = urlName;

                IWebElement email = driver.FindElement(By.XPath(".//*[@id='email']"));
                //IWebElement email = driver.FindElement(By.XPath(".//*[@id='abcd ']"));
                email.SendKeys("Selenium C#");

                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\user\\source\\repos\\SeleniumCSharp\\SeleniumCSharpTutorials\\Screenshots\\Screenshot1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();

            list.Add("https://pl-pl.facebook.com/");
            /*list.Add("https://youtube.com/");
            list.Add("https://gmail.com/");*/
            return list;
        }
    }
}
