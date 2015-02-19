using System;
using System.Drawing.Imaging;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
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
            driver.Url = "http://google.com/";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(4));
            var image = wait.Until(d =>
                {
                    var img = driver.FindElement(By.Id("hplogo"));
                    return img;
                });
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C://users/chidie/desktop/scrnshot1", ImageFormat.Jpeg);
        }
    }
}
