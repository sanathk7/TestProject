using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RashmiProject.Utilities;

namespace RashmiProject.Pages
{
    internal class CheckOutPage
    {
        private IWebDriver driver = Hooks.Driver;



        By checkout = By.XPath("//button[@id='checkout']");
        By checkoutpage = By.XPath("//span[@class='title']");
        By firstname = By.XPath("//input[@id='first-name']");
        By lastname = By.XPath("//input[@id='last-name']");
        By zipcode = By.XPath("//input[@id='postal-code']");
        By countinue = By.XPath("//input[@id='continue']");

        public void CheckOut()
        {
            driver.FindElement(checkout).Click();
        }

        public void CheckOutpage()
        {
            if (driver.FindElement(checkoutpage).Text == "Checkout: Your Information")
            {
                Console.WriteLine("User In checkoutpage");
            }

            else
            {
                Console.WriteLine("User Not in checkout page");
            }
        }

        public void BuyerDetail(string fname, string lname, string zip)
        {
            driver.FindElement(firstname).SendKeys(fname);
            driver.FindElement(lastname).SendKeys(lname);
            driver.FindElement(zipcode).SendKeys(zip);

        }

        public void Countniue()
        {
            driver.FindElement(countinue).Click();
        }


    }
}
