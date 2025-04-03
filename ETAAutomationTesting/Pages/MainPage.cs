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

        #region Text Box frame section elements

        private IWebElement fullNameElement => WebDriver.FindElement(By.XPath("//input[@id='userName']"));
        private IWebElement emailElement => WebDriver.FindElement(By.XPath("//input[@id='userEmail']"));

        private IWebElement currentAddressElement => WebDriver.FindElement(By.XPath("//textarea[@id='currentAddress']"));
        private IWebElement permanentAddressElement => WebDriver.FindElement(By.XPath("//textarea[@id='permanentAddress']"));
        private IWebElement submitButton => WebDriver.FindElement(By.XPath("//button[@id='submit']"));

        private IWebElement outputAreaElement => WebDriver.FindElement(By.Id("output"));

        #endregion

        #region Check box frame section elements
        private IWebElement checkboxElement => WebDriver.FindElement(By.ClassName("rct-checkbox"));
        private IWebElement expandButton => WebDriver.FindElement(By.XPath("//button[@aria-label='Expand all']"));
        private IWebElement collapseButton => WebDriver.FindElement(By.XPath("//button[@aria-label='Collapse all']"));

        private IWebElement selectedOptionArea => WebDriver.FindElement(By.Id("result"));
        #endregion

        #region Radio Button section elements

        private IWebElement yesRadioButton => WebDriver.FindElement(By.XPath("//label[@for='yesRadio']"));
        private IWebElement impressiveRadioButton => WebDriver.FindElement(By.XPath("//label[@for='impressiveRadio']"));
        private IWebElement noRadioButton => WebDriver.FindElement(By.XPath("//label[@for='noRadio']"));
        private IWebElement checkBoxResultArea => WebDriver.FindElement(By.ClassName("mt-3"));
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

        #region Text box section methods

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

        #endregion

        #region Checkbox section methods

        public void ClickCheckboxByTitle(string checkboxTitle)
        {
            elementMethods.ClickElement(expandButton);
            var titles = WebDriver.FindElements(By.CssSelector("span.rct-title"));

            foreach (var title in titles)
            {
                if (title.Text.Trim().Equals(checkboxTitle, StringComparison.OrdinalIgnoreCase))
                {
                    var checkboxSpan = title.FindElement(By.XPath("./preceding-sibling::span[contains(@class, 'rct-checkbox')]"));

                    elementMethods.ClickElement(checkboxSpan);
                    return;
                }
            }

            throw new Exception($"Checkbox with title '{checkboxTitle}' not found.");
        }

        public bool ValidateCheckboxTick(string optionToCheck)
        {
            return selectedOptionArea.Displayed
                && selectedOptionArea.Text.Contains("You have selected")
                && selectedOptionArea.Text.ToLower().Replace("you have selected", "").Replace("\r", "").Replace("\n", " ").Trim().Contains(optionToCheck.ToLower().Trim());
        }
        #endregion

        #region Radio button section methods

        public bool NoButtonDissabled()
        {
            return noRadioButton.Enabled;
        }

        public bool ValidateRadioButtonSelected(string option)
        {
            switch(option)
            {
                case "Yes":
                    elementMethods.ClickElement(yesRadioButton);
                    break;
                case "Impressive":
                    elementMethods.ClickElement(impressiveRadioButton);
                    break;
                default:
                    elementMethods.ClickElement(yesRadioButton);
                    break;


            }
            return checkBoxResultArea.Displayed &&
                checkBoxResultArea.Text.Contains("You have selected") &&
                checkBoxResultArea.Text.ToLower().Trim().Contains(option.ToLower().Trim());
        }
        #endregion
    }
}
