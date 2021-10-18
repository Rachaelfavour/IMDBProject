Feature: Search
	As a user of IMDB.com
	I want to search for Top rated movies
	so that I can select comedy movie to watch

@mytag
Scenario: SearchForComedyMovies
	Given I navigate to 'https://www.imdb.com/chart/top/'
	When I search for genre 'Comedy'
	Then I should see relevant result displayed


@mytag
Scenario: Search for release date
	Given I navigate to 'https://www.imdb.com/chart/top/'
	When I sort for "us:descending"
	Then I should see the list of movies displyed in order of release date