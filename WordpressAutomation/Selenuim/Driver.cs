using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace WordpressAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; internal set; }
        public static string BaseAddress { get { return "http://localhost/mysite/"; } }
        
        public static void Initialize()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\users\sl\documents\visual studio 2015\Projects\WordpressAutomation\WordpressAutomation\bin\Debug", "geckodriver.exe");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            
            Instance = new FirefoxDriver(service);           
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void Close()
        {
            Instance.Close();
        }

        internal static void Wait(TimeSpan timeSpan)
        {
            Thread.Sleep((int)(timeSpan.TotalSeconds * 1000));
        }
    }
}