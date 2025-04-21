using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Casa_pikachu.Pages;

public class NatModel : PageModel
{
    private readonly ILogger<NatModel> _logger;

    public DiegoModel(ILogger<NatModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
