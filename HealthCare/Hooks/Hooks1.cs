using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System.IO;
using System;


namespace healthcare.Hooks
{


    [Binding]
    public class Hooks1
    {

        static AventStack.ExtentReports.ExtentReports extent;
        static AventStack.ExtentReports.ExtentTest feature;
        AventStack.ExtentReports.ExtentTest scenario;
        AventStack.ExtentReports.ExtentTest step;
       

        static string reportpath = System.IO.Directory.GetParent(@"C:\\Users\\manish.verma\\Downloads\\HealthCare\\HealthCare\\HealthCare\\Reports").FullName
                + Path.DirectorySeparatorChar + "Result"
                + Path.DirectorySeparatorChar + "Result" + DateTime.Now.ToString("ddMMyyyy HHmmss");
        private readonly IObjectContainer iob;
        public static IWebDriver driver;

        public Hooks1(IObjectContainer iob)
        {
            this.iob = iob;
        }
        

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(reportpath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlreport);
            extent.AddSystemInfo("<div style = 'color:green;font-weight:Bold'>Website</div>", "https://melanatedhealthqa.web.app/");
            extent.AddSystemInfo("<div style = 'color:red;font-weight:Bold'>OS</div>", "Windows 11");
            extent.AddSystemInfo("<div style = 'color:blue;font-weight:Bold'>Browser</div>", "Chrome");

        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            feature = extent.CreateTest(context.FeatureInfo.Title);
        }
        [BeforeScenario]
        public void BeforeScenario(ScenarioContext context)
        {

            scenario = feature.CreateNode(context.ScenarioInfo.Title);

            driver = new ChromeDriver();


            driver.Manage().Window.Maximize();
            iob.RegisterInstanceAs<IWebDriver>(driver);
            driver.Url = "https://melanatedhealthqa.web.app/";
            
            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile("C:\\Users\\manish.verma\\Downloads\\HealthCare\\HealthCare\\HealthCare\\Screenshots\\Initial.png", ScreenshotImageFormat.Png);


        }

        [BeforeStep]
        public void BeforeStep()
        {
            step = scenario;
        }
        [AfterStep]
        public void AfterStep(ScenarioContext context)
        {
            if (context.TestError == null)
            {
                step.Log(Status.Pass, context.StepContext.StepInfo.Text);
            }
            else if (context.TestError != null)
            {
                step.Log(Status.Fail, context.StepContext.StepInfo.Text);
            }
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            extent.Flush();
        }
        [AfterScenario]
        public void AfterScenario()
        {
            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile("C:\\Users\\manish.verma\\Downloads\\HealthCare\\HealthCare\\HealthCare\\Screenshots\\Final.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }


    }

}