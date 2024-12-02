using PlaywrightSpecFlowPOM.Pages;

namespace PlaywrightSpecFlowPOM.Steps;

[Binding]
public class SearchResultSteps
{
    private readonly SearchResultsPage _searchResultsPage;

    public SearchResultSteps(SearchResultsPage searchResultsPage)
    {
        _searchResultsPage = searchResultsPage;
    }

    
}