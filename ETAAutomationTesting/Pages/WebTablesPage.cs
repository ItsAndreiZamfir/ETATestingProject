using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.Pages
{
    public class WebTablesPage : BasePage
    {
        public WebTablesPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        private IWebElement addButton => WebDriver.FindElement(By.Id("addNewRecordButton"));
        private IWebElement firstNameElement => WebDriver.FindElement(By.XPath("//input[@id='firstName']"));
        private IWebElement lastNameElement => WebDriver.FindElement(By.XPath("//input[@id='lastName']"));
        private IWebElement emailElement => WebDriver.FindElement(By.XPath("//input[@id='userEmail']"));
        private IWebElement ageElement => WebDriver.FindElement(By.XPath("//input[@id='age']"));
        private IWebElement salaryElement => WebDriver.FindElement(By.XPath("//input[@id='salary']"));
        private IWebElement departmentElement => WebDriver.FindElement(By.XPath("//input[@id='department']"));
        private IWebElement submitButton => WebDriver.FindElement(By.XPath("//button[@id='submit']"));

        public void ClickAddButton() => elementMethods.ClickElement(addButton);
        
        public void FillRegistrationForm(string firstName, string lastName, string email, string age, string salary, string department)
        {
            elementMethods.FillElement(firstNameElement, firstName);
            elementMethods.FillElement(lastNameElement, lastName);
            elementMethods.FillElement(emailElement, email);
            elementMethods.FillElement(ageElement, age);
            elementMethods.FillElement(salaryElement, salary);
            elementMethods.FillElement(departmentElement, department);
            elementMethods.ClickElement(submitButton);
        }

        public void ValidateLastRow(string firstName, string lastName, string age, string email, string salary, string department)
        {
            IWebElement tableBody = WebDriver.FindElement(By.CssSelector(".rt-tbody"));
            elementMethods.WaitElementToBeVisible(tableBody);

            IReadOnlyCollection<IWebElement> rows = tableBody.FindElements(By.CssSelector(".rt-tr-group"));

            if (!rows.Any())
                throw new Exception("No rows found in the table.");

            IWebElement lastRow = rows.Last();

            IReadOnlyCollection<IWebElement> cells = lastRow.FindElements(By.CssSelector(".rt-td"));

            if (cells.Count < 6)
                throw new Exception($"Expected at least 6 cells in the last row, but found {cells.Count}.");

            string actualFirstName = cells.ElementAt(0).Text.Trim();
            string actualLastName = cells.ElementAt(1).Text.Trim();
            string actualAge = cells.ElementAt(2).Text.Trim();
            string actualEmail = cells.ElementAt(3).Text.Trim();
            string actualSalary = cells.ElementAt(4).Text.Trim();
            string actualDepartment = cells.ElementAt(5).Text.Trim();

            // Validate the values
            if (actualFirstName != firstName)
                throw new Exception($"Expected First Name: {firstName}, but got: {actualFirstName}");
            if (actualLastName != lastName)
                throw new Exception($"Expected Last Name: {lastName}, but got: {actualLastName}");
            if (actualAge != age)
                throw new Exception($"Expected Age: {age}, but got: {actualAge}");
            if (actualEmail != email)
                throw new Exception($"Expected Email: {email}, but got: {actualEmail}");
            if (actualSalary != salary)
                throw new Exception($"Expected Salary: {salary}, but got: {actualSalary}");
            if (actualDepartment != department)
                throw new Exception($"Expected Department: {department}, but got: {actualDepartment}");
        }



    }
}
