using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LearnRazorPages.Data;
using LearnRazorPages.Models;

namespace LearnRazorPages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly LearnRazorPages.Data.RazorPagesMovieContext _context;

        public IndexModel(LearnRazorPages.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
