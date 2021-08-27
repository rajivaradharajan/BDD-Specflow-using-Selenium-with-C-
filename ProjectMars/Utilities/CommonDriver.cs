using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjectMars.Pages;

namespace ProjectMars.Utility
{
    class CommonDriver
    {
        // init driver
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Login()
        {
           
            driver = new ChromeDriver();

            // page objects for login
            LoginPage loginObj = new LoginPage(driver);
            loginObj.loginSteps(driver);
        }


        [OneTimeTearDown]
        public void FinalSteps()
        {
            // close driver
            driver.Close();
        }
    }
}
