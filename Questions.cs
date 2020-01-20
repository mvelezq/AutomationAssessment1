using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationAssessment1
{
    class Questions
    {
        public static void CompareTittle(IWebElement element, string value)
        {
            Assert.AreEqual(value, element);
        }
                
    }
}
