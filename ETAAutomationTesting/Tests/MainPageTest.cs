using ETAAutomationTesting.Access;
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
            mainPage.ClickNavigationBarOption("Text Box");

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
            mainPage.ClickNavigationBarOption("Text Box");
            mainPage.FillTextBoxAreaElements("Andrei", "Andrei@test.com", "somewhere in Pitesti", "somewhere in Pitesti again");
            Assert.IsTrue(mainPage.validateOutputArea("Andrei", "Andrei@test.com", "somewhere in Pitesti", "somewhere in Pitesti again"));
            
        }

        [Test]
        public void FillTextBoxFormUsingXML()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Elements");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/elements"));
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Text Box");
            TextBoxData textBoxData = new TextBoxData(1);
            mainPage.FillTextBoxAreaElements(textBoxData.FullName, textBoxData.Email, textBoxData.CurrentAddress, textBoxData.PermanentAddress);
            Assert.IsTrue(mainPage.validateOutputArea(textBoxData.FullName, textBoxData.Email, textBoxData.CurrentAddress, textBoxData.PermanentAddress));
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
            mainPage.ClickNavigationBarOption("Check Box");
            mainPage.ClickCheckboxByTitle("Desktop");
            Assert.IsTrue(mainPage.ValidateCheckboxTick("Desktop"));

        }

        [Test]
        public void ValidateRadioButtonOption()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Elements");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/elements"));
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Radio Button");
            Assert.IsTrue(mainPage.NoButtonDissabled());
            Assert.IsTrue(mainPage.ValidateRadioButtonSelected("Impressive"));
            Assert.IsTrue(mainPage.ValidateRadioButtonSelected("Yes"));
        }

        [Test]
        public void ValidateButtonsSection()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Elements");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/elements"));
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Buttons");
            
            Assert.IsTrue(mainPage.isDoubleClickedMessageVisible());
            Assert.IsTrue(mainPage.isRightClickedMessageVisible());
            Assert.IsTrue(mainPage.isClickMeMessageVisible());
        }

        [Test]
        public void ClickOnSliderFromWidgetsNavBar()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Widgets");
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Slider");

        }
    }
}
