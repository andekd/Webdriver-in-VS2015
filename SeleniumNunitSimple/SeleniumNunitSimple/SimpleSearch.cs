using NUnit.Framework;
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
}
