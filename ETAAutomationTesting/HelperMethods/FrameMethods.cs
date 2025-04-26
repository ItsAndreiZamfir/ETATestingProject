using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.HelperMethods
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Support.UI;
    using SeleniumExtras.WaitHelpers;
    using System;

    namespace ETAAutomationTesting.HelperMethods
    {
        public class FrameMethods
        {
            private readonly IWebDriver driver;
            private readonly WebDriverWait wait;
            private readonly ElementMethods elementMethods;

            public FrameMethods(IWebDriver driver)
            {
                this.driver = driver;
                this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                this.elementMethods = new ElementMethods(driver);
            }

            public void SwitchToFrame(IWebElement frameElement)
            {
                elementMethods.WaitElementToBeVisible(frameElement);
                elementMethods.ScrollToElement(frameElement);
                driver.SwitchTo().Frame(frameElement);
            }

            public void SwitchToDefaultContent()
            {
                driver.SwitchTo().DefaultContent();
            }

            public void ScrollByOffset(int xOffset, int yOffset)
            {
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript($"window.scrollBy({xOffset}, {yOffset});");
            }

            public void ScrollHorizontally(IWebElement frameElement, int xOffset)
            {
                SwitchToFrame(frameElement);

                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript($"window.scrollBy({xOffset}, 0);");

                SwitchToDefaultContent();
            }

            public void ScrollVertically(IWebElement frameElement, int yOffset)
            {
                SwitchToFrame(frameElement);

                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript($"window.scrollBy(0, {yOffset});");

                SwitchToDefaultContent();
            }
        }
    }

}
