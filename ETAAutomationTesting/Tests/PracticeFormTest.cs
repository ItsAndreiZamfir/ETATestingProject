using ETAAutomationTesting.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWithC_.Tests;

namespace ETAAutomationTesting.Tests
{
    public class PracticeFormTest : BaseTest
    {
        HomePage homePage;
        MainPage mainPage;
        PracticeFormPage practiceFormPage;

        [Test]
        public void ClickOnTextBoxSectionInElementsNavBar()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Forms");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/forms"));
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Practice Form");
            practiceFormPage = new PracticeFormPage(driver);
            practiceFormPage.FillPracticeForm(
                "Andrei",
                "Zamfir",
                "andrei@test.com",
                "Male",
                "0722323232",
                "04 May 2025",
                "English",
                new List<string> { "Sports", "Music" }, 
                "somewhere in Pitesti",
                "NCR",
                "Delhi"
            );
            practiceFormPage.AssertModalValues("Andrei",
                "Zamfir",
                "andrei@test.com",
                "Male",
                "0722323232",
                "04 May 2025",
                "English",
                new List<string> { "Sports", "Music" },
                "somewhere in Pitesti",
                "NCR",
                "Delhi"
            );

        }
    }
}
