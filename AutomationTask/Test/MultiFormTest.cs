using AutomationTask.Base_Class;
using AutomationTask.PageOpject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTask.Test
{
    [TestFixture]
    [Order(2)]
    public class MultiFormTest: BaseClass 
    {
        [Test]
        public void fristTC()
        {


            var Multi = new Multi_Form(driver);
            String Name = "Ahmed Abdelzaher";
            String Email = "ahmedzaza881@gmail.com";

            //Go to Multi Form from Homepage
            Multi.OpenMulti_Form();
            //Enter Name and name
            Multi.Setname(Name);
            //Enter Name and Email
            Multi.Set_Email(Email);
            //Click Next
            Multi.Click_Next();
            //choise PS
           String Choise= Multi.Click_CheckPS();
            //Click Next
            Multi.Click_Next();
            //Click Submit
            Multi.Click_Submit();
            ConfirmAlertswich();
            String ActualRsult = Multi.getSuccessTxt();
            //Check that the entered data is displayed in the container below the fields
            Assert.IsTrue(ActualRsult.Contains(Name), "System add Wrong name");
            Assert.IsTrue(ActualRsult.Contains(Email), "System add Wrong Email");
            Assert.IsTrue(ActualRsult.Contains(Choise), "System add Wrong Choise");
            Thread.Sleep(5000);
        }
    }
}
