using ETAAutomationTesting.HelperMethods;
using ETAAutomationTesting.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWithC_.Tests;

namespace ETAAutomationTesting.Tests
{
    public class MainPageTest : BaseTest
    {
        HomePage homePage;
        MainPage mainPage;

        [Test]
        public void ClickOnTextBoxSectionInElementsNavBar()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Elements");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/elements"));
            mainPage = new MainPage(driver);
            mainPage.ClickElementsBarOption("Text Box");

        }

        [Test]
        public void FillTextBoxForm()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Elements");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/elements"));
            mainPage = new MainPage(driver);
            mainPage.ClickElementsBarOption("Text Box");
            mainPage.FillTextBoxAreaElements("Andrei", "Andrei@test.com", "somewhere in Pitesti", "somewhere in Pitesti again");
            Assert.IsTrue(mainPage.validateOutputArea("Andrei", "Andrei@test.com", "somewhere in Pitesti", "somewhere in Pitesti again"));
            
        }

        [Test]
        public void ValidateCheckbox()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Elements");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/elements"));
            mainPage = new MainPage(driver);
            mainPage.ClickElementsBarOption("Check Box");
            mainPage.ClickCheckboxByTitle("Desktop");
            Assert.IsTrue(mainPage.ValidateCheckboxTick("Desktop"));

        }
    }
}
