using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TurnUp_POM.Pages
{
    class LoginPage
    {

        //Steps to login to Turnup portal
        public void LoginSteps(IWebDriver driver)
        {
            
            Thread.Sleep(1000);
            //open the turn up portal 
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(1000);

            //maximize the browser
            driver.Manage().Window.Maximize();

            //find the username textbox and enter username

            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");
            //find password textbox and enter password

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            //find the logi  button
            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginbutton.Click();

            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (hellohari.Text == "Hello hari!")
            {

                Console.WriteLine("logged in succefully, test passed");
            }

            else
            {
                Console.WriteLine("logged in not succefully,test failed");
            }

        }
    }
}
