using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

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
            pageMethods.SearchResult("Library Page","Tittle");
            pageMethods.SearchBar("Learning Selenium WebDriver in C#");
            pageMethods.SearchResult("Learning Selenium WebDriver in C#", "BookTittle");

        }

        [Test]
        public void Test2()
        {
            SearchMethods pageMethods = new SearchMethods();
            pageMethods.SearchResult("Library Page", "Tittle");
            pageMethods.SearchBar("Author: Stephen Hawking");
            pageMethods.SearchResult("Author: Stephen Hawking", "BookAutor");

        }

        [TearDown]
        public void CLoseNavegator()
        {
            PropertiesCollection.driver.Close();
        }
    }
}