using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Interactions;

namespace Webtest
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteWebDriver driver = null;
            try
            {
                driver = new EdgeDriver();
               

                // Navigate to Our site
                driver.Url = "http://162.246.157.107:666/login";

                // Log in
                var username = driver.FindElementByName("username");

                username.SendKeys("admin");
                var password = driver.FindElementByName("password");
                password.SendKeys("admin");


                username.SendKeys(Keys.Enter);

                               
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

        }
    }
}
