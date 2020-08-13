using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TurnUp_POM.Pages
{
    class HomePage
    {
        //Steps to login to Turnup portal
        public void NavigateToTM(IWebDriver driver)
        {
            //navigate time and material page

            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

        }
    }
}
