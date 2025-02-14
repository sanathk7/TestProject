using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RashmiProject.Utilities;

namespace RashmiProject.Pages
{
    internal class CheckOverviewPage
    {
        private IWebDriver driver = Hooks.Driver;

        By checkoutoverview = By.XPath("//span[@class='title']");
        By finish = By.XPath("//button[@id='finish']");
        By orderconfirm = By.XPath("//h2[normalize-space()='Thank you for your order!']");

        public void CheckOutOverview()
        {
            if (driver.FindElement(checkoutoverview).Text == "Checkout: Overview")
            {
                Console.WriteLine("User In checkout Overview");
            }

            else
            {
                Console.WriteLine("User Not in checkout overview");
            }
        }

        public void Finish()
        {
            driver.FindElement(finish).Click();
        }

        public void OrderConfirm()
        {
            if (driver.FindElement(orderconfirm).Text == "Thank you for your order!")
            {
                Console.WriteLine("\"Thank you for your order!\"");
            }

            else
            {
                Console.WriteLine("Order was Not placed");
            }
            driver.Dispose();
        }

    }
}
