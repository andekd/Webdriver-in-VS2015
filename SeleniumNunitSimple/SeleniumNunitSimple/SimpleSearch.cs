using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;


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

        [TestCase("Bing", "Bing")]
        public void Search(string searchString, string expectedResult)
        {
            // execute Search twice with testdata: Google, Bing

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
            //driver.Quit();
        }
    }
    */

    public class Google2
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
            // execute Search twice with testdata: Google, Bing

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
            //driver.Quit();
        }
    }

    /*
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
            // execute Search twice with testdata: Google, Bing

            driver.Navigate().GoToUrl("http://google.com");
            IWebElement searchField = driver.FindElement(By.Name("q"), 10);
            searchField.SendKeys(searchString);
            searchField.SendKeys(Keys.Enter);

            driver.FindElement(By.Id("resultStats"), 15);

            string title = driver.Title;
            Console.WriteLine("Title: " + title);
            Console.WriteLine("result: " + expectedResult);

            Assert.True(driver.Title.Contains(expectedResult));
        }

        [TearDown]
        public void UnloadDriver()
        {
            //driver.Quit();
        }
    }
    */
}
