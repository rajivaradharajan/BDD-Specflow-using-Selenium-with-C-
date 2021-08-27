using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using TechTalk.SpecFlow;
// news
namespace MarsProject.Hooks
{
    [Binding]
    public class GeneralHooks
    {
        private static ScenarioContext scenarioContextObject;
       //private static FeatureContext featureContext;
        private static ExtentReports extentReports;
        private static ExtentHtmlReporter htmlReporter;
        private static ExtentTest feature;
        private static ExtentTest scenario;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            htmlReporter = new ExtentHtmlReporter(@"/Users/chriselyn/Documents/MarsProjectReports/");
            extentReports = new ExtentReports();
            extentReports.AttachReporter(htmlReporter);
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            if (null != featureContext)
            {
                feature = extentReports.CreateTest<Feature>(featureContext.FeatureInfo.Title);
            }
            // TODO: implement logic that has to run before executing each feature
        }

        [BeforeScenario]
        public static void BeforeScenario(ScenarioContext scenarioContext)
        {
            // TODO: implement logic that has to run before executing each scenario

            if (null != scenarioContext)
            {
                scenarioContextObject = scenarioContext;
                scenario = feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            }
        }

        [AfterStep]
        public void AfterStep()
        {
            // TODO: implement logic that has to run after each scenario step

            ScenarioBlock currentScenarioBlock = scenarioContextObject.CurrentScenarioBlock;
            switch (currentScenarioBlock)
            {
                case ScenarioBlock.Given:

                    scenario.CreateNode<Given>(scenarioContextObject.StepContext.StepInfo.Text);
                    break;

                case ScenarioBlock.When:

                    scenario.CreateNode<When>(scenarioContextObject.StepContext.StepInfo.Text);
                    break;

                case ScenarioBlock.Then:

                    scenario.CreateNode<Then>(scenarioContextObject.StepContext.StepInfo.Text);
                    break;

                default:

                    scenario.CreateNode<And>(scenarioContextObject.StepContext.StepInfo.Text);
                    break;

            }
        }


        [BeforeStep]
        public void BeforeStep()
        {
            // TODO: implement logic that has to run before each scenario step
            // For storing and retrieving scenario-specific data, 
            // the instance fields of the class or the
            //     ScenarioContext.Current
            // collection can be used.
            // For storing and retrieving feature-specific data, the 
            //     FeatureContext.Current
            // collection can be used.
            // Use the attribute overload to specify tags. If tags are specified, the event 
            // handler will be executed only if any of the tags are specified for the 
            // feature or the scenario.
            //     [BeforeStep("mytag")]
        }

         

        [BeforeScenarioBlock]
        public void BeforeScenarioBlock()
        {
            // TODO: implement logic that has to run before each scenario block (given-when-then)
        }

        [AfterScenarioBlock]
        public void AfterScenarioBlock()
        {
            // TODO: implement logic that has to run after each scenario block (given-when-then)
        }

         
        [AfterScenario]
        public void AfterScenario()
        {
            // TODO: implement logic that has to run after executing each scenario
        }
        


        [AfterFeature]
        public static void AfterFeature()
        {
            // TODO: implement logic that has to run after executing each feature
        }

        

        [AfterTestRun]
        public static void AfterTestRun()
        {
            // TODO: implement logic that has to run after the entire test run
            extentReports.Flush();
        }
    }
}
