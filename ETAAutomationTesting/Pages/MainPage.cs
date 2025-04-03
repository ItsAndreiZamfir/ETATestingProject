using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        private IWebElement elementsOptions => WebDriver.FindElement(By.CssSelector("div.element-list.collapse.show"));

        private IReadOnlyCollection<IWebElement> elementsListItems => elementsOptions.FindElements(By.CssSelector("ul.menu-list li"));

        #region Text Box frame elements

        private IWebElement fullNameElement => WebDriver.FindElement(By.XPath("//input[@id='userName']"));
        private IWebElement emailElement => WebDriver.FindElement(By.XPath("//input[@id='userEmail']"));

        private IWebElement currentAddressElement => WebDriver.FindElement(By.XPath("//textarea[@id='currentAddress']"));
        private IWebElement permanentAddressElement => WebDriver.FindElement(By.XPath("//textarea[@id='permanentAddress']"));
        private IWebElement submitButton => WebDriver.FindElement(By.XPath("//button[@id='submit']"));

        private IWebElement outputAreaElement => WebDriver.FindElement(By.Id("output"));

        #endregion

        public void ClickElementsBarOption(string option)
        {

            foreach (var element in elementsListItems)
            {
                var span = element.FindElement(By.CssSelector("span.text"));
                if (span.Text.Trim().Equals(option, StringComparison.OrdinalIgnoreCase))
                {
                    elementMethods.ClickElement(element);
                    return;
                }
            }
            throw new Exception($"Option with text '{option}' not found in elements navbar.");
        }

        public void FillTextBoxAreaElements(string fullName, string email, string currentAddress, string permanentAddress)
        {
            elementMethods.FillElement(fullNameElement, fullName);
            elementMethods.FillElement(emailElement, email);
            elementMethods.FillElement(currentAddressElement, currentAddress);
            elementMethods.FillElement(permanentAddressElement, permanentAddress);
            elementMethods.ClickElement(submitButton);


        }

        public bool validateOutputArea(string expectedName, string expectedEmail, string expectedCurrentAddress, string expectedPermanentAddress)
        {
            if (!outputAreaElement.Displayed) 
            { 
                return false;
            }
            else
            {
                string actualName = WebDriver.FindElement(By.XPath("//div[@id='output']//p[@id='name']")).Text.Split(':')[1].Trim();
                string actualEmail = WebDriver.FindElement(By.XPath("//div[@id='output']//p[@id='email']")).Text.Split(':')[1].Trim();
                string actualCurrentAddress = WebDriver.FindElement(By.XPath("//div[@id='output']//p[@id='currentAddress']")).Text.Split(':')[1].Trim();
                string actualPermanentAddress = WebDriver.FindElement(By.XPath("//div[@id='output']//p[@id='permanentAddress']")).Text.Split(':')[1].Trim();
                return expectedName.Equals(actualName, StringComparison.OrdinalIgnoreCase) &&
                    expectedEmail.Equals(actualEmail, StringComparison.OrdinalIgnoreCase) &&
                    expectedCurrentAddress.Equals(actualCurrentAddress, StringComparison.OrdinalIgnoreCase) &&
                    expectedPermanentAddress.Equals(actualPermanentAddress, StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
