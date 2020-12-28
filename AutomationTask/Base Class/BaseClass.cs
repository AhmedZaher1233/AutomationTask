
using NUnit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using NUnit.Framework;
using AutomationTask;
using OpenQA.Selenium.Firefox;
using System;

namespace AutomationTask.Base_Class
{

    public class BaseClass
    {
        public IWebDriver driver;
        [SetUp]

        public void Open()
        {
            //Open firfoxDiver
            driver = new FirefoxDriver(); 
            //Maxmize the windows
            driver.Manage().Window.Maximize();
            //Implicitwait fOR ALL element
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Go to Homepage (Base URL “
            driver.Url= "http://www.way2automation.com/protractor-angularjs-practice-website.html#";

        }
        [TearDown]
        public void Close()
        {
           // Close driver after test
            driver.Quit();
        }


        //Accept Button on any alert message 
        public void ConfirmAlertswich()
        {
            var alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        //Dismiss Button on any alert message 
        public void CancelAlertswich()
        {
            var alert = driver.SwitchTo().Alert();
            alert.Dismiss();
        }

    }
}
