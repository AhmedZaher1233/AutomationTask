using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
namespace AutomationTask.PageOpject
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }


        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Registration')]")]
        public IWebElement Loginpage { get; set; }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement UsernameField { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#formly_1_input_username_0")]
        public IWebElement Username2Field { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        public IWebElement LoginButton { get; set; }


        //public void SwitchToLoginWindows()
        //{
        //    driver.SwitchTo().Window(driver.WindowHandles.Last());

        //}

        public void Open_registrationPage ()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");

            Loginpage.Click();
        }

        public void InputUsername()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            UsernameField.SendKeys("angular");

        }
        public void InputPassword()
        {
            PasswordField.SendKeys("password");
        }

        public void InputUsername2()
        {
            Username2Field.SendKeys("angular");

        }
        public void PressLogin()
        {
            LoginButton.Click();
        }
    }


}
