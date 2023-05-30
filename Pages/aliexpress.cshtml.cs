using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;
using AspReglini.Models;

namespace AspReglini.Pages
{
    public class aliexpressModel : PageModel
    {
        public string? Query { get; set; }
        public ISearchResult? searchResult;

        public void OnGet()
        {
            string currentUrl = Request.Host.ToString() + Request.Path.ToString() + Request.QueryString.ToString();
            Uri queryUri = new Uri(currentUrl);

            Query = HttpUtility.ParseQueryString(queryUri.Query).Get("query") ?? null;
        }
        
        public void ZapiexSearchQuery()
        {
            Console.WriteLine("todo");
        }
    }
}
