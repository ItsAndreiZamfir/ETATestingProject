using ETAAutomationTesting.Pages;
using OpenQA.Selenium;
using TestSeleniumWithC_.Tests;

namespace ETAAutomationTesting.Tests
{
    public class HomePageTest : BaseTest
    {
        HomePage homePage;

        [Test]
        public void TestNavigationOnHomePage()
        {
            homePage = new HomePage(driver);
            homePage.navigateToGooglePage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
        }

        [Test]
        public void TestClickOnCardElements()
        {
            homePage = new HomePage(driver);
            homePage.navigateToGooglePage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Elements");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/elements"));
        }

        [Test]
        public void TestClickOnFormsCardElement()
        {
            homePage = new HomePage(driver);
            homePage.navigateToGooglePage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Forms");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/forms"));
        }

        [Test]
        public void TestClickOnAlertsCardElement()
        {
            homePage = new HomePage(driver);
            homePage.navigateToGooglePage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Alerts, Frame & Windows");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/alertsWindows"));
        }

        [Test]
        public void TestClickOnWidgetsCardElement()
        {
            homePage = new HomePage(driver);
            homePage.navigateToGooglePage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Widgets");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/widgets"));
        }

        [Test]
        public void TestClickOnInteractionsCardElement()
        {
            homePage = new HomePage(driver);
            homePage.navigateToGooglePage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Interactions");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/interaction"));
        }

        [Test]
        public void TestClickOnBooksCardElement()
        {
            homePage = new HomePage(driver);
            homePage.navigateToGooglePage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            //homePage.navigateToSpecificPage("Book Store Application");
            homePage.ForceClickBooks();
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/books"));
        }
    }
}
