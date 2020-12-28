using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTask.PageOpject
{
    class HomePage
    {
        IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }


        [FindsBy(How = How.CssSelector, Using = "div.jumbotron:nth-child(3) div.container div.col-xs-offset-2.col-xs-8 div.ng-scope > p.ng-scope:nth-child(2)")]
        public IWebElement WelcomeText
        {
            get; set;
        }

        [FindsBy(How = How.LinkText, Using = "Logout")]
        public IWebElement logoutButt
        {
            get; set;
        }

        //[FindsBy(How = How.LinkText, Using = "New Customer")]
        //public IWebElement CustomerLink
        //{
        //    get; set;
        //}

        //[FindsBy(How = How.LinkText, Using = "Delete Customer")]
        //public IWebElement deleteCustomerLink
        //{
        //    get; set;
        //}


        public String Welcometext()
        {
          return  WelcomeText.Text;
        }
        public void logout()
        {
           
           
            logoutButt.Click();

        }

        //public void openCustomerpage()
        //{
        //    CustomerLink.Click();
        //}
        //public void OPenDeletepage()
        //{
        //    deleteCustomerLink.Click();
        //}
    }
  

}
