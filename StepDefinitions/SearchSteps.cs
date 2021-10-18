using IMDBProject.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace IMDBProject.StepDefinitions
{
    [Binding]
    public class SearchSteps
    {
       
        SearchPageObject search;

        public SearchSteps()
        {
            search = new SearchPageObject();
        }

        [Given(@"I navigate to '(.*)'")]
        public void GivenINavigateTo(string url)
        {
            search.Navigate(url);
        }
        
        [When(@"I search for genre '(.*)'")]
        public void WhenISearchForGenre(string genre)
        {
           search.Genre(genre);
        }
        
        [When(@"I sort for ""(.*)""")]
        public void WhenISortFor(string criteria)
        {
          search.SortBy(criteria);
        }
        
        [Then(@"I should see relevant result displayed")]
        public void ThenIShouldSeeRelevantResultDisplayed()
        {
           search.Result();
        }
        
        [Then(@"I should see the list of movies displyed in order of release date")]
        public void ThenIShouldSeeTheListOfMoviesDisplyedInOrderOfReleaseDate()
        {
            search.ReleaseDate();

        }









    }
}
