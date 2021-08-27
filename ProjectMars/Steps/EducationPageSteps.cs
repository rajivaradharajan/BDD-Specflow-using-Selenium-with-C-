using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using TechTalk.SpecFlow;

namespace ProjectMars.Steps
{
    [Binding]
    public class EducationPageSteps
    {
        private readonly IWebDriver driver;
        private LoginPage loginPage;
        private ProfilePage profilePage;
        private EducationPage educationPage;

        public EducationPageSteps()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            profilePage = new ProfilePage(driver);
            educationPage = new EducationPage(driver);
        }
        [AfterScenario]
        public void RunAfterEveryTest()
        {

            driver.Close();
        }

        //############## CREATE Education #######################
        [Given("I have logged in")]
        public void GivenIHaveLoggedIn()
        {
            loginPage.login(null, null);
            Console.WriteLine("I have logged in");
        }
        [Given("I click on the education tab")]
        public void GivenIClickOnTheEducationTab()
        {
            profilePage.navigateToEducation(driver);
            educationPage.naviagteToEducationTab();
            Console.WriteLine("I click on the education tab");
        }
        [Given("I click add new button for the education")]
        public void GivenIClickAddNewButtonForTheEducationTab()
        {
            educationPage.clickAddNewBtnEdu();
            Console.WriteLine("I click add new button for the education");
        }
        [Given("I enter the details for new education")]
        public void GivenIEnterTheDetailsForNewEducation()
        {
            educationPage.enterUniveristyNameTxt();
            educationPage.dropdownCountry();
            educationPage.dropDownDegree();
            educationPage.TxtDegreeName();
            educationPage.dropdownYear();
            Console.WriteLine("I enter the details for new education");
        }
        [When("I click add button to save new education")]
        public void WhenIClickAddButtonToSaveNewEducation()
        {
            educationPage.AddBtnToSaveEducation();
            Console.WriteLine("I click add button to save new education");
        }

        [Then("Validate the education is created")]
        public void ThenValidateTheEducationIsCreated()
        {
            Console.WriteLine("Validate the education is created");
        }
        //############## UPDATE method######################

        [Given("I click edit icon to edit education")]
        public void GivenIClickEditIconToEditEducation()
        {
            educationPage.clickOnEditIcon();
            Console.WriteLine("I click edit icon to edit education");
        }
        [When("I enter the details for edited education details")]
        public void WhenIEnterTheDetailsForEditedEducationDetails()
        {
            educationPage.editUniversityName();
            educationPage.editCountryName();
            educationPage.editTitle();
            educationPage.editDegreeTxt();
            educationPage.editYear();
            Console.WriteLine("When I enter the details for edited education details");
        }
        [When("I click update button to save edited education")]
        public void WhenIClickUpdateButtonToSaveEditedEducation()
        {
            educationPage.addBtnToSave();
            Console.WriteLine("I click update button to save edited education");
        }
        [Then("Validate the edited education is created")]
        public void ThenValidateTheEditedEducationIsCreated()
        {
            Console.WriteLine("Validate the edited education is created");
        }

        //############## DELETE Education ######################
         
        [Given("I click delete icon to delete education")]
        public void GivenIClickDeleteIconToDeleteEducation()
        {
            educationPage.deleteEducation();
            Console.WriteLine("I click delete icon to delete education");
        }
        [Then("I Validate the delete education")]
        public void ThenIValidateTheDeleteEducation()
        {
            educationPage.validateDeleteEducation();
            Console.WriteLine("I Validate the delete education");
        }


    }
}
