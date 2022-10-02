using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace TestAutomationPractice.Features
{
    [Binding]
    public class SearchSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);

        [Given(@"user enters '(.*)' search term")]
        public void GivenUserEntersSearchTerm(string term)
        {
            ut.EnterTextInElement(hp.searchField, term);
        }
        
        [When(@"user sumbits the search")]
        public void WhenUserSumbitsTheSearch()
        {
            ut.ClickOnElement(hp.searchBtn);
        }
        
        [Then(@"results for '(.*)' search term are displayed")]
        public void ThenResultsForSearchTermAreDisplayed(string term)
        {
            SearchResultsPage srp = new SearchResultsPage(Driver);          
            Assert.That(ut.ReturnTextFromElement(srp.SearchResult), Does.Contain(term), "Wrong search results are displayed");
        }
    }
}
