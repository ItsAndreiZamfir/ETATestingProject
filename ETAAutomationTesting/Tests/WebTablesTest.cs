using ETAAutomationTesting.Access;
using ETAAutomationTesting.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSeleniumWithC_.Tests;

namespace ETAAutomationTesting.Tests
{
    public class WebTablesTest : BaseTest
    {
        HomePage homePage;
        MainPage mainPage;
        WebTablesPage webTablesPage;

        [Test]
        public void ValidateWebTableSection()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Elements");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/elements"));
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Web Tables");
            webTablesPage = new WebTablesPage(driver);
            webTablesPage.ClickAddButton();
            webTablesPage.FillRegistrationForm(
                "Andrei",
                "Zamfir",
                "andrei@test.com",
                "20",
                "50000",
                "Testing"
            );
            webTablesPage.ValidateLastRow(
                "Andrei",
                "Zamfir",
                "20",
                "andrei@test.com",
                "50000",
                "Testing"
            );

        }

        [Test]
        public void ValidateWebTableSectionWithXML()
        {
            homePage = new HomePage(driver);
            homePage.navigateToDemoQAPage();
            Assert.IsTrue(driver.Title.Contains("DEMOQA"));
            homePage.navigateToSpecificPage("Elements");
            Assert.IsTrue(driver.Url.Equals("https://demoqa.com/elements"));
            mainPage = new MainPage(driver);
            mainPage.ClickNavigationBarOption("Web Tables");
            webTablesPage = new WebTablesPage(driver);
            WebTablesData webTableData = new WebTablesData(1);
            webTablesPage.ClickAddButton();
            webTablesPage.FillRegistrationForm(
                webTableData.FirstName,
                webTableData.LastName,
                webTableData.Email,
                webTableData.Age.ToString(),
                webTableData.Salary.ToString(),
                webTableData.Department
            );
            webTablesPage.ValidateLastRow(
                webTableData.FirstName,
                webTableData.LastName,
                webTableData.Age.ToString(),
                webTableData.Email,
                webTableData.Salary.ToString(),
                webTableData.Department
            );
        }
    }
}
