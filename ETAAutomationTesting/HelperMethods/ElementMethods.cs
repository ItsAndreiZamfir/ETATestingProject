using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ETAAutomationTesting.HelperMethods
{
    public class ElementMethods
    {
        IWebDriver driver;
        WebDriverWait wait;

        public ElementMethods(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitElementToBeVisible(IWebElement webElement)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(_ =>
            {
                try
                {
                    return webElement.Displayed && webElement.Enabled;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
        }

        public void ClickElement(IWebElement webElement)
        {
            WaitElementToBeVisible(webElement);
            webElement.Click();
        }

        public void FillElement(IWebElement webElement, string keyToSend)
        {
            WaitElementToBeVisible(webElement);
            webElement.SendKeys(keyToSend);
        }

        public void SelectDropdownByText(IWebElement webElement, string textToSelect)
        {
            WaitElementToBeVisible(webElement);
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(textToSelect);
        }

        public void SelectDropdownByValue(IWebElement webElement, string valueToSelect)
        {
            WaitElementToBeVisible(webElement);
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByValue(valueToSelect);
        }

        public void SelectDropdownByIndex(IWebElement webElement, int index)
        {
            WaitElementToBeVisible(webElement);
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByIndex(index);
        }

        public void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'});", element);
        }
    }
}
