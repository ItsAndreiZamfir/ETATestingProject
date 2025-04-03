using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ETAAutomationTesting.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver webDriver) : base(webDriver)
        {

        }

        private IReadOnlyCollection<IWebElement> cardElements => WebDriver.FindElements(By.CssSelector("div.card-body > h5"));

        public void navigateToDemoQAPage()
        {
            WebDriver.Navigate().GoToUrl("https://demoqa.com/");
            WaitForPageToLoad();
        }

        public void navigateToSpecificPage(string pageName)
        {
            foreach (var card in cardElements)
            {
                if (card.Text.Trim().Equals(pageName, StringComparison.OrdinalIgnoreCase))
                {
                    elementMethods.ScrollToElement(card);
                    elementMethods.ClickElement(card);
                    return;
                }
            }

            throw new Exception($"Card with name '{pageName}' was not found.");

        }

        public void ForceClickBooks()
        {
            ((IJavaScriptExecutor)WebDriver).ExecuteScript("arguments[0].click();", cardElements.Last());
        }
    }
}
