using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMars.Utilities;

namespace ProjectMars.Pages
{
    class LanguagePage
    {
        private IWebDriver driver;
        public LanguagePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // ###########  CREATE PAGE FACTORY DESIGN PATTERN ####################//

        private IWebElement SignUpLink => driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
        private IWebElement AddNewBtnLanguage => driver.FindElement(By.CssSelector("div[class='ui bottom attached tab segment active tooltip-target'] div[class='ui teal button ']"));
        private IWebElement enterLanguage => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private IWebElement languageDropdown => driver.FindElement(By.XPath("//option[@value='Fluent']"));
        private IWebElement saveLanguage => driver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement lastEntryResult_Lang => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        //private IWebElement Language_link => driver.FindElement(By.XPath("//a[normalize-space()='Languages']"));
        // #################UPDATE PAGE FACTORY ############
        private IWebElement clickEditBtnLang => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]"));
        private IWebElement editLang => driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private IWebElement dropDown_edit_Lang => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[5]"));
        private IWebElement updateBtnLang => driver.FindElement(By.XPath("//input[@value='Update']"));

        // #################DELETE PAGE FACTORY ############
        private IWebElement delete_Language => driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));
        private IWebElement Lang_title => driver.FindElement(By.XPath("//h3[normalize-space()='Languages']"));
        // IWebElement deleteRow => driver.FindElement(By.XPath("//td[normalize-space()='Tamil']"));
        private IWebElement deleteValidation => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        // ####### Validate Page factory #########

        // create

        public void clickAddNewBtn()
        {
            AddNewBtnLanguage.Click();
        }
        public void enterlanguage()
        {
            enterLanguage.SendKeys("Java");
            Wait.ElementExists(driver, "XPath", "enterLanguage", 10);
        }
        public void dropDown_lang_list()
        {
            languageDropdown.Click();
            Wait.ElementExists(driver, "XPath", "languageDropdown", 10);
        }
        public void Save_Language()
        {
            saveLanguage.Click();
            Wait.ElementExists(driver, "XPath", "saveLanguage", 10);
        }
        public bool validateLanguage_created()
        {
            IWebElement actualResult = lastEntryResult_Lang;
            //Assert.That(actualResult.Text, Is.EqualTo("Java"), "Test Failed");
            Console.WriteLine(actualResult + "----->>>>>>");
             if (actualResult.Text == "Java")
             {
                 Console.WriteLine("Language is created Successfully!!, Test Pass!!");
                 return true;

             }
             else
             {
                 Console.WriteLine("Language is not created, Test Failed!!!!");
                 return false;

             }
        }

        // Update

        public void clickEditLanguage()
        {
            clickEditBtnLang.Click();
            Wait.ElementExists(driver, "XPath", "clickEditBtnLang", 10);
        }
        public void editLanguage()
        {
            editLang.Clear();
            editLang.SendKeys("English");
            Wait.ElementExists(driver, "XPath", "editLang", 10);
            dropDown_edit_Lang.Click();

        }
        public void selectDropDown()
        {
            IWebElement element = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue("Native/Bilingual");
        }

        public void update_Btn_Language()
        {
            updateBtnLang.Click();
            Wait.ElementExists(driver, "XPath", "updateBtnLang", 10);
        }
        public bool validateUpdate_Lang()
        {
            string name =lastEntryResult_Lang.Text;
            if (lastEntryResult_Lang.Text == "English")
            {
                Console.WriteLine("Language is created Successfully!!Test Pass====>>>" +name );
                return true;

            }
            else
            {
                Console.WriteLine("Language is not created, Test Failed!!!!");
                return false;

            }
        }

        // Delete

        public void clickDeleteLanguage()
        {
            delete_Language.Click();
        }
 
        public void validateDeleteItem()
        {
            //IWebElement deleteValidation = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            string deleteTxt = deleteValidation.Text;
            Console.WriteLine("Delete message from pop up ========>>>>>>>> " + deleteTxt);
        }



        public void createLanguage(IWebDriver driver)
        {

        }
        public void editLanguage(IWebDriver driver)
        {

        }
        public void deleteLanguage(IWebDriver driver)
        {

        }
    }
}
