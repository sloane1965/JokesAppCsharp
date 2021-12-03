using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Jokes.Data;
using Jokes.Models;

namespace Jokes.Pages
{
    public class ShowSearchResultsModel : PageModel
    {
        private readonly Jokes.Data.ApplicationDbContext _context;

        public ShowSearchResultsModel(Jokes.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Joke> Joke { get;set; }

        public async Task OnGetAsync()
        {
            Joke = await _context.Joke.ToListAsync();
        }
    }
}
