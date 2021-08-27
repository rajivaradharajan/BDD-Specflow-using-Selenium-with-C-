using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using TechTalk.SpecFlow;

namespace ProjectMars.Steps
{
    [Binding]
    public class SkillsPageStep
    {
        private readonly IWebDriver driver;
        private LoginPage loginPage;
        private ProfilePage profilePage;
        private SkillsPage skillsPage;

        public SkillsPageStep()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            profilePage = new ProfilePage(driver);
            skillsPage = new SkillsPage(driver);
        }

        [AfterScenario]
        public void RunAfterEveryTest()
        {

            driver.Close();
        }

        [Given("I have logged into the application")]
        public void GivenIHaveLoggedIntoTheApplication()
        {
            loginPage.login(null, null);
            Console.WriteLine("I am logged in");
        }
        [Given("I click on the skills tab")]
        public void IClickOnTheSkillsTab()
        {
            profilePage.navigateToSkills(driver);
            //skillsPage.clickOnSkillTabLink();
            Console.WriteLine("I click on the skills tab");
        }
        [Given("I click add new button for the skills")]
        public void GivenIClickAddNewButtonForTheSkills()
        {
            skillsPage.clickOnANewBtn_skills();
            Console.WriteLine("I click add new button for the skills");
        }

        [Given("I enter the details for new skills")]
        public void GivenIEnterTheDetailsForNewSkills()
        {
            skillsPage.enterNewSkills();
            skillsPage.selectDropdownSkills_create();
            Console.WriteLine("I enter the details for new skills");
        }

        [Given("I click add button to save new skills")]
        public void GivenIClickAddButtonToSaveNewSkills()
        {
            skillsPage.addNewBtnToSaveSkill();
            Console.WriteLine("I click add button to save new skills");
        }
        [Then("Validate the skills is created")]
        public void ThenValidateTheSkillsIsCreated()
        {
            bool IsValid = skillsPage.validateSkill_created();
            Assert.IsFalse(IsValid);
        }

        // update change

        [When(@"you click edit button")]
        public void WhenYouClickEditButton()
        {
            skillsPage.clickOnANewBtn_skills();
            Console.WriteLine("you click edit button");
        }
        [Then("enter the edit details")]
        public void ThenEnterTheEditDetails()
        {
            skillsPage.enterEditSkill();
            skillsPage.selectDropdownSkill_edit();
            Console.WriteLine("enter the edit details");
        }
        
        [Then(@"click add new btn to save edit")]
        public void ThenClickAddNewBtnToSaveEdit()
        {
            skillsPage.addNewBtnToSaveSkill();
            Console.WriteLine("click add new btn to save edit");  
        }
        [Then("I validate the result")]
        public void ThenIValidateTheResult()
        {
            skillsPage.validateSkill_created();
            Console.WriteLine("I validate the result");
        }



    }
}
