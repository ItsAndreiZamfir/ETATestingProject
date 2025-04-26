using ETAAutomationTesting.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWithC_.Tests;

namespace ETAAutomationTesting.Tests
{
    public class AlertsTest : BaseTest
    {
        HomePage homePage;
        MainPage mainPage;
        AlertPage alertsPage;

        [Test]
        public void ValidateFirstAlert()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Alerts, Frame & Windows");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/alertsWindows"));
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Alerts");
            alertsPage = new AlertPage(driver);
            alertsPage.HandleFirstAlert();
        }

        [Test]
        public void ValidateTimerAlert()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Alerts, Frame & Windows");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/alertsWindows"));
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Alerts");
            alertsPage = new AlertPage(driver);
            alertsPage.HandleTimerAlert();
        }

        [Test]
        public void ValidateConfirmAlert()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Alerts, Frame & Windows");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/alertsWindows"));
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Alerts");
            alertsPage = new AlertPage(driver);
            Assert.That(alertsPage.GetConfirmAlertText("OK"), Is.EqualTo("You selected Ok"));
            Assert.That(alertsPage.GetConfirmAlertText("Cancel"), Is.EqualTo("You selected Cancel"));
        }

        [Test]
        public void ValidatePromptAlert()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Alerts, Frame & Windows");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/alertsWindows"));
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Alerts");
            alertsPage = new AlertPage(driver);
            Assert.That(alertsPage.GetPromptAlertText("Andrei"), Is.EqualTo("You entered Andrei"));
        }
    }
}
