using System;
using OpenQA.Selenium;

namespace ProjectMars.Pages
{
    class ProfilePage
    {

        private IWebDriver driver;
        private IWebElement Language_link => driver.FindElement(By.XPath("//a[normalize-space()='Languages']"));
        private IWebElement skills_link => driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        private IWebElement Education_link => driver.FindElement(By.XPath("//a[normalize-space()='Education']"));
        private IWebElement Certification_link => driver.FindElement(By.XPath("//a[normalize-space()='Certifications']"));

        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void navigateToLanguage(IWebDriver driver)
        {
            // Identify and Click Language link
            Language_link.Click();
        }

        public void navigateToSkills(IWebDriver driver)
        {

            // Identify and Click skill link

            skills_link.Click();

        }

        public void navigateToEducation(IWebDriver driver)
        {

            // Identify and Click education link

            Education_link.Click();

        }

        public void navigateToCertification(IWebDriver driver)
        {

            // Identify and Click certification link

            Certification_link.Click();

        }

    }
}
