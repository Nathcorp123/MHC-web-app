using healthcare.Hooks;
using healthcare.Hooks2;
using HealthCare.POM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace HealthCare.Feature
{
    [Binding]
    public class ScenarioSteps
    {
        Signup Call = new Signup();
        IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks1.driver;
        IJavaScriptExecutor js1 = (IJavaScriptExecutor)Hooks2.driver;

        [Given(@"Navigate to the URL,Click on Signup,Click on Provider.")]
        public void GivenNavigateToTheURLClickOnSignupClickOnProvider_()
        {
            Call.clickSignUp();
            Thread.Sleep(5000);
            Call.clickProvider();
            Thread.Sleep(5000);
            //ExplicitWaiting.waitForTime(2000);
        }
        [Given(@"Fill the Required details (.*),(.*),(.*),(.*),(.*),(.*) and (.*)\.")]
        public void GivenFillTheRequiredDetailsAnd_(string title, string fullname, string email, string licensenumber, string npinumber, string phonenumber, string website)
        {
            Call.fillTitle(title);
            Thread.Sleep(5000);
            Call.fillFullName(fullname);
            Thread.Sleep(5000);
            Call.fillEmail(email);
            Thread.Sleep(5000);
            js.ExecuteScript("window.scrollBy(0,1000)");
            js1.ExecuteScript("window.scrollBy(0,1000)");
            Call.fillLocation();
            Thread.Sleep(5000);
            Call.fillCity();
            Thread.Sleep(5000);
            Call.fillState();
            Thread.Sleep(5000);
            Call.fillSpeciality();
            Thread.Sleep(5000);
            js.ExecuteScript("window.scrollBy(0,2000)");
            js1.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(5000);
            Call.fillLicenseNumber(licensenumber);
            Thread.Sleep(5000);
            Call.fillNpiNumber(npinumber);
            Thread.Sleep(5000);
            Call.fillPhoneNumber(phonenumber);
            Thread.Sleep(5000);
            Call.fillWebsite(website);
            Thread.Sleep(5000);
            js.ExecuteScript("window.scrollBy(0,2000)");
            js1.ExecuteScript("window.scrollBy(0,1000)");
            Call.fillGender();
            Thread.Sleep(5000);
            Call.fillAge();
            Thread.Sleep(5000);
            Call.fillEthnicity();
            Thread.Sleep(5000);
        }     

        [When(@"Click on Signup button\.")]
        public void WhenClickOnSignupButton_()
        {
            Call.clickSubmit();
            Thread.Sleep(5000);
        }
        
        [Then(@"Registration done successfully message should popup, click on OK\.")]
        public void ThenRegistrationDoneSuccessfullyMessageShouldPopupClickOnOK_()
        {
            string actual_result = "Registration Completed. We will contact you Soon";
            string expected_result = Hooks1.driver.FindElement(By.XPath("//div[normalize-space()='Registration Completed. We will contact you Soon']")).Text;
            Assert.AreEqual(actual_result,expected_result );
            Console.WriteLine("Registration Completed Successfully");
        }
    }
}
