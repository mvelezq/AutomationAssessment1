using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationAssessment1
{
    class SearchMethods
    {
        
        public IWebElement Tittle
            => PropertiesCollection.driver.FindElement(By.Name("Tittle"));

        public IWebElement inputSearchBar
            => PropertiesCollection.driver.FindElement(By.XPath("//div[5]/table/*[@id='search_bar']"));

        public IWebElement inputSearchResultBookTittle
            => PropertiesCollection.driver.FindElement(By.XPath("//div[3]/table/*[@class='book_title']"));
        public IWebElement inputSearchBookResultAutor
           => PropertiesCollection.driver.FindElement(By.XPath("//div[3]/table/*[@class='book_author']"));

        public void SearchBar(string value)
        {
            inputSearchBar.Clear();
            inputSearchBar.SendKeys(value);
                
        }

        public void SearchResult(string value, string type)
        {
            if(type=="BookTittle")
                Questions.CompareTittle(inputSearchResultBookTittle, value);
            if(type=="BookAutor")
                Questions.CompareTittle(inputSearchResultBookTittle, value);
            if (type == "Tittle")
                Questions.CompareTittle(Tittle, value);

        }

     }
}
