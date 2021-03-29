using NetwealthDemo.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetwealthDemo.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = BaseTest.driver;
        }

        IWebDriver driver;

        IWebElement firstname => driver.FindElement(By.XPath("//*[@id='FirstName']"));

        IWebElement cookies => driver.FindElement(By.XPath("//*[@id='jAccept']"));

        IWebElement lastname => driver.FindElement(By.XPath("//*[@id='LastName']"));

        IWebElement email => driver.FindElement(By.XPath("//*[@id='Email']"));

        IWebElement password => driver.FindElement(By.XPath("//*[@id='Password']"));

        IWebElement referral => driver.FindElement(By.XPath("//*[@id='ReferralSource']"));

        IWebElement marketing => driver.FindElement(By.XPath("//*[@id='UserWantsMarketingMaterial']"));

        IWebElement register => driver.FindElement(By.XPath("//*[@id='RegisterForm']/fieldset/div[9]/button"));

        IWebElement validate => driver.FindElement(By.XPath("//h1[text()='Thank you for registering']"));

        IWebElement invalidFisrtname => driver.FindElement(By.XPath("//div[text()='Please provide your first name']"));

        IWebElement invalidLastname => driver.FindElement(By.XPath("//div[text()='Please provide your last name']"));

        IWebElement invalidEmail => driver.FindElement(By.XPath("//div[text()='The Email field is not a valid e-mail address.']"));


        IWebElement invalidPassword => driver.FindElement(By.XPath("//div[text()='Please enter a valid password']"));











        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickOnAcceptCookies()
        {
            cookies.Click();
        }


        public void EnterFirstname(string fname)
        {
            firstname.SendKeys(fname);
        }


        public void EnterLastname(string lname)
        {
            lastname.SendKeys(lname);
        }

        public void EnterEmail(string Email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            email.SendKeys("netdemo" + randomInt + "@gmail.com");
        }

        public void EnterEmail2(string Email2)
        {
            email.SendKeys(Email2);
        }


        public void EnterPassword(string pword)
        {
            password.SendKeys(pword);
        }


        public void SelectReferral()
        {
            SelectElement select = new SelectElement(referral);
            select.SelectByValue("4");
        }

        public void SelectMarketingOption()
        {
            SelectElement select = new SelectElement(marketing);
            select.SelectByValue("true");
        }


        public void ClickOnRegister()
        {
            register.Click();
        }

        public bool IsValidateDisplayed()
        {
            return validate.Displayed;
        }

        public bool IsInvalidFirstnameDisplayed()
        {
            return invalidFisrtname.Displayed;
        }

        public bool IsInvalidLastnameDisplayed()
        {
            return invalidLastname.Displayed;
        }

        public void ClickOnPasswordBox()
        {
            password.Click();
        }

        public bool IsInvalidEmailDisplayed()
        {
            return invalidEmail.Displayed;
        }
       
        public bool IsInvalidPasswordDisplayed()
        {
            return invalidPassword.Displayed;
        }



    }
}
