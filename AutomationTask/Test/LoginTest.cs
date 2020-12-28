using AutomationTask.Base_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AutomationTask.PageOpject;
using System.Threading;

namespace AutomationTask.Test
{
    [TestFixture]
    [Order(1)]
    public class LoginTest : BaseClass
    {
        [Test] 
        public void fristTC()
        {
          var login =  new LoginPage(driver);
            var home = new HomePage(driver);
            login.Open_registrationPage();
            //Enter username “angular”
            login.InputUsername();
            //Enter password “password”
            login.InputPassword();
            //Enter username description
            login.InputUsername2();
            //Click Login
            login.PressLogin();
            String ActualText = home.Welcometext();
            String ExpectedText = "You're logged in!!";
            //Check that the page contains text "You're logged in!!"
            Assert.IsTrue(ActualText.Equals(ExpectedText),"welcome text not mett with Srs please check it");
            home.logout();
            //Check that user is logged out successfully
            Assert.IsNotNull(ActualText.Equals(ExpectedText), "logout Not working");
            
           
        }

        



    }
}
