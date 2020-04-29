using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAutomationFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver _driver = new ChromeDriver(); //initialize the driver
            _driver.Navigate().GoToUrl("https://www.google.com/"); //open the browser to the specified URL

            // Find an element
            IWebElement searchBar = _driver.FindElement(By.XPath("//input[@id='fakebox-input']"));

            // _driver.Quit(); close all browser windows
            _driver.Close();// close the current browser window
        }
    }
}
