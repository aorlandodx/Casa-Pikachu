using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Casa_pikachu.Pages;

public class DiegoModel : PageModel
{
    private readonly ILogger<DiegoModel> _logger;

    public DiegoModel(ILogger<DiegoModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

