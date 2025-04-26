using ETAAutomationTesting.HelperMethods;
using ETAAutomationTesting.HelperMethods.ETAAutomationTesting.HelperMethods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.Pages
{
    public class FramesPage : BasePage
    {
        protected FrameMethods frameMethods;
        public FramesPage(IWebDriver webDriver) : base(webDriver)
        {
            frameMethods = new FrameMethods(webDriver);
        }

        private IWebElement frame1 => WebDriver.FindElement(By.XPath("//iframe[@id='frame1']"));
        private IWebElement frame2 => WebDriver.FindElement(By.XPath("//iframe[@id='frame2']"));

        private IWebElement frameText => WebDriver.FindElement(By.XPath("//h1[@id='sampleHeading']"));

        public string GetFrame1Text()
        {
            frameMethods.SwitchToFrame(frame1);
            return frameText.Text;
        }

        public string GetFrame2Text()
        {
            frameMethods.SwitchToFrame(frame2);
            return frameText.Text;
        }

        public void SwitchToDefaultContent()
        {
            frameMethods.SwitchToDefaultContent();
        }

        public void ScrollFrame2()
        {
            frameMethods.ScrollVertically(frame2, 1000);
            frameMethods.ScrollHorizontally(frame2, 1000);
        }
    }
}
