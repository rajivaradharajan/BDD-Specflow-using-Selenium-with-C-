using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using TechTalk.SpecFlow;

namespace ProjectMars.Steps
{
    [Binding]
    public class CertificationPageSteps
    {
        // ######### Intialize webdriver ##############

        private readonly IWebDriver driver;
        //private LanguagePage languagePage;  // Login Page take the driver 
        private LoginPage loginPage;
        //private ProfilePage profilePage;
        private CertificationPage certificationPage;

        // ############# Create a Constructor #############

        public CertificationPageSteps()
        {
            // Inject the driver 
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            certificationPage = new CertificationPage(driver);

        }
        [AfterScenario]
        public void RunAfterEveryTest()
        {
            driver.Close();
        }

        // ####### CREATE  Method ###################
        
        [Given(@"I have logged into")]
        public void GivenIHaveLoggedInto()
        {
            loginPage.login(null, null);
            Console.WriteLine("I have logged into");

        }
        [Given(@"I have click on the certification tab")]
        public void GivenIHaveClickOnTheCertificationTab()
        {
            certificationPage.navigateToCertifactionTab();
            Console.WriteLine("I have click on the certification tab");
        }
        [When(@"I have click add new button")]
        public void WhenIHaveClickAddNewButton()
        {
            certificationPage.clickAddNewBtnCertificate();
            Console.WriteLine("I have click add new button");
        }
        [When(@"I have enter the details for new certification")]
        public void WhenIHaveEnterTheDetailsForNewCertification()
        {
            certificationPage.enterAward();
            Console.WriteLine("I have enter the details for new certification");
            certificationPage.enterCertifiedFrom();
            certificationPage.dropdown_Year();

        }
        [When(@"I click add button to save new certification")]
        public void WhenIClickAddButtonToSaveNewCertification()
        {
            certificationPage.clickAddBtnToSaveCertificate();
            Console.WriteLine("I click add button to save new certification");
        }

        [Then(@"I have validate the certification is created")]
        public void ThenIHaveValidateTheCertificationIsCreated()
        {
            // Todo task  
        }
        // ####### UPDATE  #################

        [Given(@"I click edit icon to edit certification")]
        public void GivenIClickEditIconToEditCertification()
        {
            certificationPage.clickUpdateIcon();
            Console.WriteLine("I click edit icon to edit certification");
        }
        [When(@"I have enter the details for edited certification details")]
        public void WhenIHaveEnterTheDetailsForEditedCertificationDetails()
        {
            certificationPage.editAward();
            certificationPage.editAwardFrom();
            certificationPage.editYear();
            Console.WriteLine("I have enter the details for edited certification details");
        }

        [When(@"I have click update button to save edited certification")]
        public void WhenIHaveClickUpdateButtonToSaveEditedCertification()
        {
            certificationPage.ClickUpdateBtnToSave();
            Console.WriteLine("I have click update button to save edited certification");
        }
        [Then(@"I have validate the edited certification is created")]
        public void ThenIHaveValidateTheEditedCertificationIsCreated()
        {
            //todo task 
        }

        // ####### DELETE #################
        [Given(@"I have click delete icon to delete certification")]
        public void GivenIHaveClickDeleteIconToDeleteCertification()
        {
            certificationPage.deleteCertification();
            Console.WriteLine("I have click delete icon to delete certification");
        }
        [Then(@"I have validate the delete certification")]
        public void ThenIHaveValidateTheDeleteCertification()
        {
            //todo task 
        }

    }
}
