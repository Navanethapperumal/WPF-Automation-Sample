using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace CalculatorUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Application application = null;
            Window window = null;
            application = Application.Launch(@"F:\Navaneethapperumal\Works\WPF\Automation\SimpleCalculator\SimpleCalculator\bin\Debug\SimpleCalculator.exe");

            var windows = application.GetWindows();
            // window = windows[0];  
            window = windows.Find(x => x.Title == "MainWindow");
            TextBox firstNumber = window.Get<TextBox>(SearchCriteria.ByAutomationId("firstNumber"));
            Thread.Sleep(3000);
            firstNumber.SetValue("4");
            TextBox secondNumber = window.Get<TextBox>(SearchCriteria.ByAutomationId("secondNumber"));
            secondNumber.SetValue("6");
            Thread.Sleep(3000);
            Button calculateBtn = window.Get<Button>(SearchCriteria.ByAutomationId("calculateButton"));
            calculateBtn.Click();
            Thread.Sleep(3000);
            TextBox resultValue = window.Get<TextBox>(SearchCriteria.ByAutomationId("resultTxtBox"));
            Assert.IsTrue(Convert.ToDouble(resultValue.Text) == 10);

            RadioButton subtraction = window.Get<RadioButton>(SearchCriteria.ByAutomationId("subRadioButton"));
            subtraction.Click();
            Thread.Sleep(1000);
            calculateBtn.Click();
            Assert.IsTrue(Convert.ToDouble(resultValue.Text) == -2);
            Thread.Sleep(3000);
            application.Close();
        }
    }
}
