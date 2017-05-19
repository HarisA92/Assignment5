using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Assignment5
{
    [TestClass]
    public class UnitTest1
    {
//assignment 5
        public void chrome(){
            ChromeDriver chromedriver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
            driver.FindElementById("email").SendKeys("harisaljovic92@hotmail.com");
            driver.FindElementById("pass").SendKeys("***");
            driver.FindElementById("email").SendKeys(Keys.Tab);           
            driver.FindElementById("pass").SendKeys(Keys.Tab);
            driver.FindElementById("loginbutton").SendKeys(Keys.Enter);
        }
//ne znam zasto nece da radi iako sam add reference.

        [TestMethod]
        public void TestMethod1(){
            bool password = Helper.IsPasswordOkay("harisaljovic");
            Assert.AreEqual(password, false);
        }
        [TestMethod]
        public void TestMethod2(){
            bool mail = Helper.IsMailOkay("aljovicgazdahotmail.com");
            Assert.AreEqual(mail, false);
        }
    }
}
