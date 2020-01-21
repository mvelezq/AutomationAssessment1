using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using static AutomationAssessment1.Constants;

namespace AutomationAssessment1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            PropertiesCollection.driver = new FirefoxDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://localhost/index.html");
            PropertiesCollection.driver.Manage().Window.Maximize();       
        }

        [Test]
        public void Test1()
        {
            SearchMethods pageMethods = new SearchMethods();
            pageMethods.SearchResult(tittlePage,tittleType);
            pageMethods.SearchBar(tittleBook);
            pageMethods.SearchResult(tittleBook,bookType);

        }

        [Test]
        public void Test2()
        {
            SearchMethods pageMethods = new SearchMethods();
            pageMethods.SearchResult(tittlePage, tittleType);
            pageMethods.SearchBar(authorBook);
            pageMethods.SearchResult(authorBook, authorType);

        }

        [TearDown]
        public void CLoseNavegator()
        {
            PropertiesCollection.driver.Close();
        }
    }
}