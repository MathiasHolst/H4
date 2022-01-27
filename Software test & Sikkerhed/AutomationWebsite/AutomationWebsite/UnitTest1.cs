using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace AutomationWebsite
{
    public class Tests
    {
        // Hooks
        [Test]
        public void Test_Cursor()
        {
            // Driver
            IWebDriver webDriver = new ChromeDriver();

            // Open site
            webDriver.Navigate().GoToUrl("https://orteil.dashnet.org/cookieclicker/");

            // Maximize window size after load
            webDriver.Manage().Window.Maximize();

            //  Identify cookie
            IWebElement idCookie = webDriver.FindElement(By.Id("bigCookie"));
            IWebElement amountOfCookies = webDriver.FindElement(By.Id("cookies"));

            //  Identify Cursors & Cursors owned
            IWebElement idCursor = webDriver.FindElement(By.Id("product0"));
            IWebElement cursorsOwned = webDriver.FindElement(By.Id("productOwned0"));

            //  Desired amount
            string Cursors = "5";

            //  Operation Buy x amount of Cursors
            while(cursorsOwned.Text != Cursors)
            {
                if(idCursor.GetAttribute("class") == "product unlocked enabled")
                {
                    idCursor.Click();
                }
                idCookie.Click();
            }

            //  Assert
            Assert.That(cursorsOwned.Text == Cursors);
            Assert.That(amountOfCookies.Text != "0");

        }
        [Test]
        public void Test_grandma()
        {
            // Driver
            IWebDriver webDriver = new ChromeDriver();

            // Open site
            webDriver.Navigate().GoToUrl("https://orteil.dashnet.org/cookieclicker/");

            // Maximize window size after load
            webDriver.Manage().Window.Maximize();

            //  Identify cookie
            IWebElement idCookie = webDriver.FindElement(By.Id("bigCookie"));

            //  Identify Cursors & Cursors owned
            IWebElement idGrandma = webDriver.FindElement(By.Id("product1"));
            IWebElement grandmasOwned = webDriver.FindElement(By.Id("productOwned1"));

            //  Desired amount
            string grandmasWanted = "5";

            //  Operation Buy x amount of Cursors
            while (grandmasOwned.Text != grandmasWanted)
            {
                if (idGrandma.GetAttribute("class") == "product unlocked enabled")
                {
                    idGrandma.Click();
                }
                idCookie.Click();
            }

            //  Assert
            Assert.That(grandmasOwned.Text == grandmasWanted);

        }
    }
}