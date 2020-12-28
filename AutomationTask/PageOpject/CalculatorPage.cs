using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTask.PageOpject
{
    class CalculatorPage
    {
        IWebDriver driver;

        public CalculatorPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        //elemnt of calculator page
        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Calculator')]")]
        public IWebElement Calculator
        {
            get; set;
        }

        //elemnt of frist input
        [FindsBy(How = How.XPath, Using = "//body/div[3]/div[1]/form[1]/input[1]")]
        public IWebElement Input1
        {
            get; set;
        }

        //elemnt of Second input
        [FindsBy(How = How.XPath, Using = "//body/div[3]/div[1]/form[1]/input[2]")]
        public IWebElement Input2
        {
            get; set;
        }
        //elemnt of Go Button 
        [FindsBy(How = How.XPath, Using = "//button[@id='gobutton']")]
        public IWebElement Go
        {
            get; set;
        }

        //elemnt of Go Result

        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[3]")]
        public IWebElement Result
        {
            get; set;
        }



        //Go to Calculator page 
        public void openCalculator ()
        {
            //Scrolling to end page 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
           //Action click on Element
            Calculator.Click();
            //Swiching for last windows open in driver
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        //Send value to textbox1
        public void EnterfristValue(String input)
        {
            Input1.SendKeys(input);
        }

        //Send value to textbox2
        public void EnterSecondValue(String input)
        {
            Input2.SendKeys(input);
        }

        //press on Go button

        public void PressGo()
        {
            Go.Click();
        }

        //Get result after  calculated
        public String GetResult()
        {
           return Result.Text;
        }

    }
}
