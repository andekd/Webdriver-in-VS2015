using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Threading;

namespace SeleniumNunitSimple
{
    [TestFixture, Description("First NUnit run")]
    public class SimpleSearch
    {
        //Empty Constructor
        public SimpleSearch() { }

        // Classmember to hold values to test for
        private ArrayList myList;

        [SetUp]
        public void loadTestData()
        {
            myList = new ArrayList();
            myList.Add("Foo");
            myList.Add("Bar");
            Console.WriteLine("Starting test");
        }

        [Test]
        public void checkSize()
        {
            Assert.IsTrue(myList.Count == 2);
        }

        [TestCase("Foo")]
        public void checkString(string toCheckFor)
        {
            bool exists = myList.Contains(toCheckFor);
            Assert.IsTrue(exists);
        }

        [TearDown]
        public void checkTearDown()
        {
            Assert.IsNotNull(myList);
            myList = null;
            Assert.IsNull(myList);
        }

    }

       /*
       public class Google1
       {
           private IWebDriver driver;

           [SetUp]
           public void LoadDriver()
           {
               Console.WriteLine("SetUp");
               driver = new ChromeDriver();
           }

           [TestCase("Bing", "Bing")] //Serching för Bing on Google, Title of finished search page should be 'Bing'
           public void Search(string searchString, string expectedResult)
           {
               driver.Navigate().GoToUrl("http://google.com");
               IWebElement searchField = driver.FindElement(By.Name("q"));
               searchField.SendKeys(searchString);
               searchField.SendKeys(Keys.Enter);

            driver.FindElement(By.Id("resultStats"));

            string title = driver.Title;
               Console.WriteLine("Title: " + title);
               Console.WriteLine("result: " + expectedResult);

               Assert.True(driver.Title.Contains(expectedResult));
           }

           [TearDown]
           public void UnloadDriver()
           {
               driver.Quit();
           }
       }
     */

    /*
    // Sleep
    public class Google2
    {
        private IWebDriver driver;

        [SetUp]
        public void LoadDriver()
        {
            Console.WriteLine("SetUp");
            driver = new ChromeDriver();
        }

        [TestCase("Bing", "Bing")] //Serching för Bing on Google, Title of finished search page should be 'Bing'
        public void Search(string searchString, string expectedResult)
        {
            driver.Navigate().GoToUrl("http://google.com");
            IWebElement searchField = driver.FindElement(By.Name("q"));
            searchField.SendKeys(searchString);
            searchField.SendKeys(Keys.Enter);

            Thread.Sleep(10000);
            driver.FindElement(By.Id("resultStats"));

            string title = driver.Title;
            Console.WriteLine("Title: " + title);
            Console.WriteLine("result: " + expectedResult);

            Assert.True(driver.Title.Contains(expectedResult));
        }

        [TearDown]
        public void UnloadDriver()
        {
            driver.Quit();
        }
    }
    */

    /*
        // Explicit wait
        public class Google3
        {
            private IWebDriver driver;

            [SetUp]
            public void LoadDriver()
            {
                Console.WriteLine("SetUp");
                driver = new ChromeDriver();
            }

            [TestCase("Bing", "Bing")]
            public void Search(string searchString, string expectedResult)
            {
                driver.Navigate().GoToUrl("http://google.com");
                IWebElement searchField = driver.FindElement(By.Name("q"));
                searchField.SendKeys(searchString);
                searchField.SendKeys(Keys.Enter);

                WebDriverWait myWait10 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement resultStats = myWait10.Until(drv => drv.FindElement(By.Id("resultStats")));

                string title = driver.Title;
                Console.WriteLine("Title: " + title);
                Console.WriteLine("result: " + expectedResult);

                Assert.True(driver.Title.Contains(expectedResult));
            }

            [TearDown]
            public void UnloadDriver()
            {
                driver.Quit();
            }
        }

    */
    /*
    // Implicit wait
    public class Google4
    {
        private IWebDriver driver;

        [SetUp]
        public void LoadDriver()
        {
            Console.WriteLine("SetUp");
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [TestCase("Bing", "Bing")]
        public void Search(string searchString, string expectedResult)
        {
            driver.Navigate().GoToUrl("http://google.com");
            IWebElement searchField = driver.FindElement(By.Name("q"), 10);
            searchField.SendKeys(searchString);
            searchField.SendKeys(Keys.Enter);

            driver.FindElement(By.Id("resultStats"));

            string title = driver.Title;
            Console.WriteLine("Title: " + title);
            Console.WriteLine("result: " + expectedResult);

            Assert.True(driver.Title.Contains(expectedResult));
        }

        [TearDown]
        public void UnloadDriver()
        {
            driver.Quit();
        }
    }
    */

    
    // Helper class
    public class Google5
    {
        private IWebDriver driver;

        [SetUp]
        public void LoadDriver()
        {
            Console.WriteLine("SetUp");
            driver = new ChromeDriver();
        }

        [TestCase("Bing", "Bing")]
        public void Search(string searchString, string expectedResult)
        {
            driver.Navigate().GoToUrl("http://google.com");
            IWebElement searchField = driver.FindElement(By.Name("q"), 10);
            searchField.SendKeys(searchString);
            searchField.SendKeys(Keys.Enter);

            driver.FindElement(By.Id("resultStats"), 10);

            string title = driver.Title;
            Console.WriteLine("Title: " + title);
            Console.WriteLine("result: " + expectedResult);

            Assert.True(driver.Title.Contains(expectedResult));
        }

        [TearDown]
        public void UnloadDriver()
        {
            driver.Quit();
        }
    }
    

}