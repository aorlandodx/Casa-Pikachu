using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Casa_pikachu.Pages;

public class AngelModel : PageModel
{
    private readonly ILogger<AngelModel> _logger;

    public AngelModel(ILogger<AngelModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

