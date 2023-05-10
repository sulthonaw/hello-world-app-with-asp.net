using ContosoCrafts.WebSite.Services;
using HelloWorldWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        public JsonFilePeopleService PeopleService { get; }

        public IEnumerable<People> Peoples { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonFilePeopleService peopleService)
        {   
            _logger = logger;
            PeopleService = peopleService;
        }

        public void OnGet()
        {
            Peoples = PeopleService.GetPeople();
        }
    }
}