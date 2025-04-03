using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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

        public void WaitElementToBeVisibleAndEnabled(IWebElement webElement)
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

        public void WaitElementToBeVisible(IWebElement webElement)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(_ =>
            {
                try
                {
                    return webElement.Displayed;
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
            ScrollToElement(webElement);
            webElement.Click();
        }

        public void FillElement(IWebElement webElement, string keyToSend)
        {
            WaitElementToBeVisible(webElement);
            ScrollToElement(webElement);
            webElement.SendKeys(keyToSend);
        }

        public void SelectDropdownByText(IWebElement webElement, string textToSelect)
        {
            WaitElementToBeVisible(webElement);
            ScrollToElement(webElement);
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(textToSelect);
        }

        public void SelectDropdownByValue(IWebElement webElement, string valueToSelect)
        {
            WaitElementToBeVisible(webElement);
            ScrollToElement(webElement);
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByValue(valueToSelect);
        }

        public void SelectDropdownByIndex(IWebElement webElement, int index)
        {
            WaitElementToBeVisible(webElement);
            ScrollToElement(webElement);
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByIndex(index);
        }

        public void ScrollToElement(IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'});", element);
        }

        public void DoubleClickElement(IWebElement webElement)
        {
            WaitElementToBeVisible(webElement);
            ScrollToElement(webElement);
            Actions actions = new Actions(driver);
            actions.DoubleClick(webElement).Perform();
        }

        public void RightClickElement(IWebElement webElement)
        {
            WaitElementToBeVisible(webElement);
            ScrollToElement(webElement);
            Actions actions = new Actions(driver);
            actions.ContextClick(webElement).Perform();
        }

        public void TriggerDoubleClickWithJS(IWebElement element)
        {
            string script = @"
        var event = new MouseEvent('dblclick', {
            view: window,
            bubbles: true,
            cancelable: true
        });
        arguments[0].dispatchEvent(event);";

            ((IJavaScriptExecutor)driver).ExecuteScript(script, element);
        }

        public void ForceRightClickWithJS(IWebElement element)
        {
            string script = @"
        var evt = new MouseEvent('contextmenu', {
            bubbles: true,
            cancelable: true,
            view: window,
            button: 2
        });
        arguments[0].dispatchEvent(evt);";

            ((IJavaScriptExecutor)driver).ExecuteScript(script, element);
        }
    }
}
