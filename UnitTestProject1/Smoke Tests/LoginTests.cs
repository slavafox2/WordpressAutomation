using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;

namespace UnitTestProject1
{
    [TestClass]
    public class LoginTests : WordpressTests
    {        
        [TestMethod]
        public void Admin_User_Can_Login()
        {
            Assert.IsTrue(DashboardPage.IsAt, "my Failed to login");           
        }
        
    }
}


#region exmple1
    //var c = new Class1();
    //c.Go();



    //public class TestResult
    //{

    //    private IWebDriver driver;
    //    private StringBuilder verificationErrors;
    //    private string baseURL;
    //    private bool acceptNextAlert = true;

    //    [TestInitialize]
    //    public void SetupTest()
    //    {
    //        FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\geckodriver", "geckodriver.exe");
    //        service.Port = 64444;
    //        service.FirefoxBinaryPath = @"C:\Program Files (x86)\Firefox Developer Edition\firefox.exe";
    //        driver = new FirefoxDriver(service);
    //        baseURL = "http://localhost:49539";
    //        verificationErrors = new StringBuilder();
    //    }
    //}
#endregion