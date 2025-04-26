using ETAAutomationTesting.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWithC_.Tests;

namespace ETAAutomationTesting.Tests
{
    public class FramesTest : BaseTest
    {
        HomePage homePage;
        MainPage mainPage;
        FramesPage framesPage;

        [Test]
        public void ValidateTextFromFrames()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Alerts, Frame & Windows");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/alertsWindows"));
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Frames");
            framesPage = new FramesPage(driver);
            Assert.That(framesPage.GetFrame1Text(), Is.EqualTo("This is a sample page"));
            framesPage.SwitchToDefaultContent();
            Assert.That(framesPage.GetFrame2Text(), Is.EqualTo("This is a sample page"));
        }

        [Test]
        public void ValidateScrollOfTheFrame()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Alerts, Frame & Windows");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/alertsWindows"));
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Frames");
            framesPage = new FramesPage(driver);
            framesPage.ScrollFrame2();
            Assert.That(framesPage.GetFrame2Text(), Is.EqualTo("This is a sample page"));
        }
    }
}
