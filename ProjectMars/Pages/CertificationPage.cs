using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMars.Utilities;

namespace ProjectMars.Pages
{
    public class CertificationPage
    {

        private IWebDriver driver;


        // ###########  CONSTRUCTOR  ####################//

        public CertificationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // ########### CREATE PAGE FACTORY  ####################//

        private IWebElement certificationLinkTab => driver.FindElement(By.XPath("//a[normalize-space()='Certifications']"));
        private IWebElement addNewBtn_certificate => driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
        private IWebElement txtAward => driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
        private IWebElement txtCertified => driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
        private IWebElement dropdownYear => driver.FindElement(By.XPath("//select[@name='certificationYear']"));
        private IWebElement save_certificate => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));

        // ########### UPDATE PAGE FACTORY  ####################//
        private IWebElement editIconCertificateBtn => driver.FindElement(By.XPath("//tbody/tr/td[4]/span[1]/i[1]"));
        private IWebElement editTxtAward => driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
        private IWebElement editCertifiedFrom => driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
        private IWebElement editCertificationYear => driver.FindElement(By.XPath("//select[@name='certificationYear']"));
        private IWebElement updateBtn => driver.FindElement(By.XPath("//input[@value='Update']"));

        // ########### DELETE PAGE FACTORY  ####################//

        private IWebElement deleteIconBtn => driver.FindElement(By.XPath("//tbody/tr/td[4]/span[2]"));

        // ##################CREATE METHODS ##########################
        public void navigateToCertifactionTab()
        {
            Wait.ElementExists(driver, "XPath", "certificationLinkTab", 30);
            certificationLinkTab.Click();

        }
        public void clickAddNewBtnCertificate()
        {
            Wait.ElementExists(driver, "XPath", "addNewBtn_certificate", 30);
            addNewBtn_certificate.Click();
        }
        public void enterAward()
        {
            txtAward.SendKeys("Microsoft certified");
        }
        public void enterCertifiedFrom()
        {
            txtCertified.SendKeys("Azure Cloud Platform");
        }
        public void dropdown_Year()
        {

            Wait.ElementExists(driver, "XPath", "dropdownYear", 10);
            SelectElement selectElement = new SelectElement(dropdownYear);
            selectElement.SelectByValue("2012");
        }
        public void clickAddBtnToSaveCertificate()
        {
            save_certificate.Click();
        }
        public void validateCertificationIsCreated()
        {

        }

        // ##################UPDATE METHODS ##########################

        public void clickUpdateIcon()
        {
            Wait.ElementExists(driver, "XPath", "editIconCertificateBtn", 20);
            editIconCertificateBtn.Click();

        }
        public void editAward()
        {
            editTxtAward.Clear();
            editTxtAward.SendKeys("AWS Cloud");
        }
        public void editAwardFrom()
        {
            editCertifiedFrom.Clear();
            editCertifiedFrom.SendKeys("AWS");
        }
        public void editYear()
        {

            Wait.ElementExists(driver, "XPath", "editCertificationYear", 20);
            SelectElement selectElement = new SelectElement(editCertificationYear);
            selectElement.SelectByValue("2020");
        }
        public void ClickUpdateBtnToSave()
        {
            updateBtn.Click();
        }
        public void validateUpdate()
        {
            //todo task 
        }

        //###############DELETE Methods###############

        public void deleteCertification()
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
