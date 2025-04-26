using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.HelperMethods
{
    public class AlertMethods
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public AlertMethods(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void AcceptAlert()
        {
            IAlert alert = WaitForAlert();
            alert.Accept();
        }

        public void DismissAlert()
        {
            IAlert alert = WaitForAlert();
            alert.Dismiss();
        }

        public void HandlePromptAlert(string text)
        {
            IAlert alert = WaitForAlert();
            alert.SendKeys(text);
            alert.Accept();
        }

        private IAlert WaitForAlert()
        {
            return wait.Until(ExpectedConditions.AlertIsPresent());
        }
    }
}

