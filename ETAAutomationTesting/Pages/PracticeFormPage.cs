using ETAAutomationTesting.HelperMethods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETAAutomationTesting.Pages
{
    public class PracticeFormPage : BasePage
    {
        private DateTimeMethods dateTimeMethods = new DateTimeMethods();
        public PracticeFormPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private IWebElement firstNameElement => WebDriver.FindElement(By.Id("firstName"));
        private IWebElement lastNameElement => WebDriver.FindElement(By.Id("lastName"));
        private IWebElement emailElement => WebDriver.FindElement(By.XPath("//input[@id='userEmail']"));
        private IWebElement mobileElement => WebDriver.FindElement(By.XPath("//input[@id='userNumber']"));
        private IWebElement dateOfBirthElement => WebDriver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));
        private IWebElement subjectsElement => WebDriver.FindElement(By.XPath("//div[@id='subjectsContainer']"));
        private IWebElement currentAddressElement => WebDriver.FindElement(By.XPath("//textarea[@id='currentAddress']"));
        private IWebElement submitButton => WebDriver.FindElement(By.XPath("//button[@id='submit']"));
        private IWebElement genderMale => WebDriver.FindElement(By.XPath("//label[@for='gender-radio-1']"));
        private IWebElement genderFemale => WebDriver.FindElement(By.XPath("//label[@for='gender-radio-2']"));
        private IWebElement genderOther => WebDriver.FindElement(By.XPath("//label[@for='gender-radio-3']"));
        private IWebElement hobbiesSports => WebDriver.FindElement(By.XPath("//label[@for='hobbies-checkbox-1']"));
        private IWebElement hobbiesReading => WebDriver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']"));
        private IWebElement hobbiesMusic => WebDriver.FindElement(By.XPath("//label[@for='hobbies-checkbox-3']"));
        private IWebElement stateElement => WebDriver.FindElement(By.XPath("//div[@id='state']"));
        private IWebElement cityElement => WebDriver.FindElement(By.XPath("//div[@id='city']"));

        public void FillPracticeForm(string firstName, string lastName, string email, string gender, string mobile, string dateOfBirth, string subject, List<string> hobbies, string currentAddress, string state, string city)
        {
            elementMethods.FillElement(firstNameElement, firstName);
            elementMethods.FillElement(lastNameElement, lastName);
            elementMethods.FillElement(emailElement, email);
            PickGender(gender);
            elementMethods.FillElement(mobileElement, mobile);
            SelectDateOfBirth(dateOfBirth);
            PickHobbies(hobbies);
            SelectSubject(subject);
            elementMethods.FillElement(currentAddressElement, currentAddress);
            SelectState(state);
            SelectCity(city);
            elementMethods.ClickElement(submitButton);
        }

        public void PickGender(string gender)
        {
            switch (gender)
            {
                case "Male":
                    elementMethods.ClickElement(genderMale);
                    break;
                case "Female":
                    elementMethods.ClickElement(genderFemale);
                    break;
                case
                    "Other":
                    elementMethods.ClickElement(genderOther);
                    break;
                default:
                    throw new Exception($"Unrecognised gender {gender}");


            }

        }

        public void PickHobbies(List<string> hobbies)
        {
            foreach (var hobby in hobbies)
            {
                switch (hobby)
                {
                    case "Sports":
                        elementMethods.ClickElement(hobbiesSports);
                        break;
                    case "Reading":
                        elementMethods.ClickElement(hobbiesReading);
                        break;
                    case
                     "Music":
                        elementMethods.ClickElement(hobbiesMusic);
                        break;
                    default:
                        throw new Exception($"Unrecognised gender {hobby}");

                }
            }
        }

        public void SelectDateOfBirth(string dateOfBirth)
        {
            DateTime date = dateTimeMethods.FormatDate(dateOfBirth);

            elementMethods.ClickElement(dateOfBirthElement);

            IWebElement yearDropdown = WebDriver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']"));
            elementMethods.SelectDropdownByValue(yearDropdown, date.Year.ToString());

            IWebElement monthDropdown = WebDriver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']"));
            elementMethods.SelectDropdownByValue(monthDropdown, (date.Month - 1).ToString()); // Months are 0-indexed

            IWebElement dayElement = WebDriver.FindElement(By.XPath($"//div[contains(@class, 'react-datepicker__day') and text()='{date.Day}']"));
            elementMethods.ClickElement(dayElement);

        }

        public void SelectSubject(string subject)
        {
            elementMethods.ClickElement(subjectsElement);
            IWebElement inputField = WebDriver.FindElement(By.Id("subjectsInput"));
            elementMethods.FillElement(inputField, subject);
            IWebElement subjectOption = WebDriver.FindElement(By.XPath($"//div[contains(@class, 'subjects-auto-complete__option') and text()='{subject}']"));
            elementMethods.ClickElement(subjectOption);
        }


        public void SelectState(string state)
        {
            elementMethods.ClickElement(stateElement);
            IWebElement stateOption = WebDriver.FindElement(By.XPath($"//div[@id='state']//div[contains(@class, 'menu')]//div[text()='{state}']"));
            elementMethods.ClickElement(stateOption);
        }

        public void SelectCity(string city)
        {
            elementMethods.ClickElement(cityElement);
            IWebElement cityOption = WebDriver.FindElement(By.XPath($"//div[@id='city']//div[contains(@class, 'menu')]//div[text()='{city}']"));
            elementMethods.ClickElement(cityOption);
        }

        public void AssertModalValues(string firstName, string lastName, string email, string gender, string mobile, string dateOfBirth, string subject, List<string> hobbies, string address, string state, string city)
        {
            // Wait for the modal to appear
            IWebElement modal = WebDriver.FindElement(By.CssSelector(".modal-content"));
            elementMethods.WaitElementToBeVisible(modal);

            // Retrieve values from the modal
            string studentName = WebDriver.FindElement(By.XPath("//td[text()='Student Name']/following-sibling::td")).Text;
            string studentEmail = WebDriver.FindElement(By.XPath("//td[text()='Student Email']/following-sibling::td")).Text;
            string studentGender = WebDriver.FindElement(By.XPath("//td[text()='Gender']/following-sibling::td")).Text;
            string studentMobile = WebDriver.FindElement(By.XPath("//td[text()='Mobile']/following-sibling::td")).Text;
            string studentDateOfBirth = WebDriver.FindElement(By.XPath("//td[text()='Date of Birth']/following-sibling::td")).Text.Replace(","," ");
            string studentSubjects = WebDriver.FindElement(By.XPath("//td[text()='Subjects']/following-sibling::td")).Text;
            string studentHobbies = WebDriver.FindElement(By.XPath("//td[text()='Hobbies']/following-sibling::td")).Text;
            string studentAddress = WebDriver.FindElement(By.XPath("//td[text()='Address']/following-sibling::td")).Text;
            string studentStateAndCity = WebDriver.FindElement(By.XPath("//td[text()='State and City']/following-sibling::td")).Text;

            // Assert values
            if (studentName != $"{firstName} {lastName}") throw new Exception($"Expected Student Name: {firstName} {lastName}, but got: {studentName}");
            if (studentEmail != email) throw new Exception($"Expected Student Email: {email}, but got: {studentEmail}");
            if (studentGender != gender) throw new Exception($"Expected Gender: {gender}, but got: {studentGender}");
            if (studentMobile != mobile) throw new Exception($"Expected Mobile: {mobile}, but got: {studentMobile}");
            if (studentDateOfBirth != dateOfBirth) throw new Exception($"Expected Date of Birth: {dateOfBirth}, but got: {studentDateOfBirth}");
            if (studentSubjects != subject) throw new Exception($"Expected Subjects: {subject}, but got: {studentSubjects}");
            if (studentHobbies != string.Join(", ", hobbies)) throw new Exception($"Expected Hobbies: {string.Join(", ", hobbies)}, but got: {studentHobbies}");
            if (studentAddress != address) throw new Exception($"Expected Address: {address}, but got: {studentAddress}");
            if (studentStateAndCity != $"{state} {city}") throw new Exception($"Expected State and City: {state} {city}, but got: {studentStateAndCity}");
        }
    }
}
