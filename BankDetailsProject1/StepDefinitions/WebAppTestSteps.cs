using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace BankDetailsProject1.StepDefinitions
{
    [Binding]
    public class WebAppTestSteps
    {
        private readonly LoginService loginService;
        private string? username;
        private string? password;
        private string? loginResult;

        public WebAppTestSteps(LoginService loginService)
        {
            this.loginService = loginService;
        }


        [Given(@"a user with valid username ""([^""]*)"" and valid password ""([^""]*)""")]
        public void GivenAUserWithValidUsernameAndValidPassword(string validUsername, string validPassword)
        {
            username = validUsername;
            password = validPassword;


            //throw new PendingStepException();
        }


        [When(@"the Login method is called")]
        public void WhenTheLoginMethodIsCalled()
        {

            loginResult=loginService.Login(username, password);

            //throw new PendingStepException();
        }



        [Then(@"the result should be Login Success")]
        public void ThenTheResultShouldBeLoginSuccess()
        {
            Assert.AreEqual("Login Success", loginResult);

            //throw new PendingStepException();
        }



        [Then(@"the result should be Login Failed")]
        public void ThenTheResultShouldBeLoginFailed()
        {
            Assert.AreEqual("Login Failed", loginResult);

            //throw new PendingStepException();
        }




    }
}
