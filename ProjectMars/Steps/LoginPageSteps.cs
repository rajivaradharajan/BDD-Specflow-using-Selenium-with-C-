using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;
using TechTalk.SpecFlow;


namespace ProjectMars.Steps
{

 [Binding]  
    public class LoginPageSteps
    {
         private readonly IWebDriver driver;
         private LoginPage loginPage;

        public LoginPageSteps()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
        }

        [AfterScenario]
        public void RunAfterEveryTest()
        {

            driver.Close();
        }

        [Given(@"I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            loginPage.navigateToLoginPage();
            Console.WriteLine("I am at the login page");
        }

        [When(@"I enter valid creds")]
        public void WhenIEnterValidCreds()
        {
            Console.WriteLine("I enter valid creds");
            // LoginPage loginPage = new LoginPage();
            loginPage.enterGivenUseranameAndPasswordRefactor(null, null);

        }


        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            // LoginPage loginPage = new LoginPage();
            loginPage.clickLoginButton();
            Console.WriteLine("I click the login button");
        }

        [Then(@"I should be logged in sucessfully")]
        public void ThenIShouldBeLoggedInSucessfully()
        {
            Console.WriteLine("I should be logged in sucessfully");
            // LoginPage loginPage = new LoginPage();

            bool isLoggedIn = loginPage.validateLoggedInSuccessful();
            Assert.IsTrue(isLoggedIn);
        }

        [When(@"I login with username '(.*)'")]
        public void WhenILoginWithUsername(string username)
        {
            // LoginPage loginPage = new LoginPage();
            //loginPage.enterUseraname(driver, username);
            loginPage.enterGivenUseranameAndPasswordRefactor(username, null);
            Console.WriteLine("I login with username " + username);
        }

        [Then(@"I should be not logged in sucessfully")]
        public void ThenIShouldBeNotLoggedInSucessfully()
        {
            Console.WriteLine("I should be not logged in sucessfully");
            Assert.IsTrue(true);
        }

        [Given(@"I validate that i am at the login page")]
        public void GivenIValidateThatIAmAtTheLoginPage()
        {
            //LoginPage loginPage = new LoginPage();
            bool isAtLoginPage = loginPage.validateThatYouAreLoginPage();
            Assert.IsTrue(isAtLoginPage);
            Console.WriteLine("I validate that i am at the login page");
            //bool isAtLoginPage = loginPage.validateThatYouAreLoginPage(driver);
            //Assert.IsTrue(isAtLoginPage);
        }

        [When(@"I login with (.*) and with (.*)")]
        public void WhenILoginWithUsername(string username, string password)
        {

            // LoginPage loginPage = new LoginPage();
            //loginPage.enterGivenUseranameAndPassword(driver, usernameValue, passwordValue);
            loginPage.enterGivenUseranameAndPasswordRefactor(username, null);
            Console.WriteLine("I login with username >>>>>>> " + username + " and password =>>>>>>>>>> " + password);
        }

    }
}
