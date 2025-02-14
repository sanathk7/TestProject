using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace RashmiProject.Utilities
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver Driver;

        // Start Browser for Order1
        [BeforeFeature("@Order1")]
        public static void StartBrowserForOrder1()
        {
            if (Driver == null)
            {
                Driver = new ChromeDriver();
                Driver.Manage().Window.Maximize();
                Console.WriteLine("Executing Login First... Browser started.");
            }
        }

        // Ensure Browser is Open for Order2
        [BeforeFeature("@Order2")]
        public static void EnsureBrowserIsOpenForOrder2()
        {
            if (Driver == null)
            {
                Driver = new ChromeDriver();
                Driver.Manage().Window.Maximize();
                Console.WriteLine("Continuing test execution for Shopping/Checkout...");
            }
        }

       
        [BeforeFeature("@Order3")]
        public static void EnsureBrowserIsOpenForOrder3()
        {
            if (Driver == null)
            {
                Driver = new ChromeDriver();
                Driver.Manage().Window.Maximize();
                Console.WriteLine("Continuing test execution for Order3...");
            }
        }
        [BeforeFeature("@Order4")]
        public static void EnsureBrowserIsOpenForOrder4()
        {
            if (Driver == null)
            {
                Driver = new ChromeDriver();
                Driver.Manage().Window.Maximize();
                Console.WriteLine("Continuing test execution for Order3...");
            }
        }

        // Close Browser after Order5 (last feature)
        [AfterFeature("@Order5")]
        public static void CloseBrowser()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver = null;
                Console.WriteLine("Browser Closed after Checkout.");
            }
        }

        // Get Driver instance
        public IWebDriver GetDriver()
        {
            return Driver;
        }
    }
}
