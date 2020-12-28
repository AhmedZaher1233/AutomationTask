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
    [Order(4)]
    class CalculatorTest : BaseClass
    {
        [Test]
        [Order(1)]
        //test case for calculation page
        public void AddTwoNumber()
        {
            var Add = new CalculatorPage(driver);
            int input1 = 4;
            int input2 = 4;
            Add.openCalculator();
            //Add 2 numbers
            Add.EnterfristValue(input1.ToString());
            Add.EnterSecondValue(input2.ToString());
            Add.PressGo();
            String ActualResult = Add.GetResult();
            int ExpectedlResult = input1 + input2;
            //Check that the expression and result are correct in the grid
            Assert.IsTrue(ActualResult.Equals(ExpectedlResult.ToString()), "Not worked Successfully");
           
          
        }


    }
}
