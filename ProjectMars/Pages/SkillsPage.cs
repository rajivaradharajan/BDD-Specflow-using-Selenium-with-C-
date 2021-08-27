using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMars.Utilities;

namespace ProjectMars.Pages
{
    class SkillsPage
    {
        private readonly IWebDriver driver;
        public SkillsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // ########### CREATE PAGE FACTORY  ####################//

        private IWebElement skillsTabLink => driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        private IWebElement addNewBtn => driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        private IWebElement enterSkills => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        private IWebElement select_dd_Element => driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
        private IWebElement saveSkill => driver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement lastEntryResult_Lang => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td"));
        // ########### UPDATE PAGE FACTORY  ####################//
        //  IWebElement enterEditSkillsTxt => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        private IWebElement clickUpdateToSave => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
        private IWebElement clickEditIcon => driver.FindElement(By.XPath("//tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
        private IWebElement enterEditSkills => driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));

        // ########### DELETE PAGE FACTORY  ####################//
        private IWebElement clickDeleteBtn => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]"));
        private IWebElement element => driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
        // ###########  CREATE Methods  ####################//

        //public void clickOnSkillTabLink()
        //{
        //    skillsTabLink.Click();

        //}
        public void clickOnANewBtn_skills()
        {
            addNewBtn.Click();
        }
        public void enterNewSkills()
        {
            enterSkills.SendKeys("Badminton");
        }
        public void selectDropdownSkills_create()
        {
            //enterSkills.SendKeys("Badminton");
            SelectElement selectElement = new SelectElement(select_dd_Element);
            selectElement.SelectByValue("Expert");
        }
        public void addNewBtnToSaveSkill()
        {
            saveSkill.Click();
        }
        public bool validateSkill_created()
        {
            if (lastEntryResult_Lang.Text == "Badminton")
            {
                Console.WriteLine("Skills created Successfully!!, Test Pass!!");
                return true;

            }
            else
            {
                Console.WriteLine("Skill not created, Test Failed!!!!");
                return false;

            }


        }

        // ###########  UPDATE Methods  ####################//

        public void clickOnEditBtn()
        {
            Wait.ElementExists(driver, "XPath", "clickEditIcon", 10);
            clickEditIcon.Click();
            
        }
        public void enterEditSkill()
        {

            Wait.ElementExists(driver, "XPath", "enterEditSkills", 10);
            enterEditSkills.Clear();
            enterEditSkills.SendKeys("flag");
        }
        public void selectDropdownSkill_edit()
        {

            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue("Expert");

        }
        public void updateToSaveSkill()
        {
            clickUpdateToSave.Click();
        }

        public bool validateUpdate_Skill()
        {
            if (lastEntryResult_Lang.Text == "Badminton da")
            {
                Console.WriteLine("Skill is Updated Successfully!!, Test Pass!!");
                return true;

            }
            else
            {
                Console.WriteLine("Skill is not Updated, Test Failed!!!!");
                return false;

            }
        }

        // ###########  DELETE Methods  ####################//

        public void clickOnDeleteBtn()
        {
            clickDeleteBtn.Click();
        }
        public void validatedeleteSkill()
        {
            IWebElement deleteValidation = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            string deleteTxt = deleteValidation.Text;
            Console.WriteLine("Delete message from pop up ======>>>>>>>>> " + deleteTxt);
        }


    }
}
