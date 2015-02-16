using System;
using System.Drawing.Imaging;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taking_Test_ScreenShots
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        [TestInitialize]
        public void setup()
        {
            driver=new FirefoxDriver();
        }
        
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://google.com/");
            
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("scrnshot", ImageFormat.Jpeg);
        }
    }
}
