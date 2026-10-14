using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Raileanu_Bogdan_Lab2.Models;

namespace Raileanu_Bogdan_Lab2.Pages.AuthorPages;

public class IndexModel : PageModel
{
    private readonly Raileanu_Bogdan_Lab2Context _context;

    public IndexModel(Raileanu_Bogdan_Lab2Context context)
    {
        _context = context;
    }

    public IList<Author> Author { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Author = await _context.Author.ToListAsync();
    }
}
