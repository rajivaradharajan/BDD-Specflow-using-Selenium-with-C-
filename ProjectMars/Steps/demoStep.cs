using System;

using TechTalk.SpecFlow;

namespace ProjectMars.Steps
{
    [Binding]
    public class demoStep
    {
        [Given(@"user have logged in")]
        public void GivenUserHaveLoggedIn()
        {
            Console.WriteLine("user have logged in");
        }
        [Given(@"user click on the education tab")]
        public void GivenUserClickOnTheEducationTab()
        {
            Console.WriteLine("user click on the education tab");
        }
        [Given(@"user click add new button for the education")]
        public void GivenUserClickAddNewButtonForTheEducation()
        {
            Console.WriteLine("user click add new button for the education");
        }
        [Then(@"user enter the details for new education")]
        public void ThenUserEnterTheDetailsForNewEducation()
        {
            Console.WriteLine("user enter the details for new education");
        }
        [When(@"user click add button to save new education")]
        public void WhenUserClickAddButtonToSaveNewEducation()
        {
            Console.WriteLine("user click add button to save new education");
        }
        [Then(@"user Validate the education is created")]
        public void ThenUserValidateTheEducationIsCreated()
        {
            Console.WriteLine("user Validate the education is created");
        }

        //Update
        [Given(@"User logged in to application")]
        public void GivenUserLoggedInToApplication()
        {
            Console.WriteLine("User logged in to application");
        }
        [Given(@"I navigate to demo page")]
        public void GivenINavigateToDemoPage()
        {
            Console.WriteLine("I navigate to demo page");
        }
        [When(@"user update file")]
        public void WhenUserUpdateFile()
        {
            Console.WriteLine("user update file");
        }
        [Then(@"update record should be verified")]
        public void ThenUpdateRecordShouldBeVerified()
        {
            Console.WriteLine("update record should be verified");
        }
        //delete
        [Given(@"user already in demo page")]
        public void GivenUserAlreadyInDemoPage()
        {
            Console.WriteLine("user already in demo page");   
        }
        [When(@"user delete file")]
        public void WhenUserDeleteFile()
        {
            Console.WriteLine("user delete file");  
        }
        [Then(@"delete record should be verified")]
        public void ThenDeleteRecordShouldBeVerified()
        {
            Console.WriteLine("delete record should be verified");
        }

    }
}
