﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://localhost/mysite/wp-login.php");

            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "user_login");

            #region commented service
            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\users\sl\documents\visual studio 2015\Projects\WordpressAutomation\WordpressAutomation\bin\Debug", "geckodriver.exe");

            //service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";

            //var driver = new FirefoxDriver(service);

            //driver.Navigate().GoToUrl("http://localhost/mysite/wp-login.php");
            #endregion
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        private string password;
        private string userName;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }


        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("user_login"));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("user_pass"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.Id("wp-submit"));
            loginButton.Click();
        }
    }
}
