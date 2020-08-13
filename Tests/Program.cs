using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TurnUp_POM.Pages;

namespace TurnUp_POM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //init driver

            IWebDriver driver = new ChromeDriver();

            //Login page object init and defination
            LoginPage loginobj = new LoginPage();
            loginobj.LoginSteps(driver);

            //Home page object init and defination
            HomePage homeobj = new HomePage();
            homeobj.NavigateToTM(driver);

            //TM page object init and defination
            TMPage tmobj = new TMPage();
            tmobj.CreateTM(driver);

            //Edit existing TM test
            tmobj.EditTM(driver);

            //Delete exsiting TM test
            tmobj.DeleteTM(driver);


        }
    }
}
