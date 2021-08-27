using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMars.Utilities;

namespace ProjectMars.Pages
{
    class EducationPage
    {
        private IWebDriver driver;
        public EducationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        // ###########  PAGE FACTORY DESIGN PATTERN ####################//ed

        private IWebElement EducationTabLink => driver.FindElement(By.XPath("//a[normalize-space()='Education']"));
        private IWebElement clickAddNewBtn_Edu => driver.FindElement(By.CssSelector("div[class='ui bottom attached tab segment tooltip-target active'] div[class='ui teal button ']"));
        private IWebElement enterUniversityName => driver.FindElement(By.CssSelector("div[class='form-wrapper'] div[class='row'] div[class='ten wide field'] input"));
        private IWebElement dropdown_countryOfCollege => driver.FindElement(By.CssSelector("select[name='country']"));
        private IWebElement dropdown_title => driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[@class='row']//select[@name='title']"));
        private IWebElement txtDegree => driver.FindElement(By.CssSelector("div[class='form-wrapper'] div[class='row'] input[placeholder='Degree']"));
        private IWebElement dropdown_year_of_grad => driver.FindElement(By.CssSelector("div[class='form-wrapper'] div[class='row'] select[name='yearOfGraduation']"));
        private IWebElement addBtn_edu => driver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement lastEntryResult_Lang => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
        //// ############### Update Page factory  ###############
        private IWebElement clickEditIcon => driver.FindElement(By.CssSelector("tbody tr td:nth-child(6) span:nth-child(1)"));
        private IWebElement edit_univeristy_name => driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
        private IWebElement edit_dropdown_country => driver.FindElement(By.XPath("//tbody//select[@name='country']"));
        private IWebElement edit_title => driver.FindElement(By.XPath("//select[@name='title']"));
        private IWebElement edit_degree => driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
        private IWebElement edit_year => driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
        private IWebElement edit_updateBtn => driver.FindElement(By.XPath("//input[@value='Update']"));

        // ########### DELETE PAGE FACTORY  ####################//
        private IWebElement deleteIconBtn => driver.FindElement(By.XPath("//tbody/tr/td[6]/span[2]"));

        //// ############### CREATE Methods ###############
        public void createEducation(IWebDriver driver)
        {
            //create language 

        }
        public void naviagteToEducationTab()
        {
            EducationTabLink.Click();
            Wait.ElementExists(driver, "XPath", "//a[normalize-space()='Education']", 10);
        }
        public void clickAddNewBtnEdu()
        {
            clickAddNewBtn_Edu.Click();
        }
        public void enterUniveristyNameTxt()
        {
            enterUniversityName.SendKeys("Univeristy of Auckland");
        }
        public void dropdownCountry()
        {
            Wait.ElementExists(driver, "CssSelector", "dropdown_countryOfCollege", 10);
            //IWebElement element = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            SelectElement selectElement = new SelectElement(dropdown_countryOfCollege);
            selectElement.SelectByValue("United Kingdom");
        }
        public void dropDownDegree()
        {
            //dropdown_title
            //IWebElement element = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            SelectElement selectElement = new SelectElement(dropdown_title);
            selectElement.SelectByValue("M.Tech");
        }
        public void TxtDegreeName()
        {
            txtDegree.SendKeys("Computer Science");
        }
        public void dropdownYear()
        {

            //IWebElement element = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            SelectElement selectElement = new SelectElement(dropdown_year_of_grad);
            selectElement.SelectByValue("2012");
        }
        public void AddBtnToSaveEducation()
        {
            addBtn_edu.Click();
        }
        public bool validateCreateEducation()
        {
            if (lastEntryResult_Lang.Text == "United Kingdom")
            {
                Console.WriteLine("Education record is created Successfully!!, Test Pass!!");
                return true;
            }
            else
            {
                Console.WriteLine("Education record is not created, Test Failed!!!!");
                return false;
            }

        }

        //#########UPDATE Methods#############
        public void updateEducation(IWebDriver driver)
        {
            //update language 
        }

        public void clickOnEditIcon()
        {
            clickEditIcon.Click();
            Wait.ElementExists(driver, "CssSelector", "tbody tr td:nth-child(6) span:nth-child(1)", 5);
        }
        public void editUniversityName()
        {
            Wait.ElementExists(driver, "XPath", "//input[@placeholder='College/University Name']", 10);
            edit_univeristy_name.Clear();
            edit_univeristy_name.SendKeys("Univerity Of Canterbury");
        }
        public void editCountryName()
        {
            Wait.ElementExists(driver, "XPath", "//select[@name='country']", 20);
            SelectElement selectElement = new SelectElement(edit_dropdown_country);
            selectElement.SelectByValue("Sudan");

        }
        public void editTitle()
        {
            Wait.ElementExists(driver, "XPath", "//select[@name='title']", 10);
            SelectElement selectElement = new SelectElement(edit_title);
            selectElement.SelectByValue("B.Tech");
        }
        public void editDegreeTxt()
        {
            edit_degree.Clear();
            edit_degree.SendKeys("Fashion Technology");
        }
        public void editYear()
        {

            Wait.ElementExists(driver, "XPath", "//select[@name='yearOfGraduation']", 10);
            SelectElement selectElement = new SelectElement(edit_year);
            selectElement.SelectByValue("2020");
        }
        public void addBtnToSave()
        {
            edit_updateBtn.Click();
        }
        public void validateUpadteEducation()
        {

        }

        //#########DELETE Methods#############
        public void deleteEducation(IWebDriver driver)
        {
            //delete language 
        }

        public void deleteEducation()
        {
            Wait.ElementExists(driver, "XPath", "deleteIconBtn", 10);
            deleteIconBtn.Click();
        }
        public void validateDeleteEducation()
        {
            IWebElement deleteValidation = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            string deleteTxt = deleteValidation.Text;
            Console.WriteLine("Delete message from pop up ========>>>>>>>> " + deleteTxt);
        }
    }
}
