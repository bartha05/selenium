using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstSeleniumTest
{
    class Program
    {
         static void Main(string[] args)
        
        {
           IWebDriver driver = new ChromeDriver(@"C:\Users\uq92kh\src\Selenium");
           
           {
             driver.Navigate().GoToUrl("http://www.google.com");
             driver.Manage().Window.FullScreen();
           }
         }

    }
}
