using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTask.PageOpject
{
    class Customer
    {
        IWebDriver driver;
       
        public Customer(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

            //Element of Web Table
        }
        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'WebTables')]")]
        public IWebElement Webtable
        {
            get; set;
        }

        //Element of Add New user
        [FindsBy(How = How.XPath, Using = "//thead/tr[2]/td[1]/button[1]")]
        public IWebElement AdduserButton
        {
            get; set;
        }

        //Element of FirstName textbox
        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement FirstName
        {
            get; set;
        }
        //Element of LastName textbox
        [FindsBy(How = How.Name, Using = "LastName")]
        public IWebElement LastName
        {
            get; set;
        }
        //Element of UserName textbox
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement UserName
        {
            get; set;
        }
        //Element of Password textbox
        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement Password
        {
            get; set;
        }
        //Element of Compony textbox
        [FindsBy(How = How.XPath, Using = "//tbody/tr[5]/td[2]/label[1]/input[1]")]
        public IWebElement Compny
        {
            get; set;
        }

        //Element of Role DDL
        [FindsBy(How = How.TagName, Using = "select")]
        public IWebElement Role
        {
            get; set;
        }
        //Element of email textbox
        [FindsBy(How = How.Name, Using = "Email")]
        public IWebElement Email
        {
            get; set;
        }
        //Element of Mobilephone textbox
        [FindsBy(How = How.Name, Using = "Mobilephone")]
        public IWebElement Mobilephone
        {
            get; set;
        }

        //Element of Save button
        [FindsBy(How = How.CssSelector, Using = "body.ng-scope:nth-child(2) div.modal.ng-scope:nth-child(11) div.modal-footer > button.btn.btn-success:nth-child(2)")]
        public IWebElement SaveButton
        {
            get; set;
        }
        //Elements of grid 

        [FindsBy(How = How.XPath, Using = "//tbody/tr[8]/td")]
        public IList<IWebElement> ListOfRows
        {
            get; set;
        }
        //Element of Search textbox
        [FindsBy(How = How.XPath, Using = "//thead/tr[1]/td[1]/input[1]")]
        public IWebElement Search
        {
            get; set;
        }

        //Element of EditButton
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[10]/button[1]")]
        public IWebElement Edit
        {
            get; set;
        }
        //Element of Locj checkbox
        [FindsBy(How = How.XPath, Using = "//tbody/tr[9]/td[2]/label[1]/input[1]")]
        public IWebElement Lokced
        {
            get; set;
        }

        //Element of Delete Button

        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[11]/button[1]/i[1]")]
        public IWebElement Deletebutton
        {
            get; set;
        }

         //Element of Confirmation button in popup message
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'OK')]")]
        public IWebElement Confirm
        {
            get; set;
        }

        //Element of UserName in frist row

        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[3]")]
        public IWebElement UsernameFristrow
        {
            get; set;
        }







        public void OpenWebtable()
        {
            //Scrolling to end page 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
            //Action click on Element
            Webtable.Click();
            //Swiching for last windows open in driver
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        //fill all user data
        public void Fill_User_data(String username)
        {

            FirstName.SendKeys("Ahmed");
            LastName.SendKeys("Abdelzaher");
            UserName.SendKeys(username);
            Password.SendKeys("dev@1234");
            Compny.Click();
            var selectElement = new SelectElement(Role);
            selectElement.SelectByIndex(1);
            Email.SendKeys("ahmedzaza881@gmail.com");
            Mobilephone.SendKeys("01157345552");


        }

        public void ClickSave()
        {
            SaveButton.Click();
        }

        public void OpenUser()
        {
            AdduserButton.Click();
        }

        public int Counct_rows()
        {
            int coun = ListOfRows.Count;
            return coun;
        }

        public void Set_Search_input(String username)
        {
            Search.SendKeys(username);

        }
        public bool EditBlocke()
        {
            Edit.Click();

            Lokced.Click();
           bool Checked = Lokced.Selected;
            return Checked;
        }

        public void delet_User()
        {
            Deletebutton.Click();
            Confirm.Click();
        }

        public String Get_fristusername()
        {
            return UsernameFristrow.Text;
        }
    }
}
