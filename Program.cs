using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace Riser_Guardian
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chrome browser variable
            IWebDriver driver = new ChromeDriver();

            // Navigate to Facebook signup
            driver.Navigate().GoToUrl("https://www.facebook.com/signup");

            // Full screen browser
            driver.Manage().Window.Maximize();

            // Locate the element of the first name
            IWebElement firstname = driver.FindElement(By.Name("firstname"));

            // Enter username details
            firstname.SendKeys("Test");

            // Locate the element of the surname
            IWebElement surname = driver.FindElement(By.Name("lastname"));

            // Enter surname details
            surname.SendKeys("Example");

            // Locate element of email and send keys
            IWebElement email = driver.FindElement(By.Name("reg_email__"));
            email.SendKeys("example@gmail.com");

            // Re-enter email
            IWebElement confirmEmail = driver.FindElement(By.Name("reg_email_confirmation__"));
            confirmEmail.SendKeys("example@gmail.com");

            // Locate element of password and send keys
            IWebElement password = driver.FindElement(By.Name("reg_passwd__"));
            password.SendKeys("examplepassword1");

            // Select date of birth
            // Day
            IWebElement day = driver.FindElement(By.Name("birthday_day"));
            var selectDay = new SelectElement(day);
            selectDay.SelectByValue("21");

            // Month
            IWebElement month = driver.FindElement(By.Name("birthday_month"));
            var selectMonth = new SelectElement(month);
            selectMonth.SelectByValue("4");

            // Year
            IWebElement year = driver.FindElement(By.Name("birthday_year"));
            var selectYear = new SelectElement(year);
            selectYear.SelectByValue("2008");

            // Select Gender
            // As Facebook's gender button's ID constantly changes, we need to find the element by XPath
            // https://www.edureka.co/community/33611/how-to-click-the-gender-radio-button-facebook-using-selenium
            IWebElement genderButton = driver.FindElement(By.XPath("//*[contains(text(),'Male')]"));
            genderButton.Click();

            // Click sign up
            IWebElement signUpButton = driver.FindElement(By.Name("websubmit"));
            signUpButton.Click();

        }
    }
}
