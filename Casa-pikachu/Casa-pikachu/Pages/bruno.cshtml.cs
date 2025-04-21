using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Casa_pikachu.Pages;

public class BrunoModel : PageModel
{
    private readonly ILogger<BrunoModel> _logger;

    public BrunoModel(ILogger<BrunoModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
