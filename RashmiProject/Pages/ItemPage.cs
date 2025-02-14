using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RashmiProject.Utilities;

namespace RashmiProject.Pages
{
    internal class ItemPage
    {
        private IWebDriver driver = Hooks.Driver;

        By item = By.XPath("//div[normalize-space()='Sauce Labs Backpack']");
        By item_details = By.XPath("//button[@id='back-to-products']");
        public void Item()
        {
            driver.FindElement(item).Click();
        }

        public void ItemDetail()
        {
            if (driver.FindElement(item_details).Text == "Back to products")
            {
                Console.WriteLine("User In Product detail");
            }

            else
            {
                Console.WriteLine("User Not in Product detail");
            }
        }
    }
}
