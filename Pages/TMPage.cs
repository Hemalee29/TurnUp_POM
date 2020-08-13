using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TurnUp_POM.Pages
{
    class TMPage
    {
        //Function to create new TM
        public void CreateTM(IWebDriver driver)
        {
            //click new button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            Thread.Sleep(1000);

            //select type  code form the drodown list
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();


            //input code value
            driver.FindElement(By.Id("Code")).SendKeys("August2020");

            //input a description
            driver.FindElement(By.Id("Description")).SendKeys("this is automation testing");

            //input price per unit

            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.Id("Price")).SendKeys("550");

            //click save button
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(1000);

            //goto last page
            driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[4]//a[4]//span")).Click();
            Thread.Sleep(1000);
            //cheak if the created time material is present

            IWebElement actualcode = driver.FindElement(By.XPath(".//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (actualcode.Text == "August2020")
            {
                Console.WriteLine("Time record create succefully, test passed");
            }
            else
            {
                Console.WriteLine("Time record not create succefully, test failed");
            }


        }

        //Function to Edit exixitng TM

        public void EditTM(IWebDriver driver)
        {
            Console.WriteLine("Check if the user is able to edit an existing time/ material record successfully with valid details");


            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[5]/a[1]")).Click();
            Thread.Sleep(2000);

          

            driver.FindElement(By.Id("Code")).Click();
            //code.Click();
            driver.FindElement(By.Id("Code")).Clear();
            //code.Clear();
            driver.FindElement(By.Id("Code")).SendKeys("Hello world");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(3000);

            Console.WriteLine("Edit Successfully into the record");

        }

        //Function to delete TM

        public void DeleteTM(IWebDriver driver)
        {
            //Delete

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[9]/td[5]/a[2]")).Click();
            Console.WriteLine("Deleted Succesfully");
        }
    }
}
