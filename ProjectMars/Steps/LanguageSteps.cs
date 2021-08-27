using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using TechTalk.SpecFlow;

namespace ProjectMars.Steps
{
    [Binding]
    public class LanguageSteps
    {
        private readonly IWebDriver driver;
        private LanguagePage languagePage;
        private LoginPage loginPage;
        private ProfilePage profilePage;

        public LanguageSteps()
        {
            driver = new ChromeDriver();
            languagePage = new LanguagePage(driver);
            loginPage = new LoginPage(driver);
            profilePage = new ProfilePage(driver);
        }

        [AfterScenario]
        public void RunAfterEveryTest()
        {

            driver.Close();
        }

        [Given("I am logged in")]
        public void GivenIAmLoggedIn()
        {
            loginPage.login(null,null);
            Console.WriteLine("I am logged in"); 
        }
        [Given("I am at the language page")]
        public void GivenIAmAtTheLanguagePage()
        {
            profilePage.navigateToLanguage(driver);
            Console.WriteLine("I am at the language page");
        }
        [When("I click the create add new button")]
        public void WhenIClickTheCreateAddNewButton()
        {
            languagePage.clickAddNewBtn();
            Console.WriteLine("I click the create add new button");
        }
        [When("Enter the details for new language")]
        public void WhenEnterTheDetailsForNewLanguage()
        {
            languagePage.enterlanguage();
            languagePage.dropDown_lang_list();
            Console.WriteLine("Enter the details for new language"); 
        }
        [When("Click add to save language")]
        public void WhenClickAddToSaveLanguage()
        {
            languagePage.Save_Language();
            Console.WriteLine("Click add to save language");
        }
        [Then("Validate the language is created")]
        public void ThenValidateTheLanguageIsCreated()
        {
            languagePage.validateLanguage_created();
            //bool IsValid = languagePage.validateLanguage_created();
            Console.WriteLine("Validate the language is created");
            // Assert.IsTrue(IsValid);
        }

        // Update

        [When("I click the edit button")]
        public void WhenIClickTheEditButton()
        {
            languagePage.clickEditLanguage();
            Console.WriteLine("I click the edit button");
        }
        [When("I edit the details")]
        public void WhenIEditTheDetails()
        {
            languagePage.editLanguage();
            languagePage.selectDropDown();
            Console.WriteLine("I edit the details");
        }
        [When("I click update to save language")]
        public void WhenIClickUpdateToSaveLanguage()
        {
            languagePage.update_Btn_Language();
            Console.WriteLine("I click update to save language");
        }
        [Then("Validate that lang I edited was saved")]
        public void ThenValidateThatLangIEditedWasSaved()
        {
            bool IsValid = languagePage.validateUpdate_Lang();
            Console.WriteLine("Validate that lang I edited was saved");
            Assert.IsFalse(IsValid);
        }

        //Delete
        [Given("I click delete button")]
        public void WhenIClickDeleteIconButton()
        {
            languagePage.clickDeleteLanguage();
            Console.WriteLine("I click delete icon button");
        }
        [Then("I have to validate the language and it deleted")]
        public void ThenIHaveToValidateTheLanguageAndItDeleted()
        {
             languagePage.validateDeleteItem();
            Console.WriteLine("I have to validate the language and it deleted");
             
        }

   
    }
}
