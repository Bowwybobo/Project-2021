using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using AutoTrader.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutoTrader.PageObject
{
    class CarSearchPage
    {
        public CarSearchPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement postCode => driver.FindElement(By.XPath("//*[@id='postcode']"));

        IWebElement cookies => driver.FindElement(By.XPath("//button[text()='Accept All']"));

        IWebElement distance => driver.FindElement(By.XPath("//*[@id='distance']"));

        IWebElement make => driver.FindElement(By.XPath("//*[@id='make']"));

        IWebElement body => driver.FindElement(By.XPath("//span[text()='Coupe']"));

        IWebElement search => driver.FindElement(By.XPath("//*[@id='content']/div/form/div/button[2]"));

        public void  NavigateToWebsite (string url)
        {
            driver.Navigate().GoToUrl(url);
        }


        public void ClickAccept()
        {
            Thread.Sleep(20000);
            driver.SwitchTo().Frame("sp_message_iframe_252633");
            cookies.Click();
            driver.SwitchTo().DefaultContent();
        }


        public void EnterPostCode(string postcode)
        {
            //Thread.Sleep(5000);
            postCode.SendKeys(postcode);

        }


        public void SelectDistance()
        {
            SelectElement select = new SelectElement(distance);
            select.SelectByValue("5");
        }



        public void SelectMake()
        {
            SelectElement select = new SelectElement(make);
            select.SelectByValue("BUGATTI");
        }



        public void ClickBodyType()
        {
            body.Click();
        }


        public void ClickSearch()
        {
            search.Click();
        }

    }
}
