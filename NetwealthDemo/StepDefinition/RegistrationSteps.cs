using NetwealthDemo.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NetwealthDemo.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }



        [Given(@"the user navigates to the website ""(.*)""")]
        public void GivenTheUserNavigatesToTheWebsite(string url)
        {
            registrationPage.NavigateToWebsite(url);
        }

        [Given(@"user accepts cookies")]
        public void GivenUserAcceptsCookies()
        {
            registrationPage.ClickOnAcceptCookies();
        }


        [Given(@"user enters first name ""(.*)""")]
        public void GivenUserEntersFirstName(string fname)
        {
            registrationPage.EnterFirstname(fname);
        }
        
        [Given(@"user enters last name ""(.*)""")]
        public void GivenUserEntersLastName(string lname)
        {
            registrationPage.EnterLastname(lname);
        }
        
        [Given(@"user enters email ""(.*)""")]
        public void GivenUserEntersEmail(string Email)
        {
           registrationPage.EnterEmail(Email);
        }

        [Given(@"user enters the email ""(.*)""")]
        public void GivenUserEntersTheEmail(string Email2)
        {
            registrationPage.EnterEmail2(Email2);
        }


        [Given(@"user enters password ""(.*)""")]
        public void GivenUserEntersPassword(string pword)
        {
            registrationPage.EnterPassword(pword);
        }
        
        [Given(@"user selects where they heard about Netwealth")]
        public void GivenUserSelectsWhereTheyHeardAboutNetwealth()
        {
            registrationPage.SelectReferral();
        }
        
        [Given(@"user selects whether to receive optional updates")]
        public void GivenUserSelectsWhetherToReceiveOptionalUpdates()
        {
            registrationPage.SelectMarketingOption();
        }
        
        [When(@"user clicks on the Try Netwealth button")]
        public void WhenUserClicksOnTheTryNetwealthButton()
        {
            registrationPage.ClickOnRegister();
        }

        [Then(@"the user should be registered successfully")]
        public void ThenTheUserShouldBeRegisteredSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsValidateDisplayed);
        }

        [Then(@"user should be prompted to enter first name")]
        public void ThenUserShouldBePromptedToEnterFirstName()
        {
           Assert.That(registrationPage.IsInvalidFirstnameDisplayed);
        }

        [Then(@"user should be prompted to enter the last name")]
        public void ThenUserShouldBePromptedToEnterTheLastName()
        {
           Assert.That(registrationPage.IsInvalidLastnameDisplayed);
        }

        [When(@"user tries to enter password by clicking the box")]
        public void WhenUserTriesToEnterPasswordByClickingTheBox()
        {
            registrationPage.ClickOnPasswordBox();
        }

        [Then(@"user should be prompted to enter a valid email")]
        public void ThenUserShouldBePromptedToEnterAValidEmail()
        {
            Assert.That(registrationPage.IsInvalidEmailDisplayed);
        }

        [Then(@"user should be prompted to enter a valid password")]
        public void ThenUserShouldBePromptedToEnterAValidPassword()
        {
            Assert.That(registrationPage.IsInvalidPasswordDisplayed);
        }


    }
}
