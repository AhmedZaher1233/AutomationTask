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
    [Order(3)]
   public class CustomerTest : BaseClass
    {
        [Test]
        [Order(1)]

        public void AddUser()
        {
            string username = "Ahmed_Abdelzaher12";


            var user = new Customer(driver);
            user.OpenWebtable();
            //Go to Web Tables from Homepage
            user.OpenUser();
            //Add a new user to the grid by entering all the fields 
            user.Fill_User_data(username);
            //prss save
            user.ClickSave();
            String Actualresult = user.Get_fristusername();
            String Expectedresult = username;
            //Check that the user is added successfully to the grid
            Assert.IsTrue(Actualresult.Equals(Expectedresult), "Not added Successfully");
            user.Set_Search_input(username);
            bool Checked = user.EditBlocke();
            user.ClickSave();

            //Check that the locked checkbox in the grid is now checked
            Assert.IsTrue(Checked, "System not lock user");
            user.delet_User();
            //Check that the user is deleted from the grid
            Assert.IsNotNull(Actualresult, "System not deleted user");
            Thread.Sleep(5000);
        }

        
    }
}
