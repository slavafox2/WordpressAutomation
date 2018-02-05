using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation
{
    public class Class1
    {
        public void Go()
        {
            //Give the path of the geckodriver.exe    
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\users\sl\documents\visual studio 2015\Projects\WordpressAutomation\WordpressAutomation\bin\Debug", "geckodriver.exe");

            //Give the path of the Firefox Browser        
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";

            IWebDriver driver = new FirefoxDriver(service);

            driver.Navigate().GoToUrl("https://www.google.com");

        }
    }
}


//FirefoxOptions options = new FirefoxOptions();
//options.AcceptInsecureCertificates
//    setBinary("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe"); //This is the location where you have installed Firefox on your machine

//FirefoxDriver driver = new FirefoxDriver(options);
//driver.get("http://www.google.com");



//var driver = new ChromeDriver();
//driver.Navigate().GoToUrl("https://tut.by");