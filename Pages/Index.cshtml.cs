using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CIDM3312_finalProject_ThomasCrouch.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    // upon loading this Index, the page will immediately redirect to the Index within the Prisons folder
    public IActionResult OnGet()
    {
        return RedirectToPage("./Prisons/Index");
    }
}
