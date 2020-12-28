using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTask.PageOpject
{
    class Multi_Form
    {
        IWebDriver driver;
        Random rnd = new Random();
        public Multi_Form(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }


        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Multi Form')]")]
        public IWebElement MultiForm
        {
            get; set;
        }

        [FindsBy(How = How.Name, Using = "name")]
        public IWebElement Name
        {
            get; set;
        }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement Email
        {
            get; set;
        }

        [FindsBy(How = How.Name, Using = "00A")]
        public IWebElement CheckBox
        {
            get; set;
        }

        [FindsBy(How = How.PartialLinkText, Using = "Next Secti")]
        public IWebElement Next
        {
            get; set;
        }

      
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Submit')]")]
        public IWebElement Submit
        {
            get; set;
        }

        [FindsBy(How = How.TagName, Using = "pre")]
        public IWebElement SuccessSubmitTxt
        {
            get; set;
        }


        public void OpenMulti_Form()
        {
            MultiForm.Click();
        }

        public void Setname(String name)
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Name.SendKeys(name);
        }

        public void Set_Email(String email)
        {
            Email.SendKeys(email);
        }
        public void Click_Next()
        {
            Next.Click();
        }

        public String Click_CheckPS()
        {
            CheckBox.Click();
            return "ps";
        }

        public String getSuccessTxt()
        {
            return SuccessSubmitTxt.Text;
                
        }
        public void Click_Submit()
        {
            Submit.Click();
        }

    }

}
