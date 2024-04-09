using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChatApp.Pages
{
    public class ShapeModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public ShapeModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
