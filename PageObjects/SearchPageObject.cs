using IMDBProject.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDBProject.PageObjects
{
    class SearchPageObject
    {
        IWebDriver driver;

        public SearchPageObject()
        {
            driver = Search.driver;
        }

        IWebElement searchGenre => driver.FindElement(By.XPath("//*[@id='sidebar']/div[6]/span/ul/li[5]/a"));
        IWebElement sortBy => driver.FindElement(By.CssSelector("#lister-sort-by-options"));
        IWebElement SearchComedy => driver.FindElement(By.XPath("//div[1]/div[3]/h3/a"));
        IWebElement SearchPage => driver.FindElement(By.Id("lister-sort-by-options"));


        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Genre(string genre)
        {
            Assert.AreEqual(genre, searchGenre.Text);
            searchGenre.Click();
        }

        public void SortBy(string criteria)
        {
            var select = new SelectElement(sortBy);
            select.SelectByValue(criteria);
        }

        public void Result()
        {
            Assert.IsTrue(SearchComedy.Displayed);

        }

        public void ReleaseDate ()

        {
            Assert.IsTrue(SearchPage.Displayed);
            

           

        }
    }
}
