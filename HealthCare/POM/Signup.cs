using healthcare.Hooks;
using healthcare.Hooks2;
using OpenQA.Selenium;

namespace HealthCare.POM
{
    class Signup
    {
        public void clickSignUp()
        {
            string signup = "//a[normalize-space()='Sign Up']";
            Hooks1.driver.FindElement(By.XPath(signup)).Click();
            Hooks2.driver.FindElement(By.XPath(signup)).Click();

        }
        public void clickProvider()
        {
            string provider_button = "//img[@alt='Provider']";
            Hooks1.driver.FindElement(By.XPath(provider_button)).Click();
            Hooks2.driver.FindElement(By.XPath(provider_button)).Click();

        }
        public void fillTitle(string title)
        {
            string filltitle = "//input[@name='title']";
            Hooks1.driver.FindElement(By.XPath(filltitle)).SendKeys(title);
            Hooks2.driver.FindElement(By.XPath(filltitle)).SendKeys(title);

        }
        public void fillFullName(string fullname)
        {
            string fillfullname = "//input[@name='name']";
            Hooks1.driver.FindElement(By.XPath(fillfullname)).SendKeys(fullname);
            Hooks2.driver.FindElement(By.XPath(fillfullname)).SendKeys(fullname);

        }
        public void fillEmail(string email)
        {
            string fillemail = "//input[@placeholder='John@gmail.com']";
            Hooks1.driver.FindElement(By.XPath(fillemail)).SendKeys(email);
            Hooks2.driver.FindElement(By.XPath(fillemail)).SendKeys(email);

        }
        public void fillLocation()
        {
            string filllocation = "//input[@placeholder='Type location name']";
            Hooks1.driver.FindElement(By.XPath(filllocation)).SendKeys("Udaipur");
            Hooks1.driver.FindElement(By.XPath(filllocation)).SendKeys(Keys.ArrowDown);
            Hooks1.driver.FindElement(By.XPath(filllocation)).SendKeys(Keys.Enter);
            Hooks2.driver.FindElement(By.XPath(filllocation)).SendKeys("Udaipur");
            Hooks2.driver.FindElement(By.XPath(filllocation)).SendKeys(Keys.ArrowDown);
            Hooks2.driver.FindElement(By.XPath(filllocation)).SendKeys(Keys.Enter);
        }
        public void fillCity()
        {
            string fillcity = "//input[@name='city']";
            Hooks1.driver.FindElement(By.XPath(fillcity)).SendKeys("Udaipur");
            Hooks2.driver.FindElement(By.XPath(fillcity)).SendKeys("Udaipur");

        }
        public void fillState()
        {
            string fillstate = "//input[@name='state']";
            Hooks1.driver.FindElement(By.XPath(fillstate)).SendKeys("Rajasthan");
            Hooks2.driver.FindElement(By.XPath(fillstate)).SendKeys("Rajasthan");

        }
        public void fillSpeciality()
        {
            string fillspeciality = "//div[4]//div[2]//select[1]";
            Hooks1.driver.FindElement(By.XPath(fillspeciality)).Click();
            Hooks1.driver.FindElement(By.XPath(fillspeciality)).SendKeys(Keys.ArrowDown);
            Hooks1.driver.FindElement(By.XPath(fillspeciality)).SendKeys(Keys.Enter);
            Hooks2.driver.FindElement(By.XPath(fillspeciality)).Click();
            Hooks2.driver.FindElement(By.XPath(fillspeciality)).SendKeys(Keys.ArrowDown);
            Hooks2.driver.FindElement(By.XPath(fillspeciality)).SendKeys(Keys.Enter);
        }
        public void fillLicenseNumber(string licensenumber)
        {
            string fillnumber = "//input[@name='licenseNumber']";
            Hooks1.driver.FindElement(By.XPath(fillnumber)).SendKeys(licensenumber);
            Hooks2.driver.FindElement(By.XPath(fillnumber)).SendKeys(licensenumber);

        }
        public void fillNpiNumber(string npinumber)
        {
            string fillnpinumber = "//input[@name='npiNumber']";
            Hooks1.driver.FindElement(By.XPath(fillnpinumber)).SendKeys(npinumber);
            Hooks2.driver.FindElement(By.XPath(fillnpinumber)).SendKeys(npinumber);

        }
        public void fillPhoneNumber(string phonenumber)
        {
            string fillphonenumber = "//input[@name='phoneNumber']";
            Hooks1.driver.FindElement(By.XPath(fillphonenumber)).SendKeys(phonenumber);
            Hooks2.driver.FindElement(By.XPath(fillphonenumber)).SendKeys(phonenumber);

        }
        public void fillWebsite(string website)
        {
            string fillwebsite = "//input[@name='website']";
            Hooks1.driver.FindElement(By.XPath(fillwebsite)).SendKeys(website);
            Hooks2.driver.FindElement(By.XPath(fillwebsite)).SendKeys(website);

        }
        public void fillGender()
        {
            string fillgender = "//div[@class='form-field']//following::label[contains(text(),'Gender:')]//following::select[1]";
            Hooks1.driver.FindElement(By.XPath(fillgender)).Click();
            Hooks1.driver.FindElement(By.XPath(fillgender)).SendKeys(Keys.ArrowDown);
            Hooks1.driver.FindElement(By.XPath(fillgender)).SendKeys(Keys.ArrowDown);
            Hooks1.driver.FindElement(By.XPath(fillgender)).SendKeys(Keys.Enter);
            Hooks2.driver.FindElement(By.XPath(fillgender)).Click();
            Hooks2.driver.FindElement(By.XPath(fillgender)).SendKeys(Keys.ArrowDown);
            Hooks2.driver.FindElement(By.XPath(fillgender)).SendKeys(Keys.ArrowDown);
            Hooks2.driver.FindElement(By.XPath(fillgender)).SendKeys(Keys.Enter);
        }
        public void fillAge()
        {
            string fillage = "//div[@class='form-field']//following::label[contains(text(),'Age Group:')]//following::select[1]";
            Hooks1.driver.FindElement(By.XPath(fillage)).Click();
            Hooks1.driver.FindElement(By.XPath(fillage)).SendKeys(Keys.ArrowDown);
            Hooks1.driver.FindElement(By.XPath(fillage)).SendKeys(Keys.Enter);
            Hooks2.driver.FindElement(By.XPath(fillage)).Click();
            Hooks2.driver.FindElement(By.XPath(fillage)).SendKeys(Keys.ArrowDown);
            Hooks2.driver.FindElement(By.XPath(fillage)).SendKeys(Keys.Enter);
        }
        public void fillEthnicity()
        {
            string fillethnicity = "//div[@class='form-field']//following::label[contains(text(),'Ethnicity:')]//following::select[1]";
            Hooks1.driver.FindElement(By.XPath(fillethnicity)).Click();
            Hooks1.driver.FindElement(By.XPath(fillethnicity)).SendKeys(Keys.ArrowDown);
            Hooks1.driver.FindElement(By.XPath(fillethnicity)).SendKeys(Keys.Enter);
            Hooks2.driver.FindElement(By.XPath(fillethnicity)).Click();
            Hooks2.driver.FindElement(By.XPath(fillethnicity)).SendKeys(Keys.ArrowDown);
            Hooks2.driver.FindElement(By.XPath(fillethnicity)).SendKeys(Keys.Enter);
        }
        public void clickSubmit()
        {
            string submitbutton = "//input[@name='btn-submit']";
            Hooks1.driver.FindElement(By.XPath(submitbutton)).Click();
            Hooks2.driver.FindElement(By.XPath(submitbutton)).Click();
        }
               

    }
}
