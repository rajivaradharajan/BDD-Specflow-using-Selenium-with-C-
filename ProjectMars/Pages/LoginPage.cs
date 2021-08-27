using System;
using OpenQA.Selenium;
using ProjectMars.Utilities;

namespace ProjectMars.Pages
{
    class LoginPage
    {
        private IWebDriver driver;

        //// ###########  PAGE FACTORY DESIGN PATTERN ####################//
        private IWebElement signInLink => driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
        private IWebElement EmailAddress => driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        private IWebElement password => driver.FindElement(By.XPath(" //input[@placeholder='Password']"));
        private IWebElement Login_button => driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
        private IWebElement txtpassword => driver.FindElement(By.XPath(" //input[@placeholder='Password']"));
        private IWebElement LawrenceTxt => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span[1]"));
        private IWebElement loginErrorMessage => driver.FindElement(By.XPath("//button[normalize-space()='Send Verification Email']"));
        //private IWebElement signInLink => driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void loginSteps(IWebDriver driver)
        {
            
        }

        // ############### Refactor Methods ####################

        public void login(string usernameValue, string passwordValue)
        {
            navigateToLoginPage();
            enterGivenUseranameAndPasswordRefactor(usernameValue, passwordValue);
            clickLoginButton();
            validateLoggedInSuccessful();

        }
        public void navigateToLoginPage()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //IWebElement SignUpLink = driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
            signInLink.Click();

        }

        public bool validateThatYouAreLoginPage()
        {
            IWebElement Login_button = driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            //return Login_button.Displayed;

            // IWebElement signInLink = driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
            return signInLink.Displayed;


        }



        public void enterGivenUseranameAndPasswordRefactor(string usernameValue, string passwordValue)
        {

            Wait.ElementExists(driver, "XPath", "//input[@placeholder='Email address']", 10);
            // Identify and Enter Username
            //IWebElement EmailAddress = driver.FindElement(By.XPath("//input[@placeholder='Email address']"));

            if (usernameValue != null)
            {
                Console.WriteLine("enterUsername=========>>>>" + usernameValue);
                EmailAddress.SendKeys(usernameValue);
            }
            else
            {
                Console.WriteLine("enterUsername==========>>>>>>>" + "chandru.lawrence@gmail.com");
                EmailAddress.SendKeys("chandru.lawrence@gmail.com");
            }

            Console.WriteLine("enterPassword" + passwordValue);
            //IWebElement txtpassword = driver.FindElement(By.XPath(" //input[@placeholder='Password']"));

            if (passwordValue != null)
            {
                // enter the Password
                Console.WriteLine("enterPassword===>>>>>>>>" + passwordValue);
                txtpassword.SendKeys(passwordValue);
            }
            else
            {
                // enter default Password
                Console.WriteLine("enterPassword=====>>>>>>>>" + "acer5610");
                txtpassword.SendKeys("acer5610");
            }

        }





        public void clickLoginButton()
        {
            // Identitfy and Click the Login Button

            //IWebElement Login_button = driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
            Login_button.Click();
        }

        public bool validateLoggedInSuccessful()    // Task to do later 
        {
            // IWebElement LawrenceTxt = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span[1]"));
            Wait.ElementExists(driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span[1]", 10);
            string name = LawrenceTxt.Text;
            Console.WriteLine(name);
            if (LawrenceTxt.Text == "Hi lawrence")
            {
                Console.WriteLine("Logged in Successful");
                return true;
            }
            else
            {
                Console.WriteLine("Login failed, test failed");
                return false;
            }
        }
    }
}
