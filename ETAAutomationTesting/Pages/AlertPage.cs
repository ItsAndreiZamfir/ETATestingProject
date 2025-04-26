using ETAAutomationTesting.HelperMethods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.Pages
{
    public class AlertPage : BasePage
    {
        private AlertMethods alertMethods;
        public AlertPage(IWebDriver webDriver) : base(webDriver)
        {
            alertMethods = new AlertMethods(webDriver);
        }

        private IWebElement alertButton => WebDriver.FindElement(By.XPath("//button[@id='alertButton']"));
        private IWebElement timerAlertButton => WebDriver.FindElement(By.XPath("//button[@id='timerAlertButton']"));
        private IWebElement confirmAlertButton => WebDriver.FindElement(By.XPath("//button[@id='confirmButton']"));
        private IWebElement confirmAlertText => WebDriver.FindElement(By.XPath("//span[@id='confirmResult']"));
        private IWebElement promtAlertButton => WebDriver.FindElement(By.XPath("//button[@id='promtButton']"));
        private IWebElement promtAlertText => WebDriver.FindElement(By.XPath("//span[@id='promptResult']"));

        public void HandleFirstAlert()
        {
            elementMethods.ClickElement(alertButton);
            alertMethods.AcceptAlert();
        }

        public void HandleTimerAlert()
        {
            elementMethods.ClickElement(timerAlertButton);
            alertMethods.AcceptAlert(); //It will wait for 5 seconds for the alert to appear
        }

        public string GetConfirmAlertText(string option)
        {
            elementMethods.ClickElement(confirmAlertButton);
            switch(option)
            {
                case "OK":
                    alertMethods.AcceptAlert();
                    break;
                case "Cancel":
                    alertMethods.DismissAlert();
                    break;
                default:
                    throw new Exception($"Unrecognised option {option}");
            }
            return confirmAlertText.Text;
        }

        public string GetPromptAlertText(string text)
        {
            elementMethods.ClickElement(promtAlertButton);
            alertMethods.HandlePromptAlert(text);
            return promtAlertText.Text;
        }
    }
}
