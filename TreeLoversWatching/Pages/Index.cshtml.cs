using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TreeLoversWatching.Data;
using TreeLoversWatching.Models;

namespace TreeLoversWatching.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Trees Trees { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Trees = await _context.Trees.FirstOrDefaultAsync();
            return Page();
        }
    }
}
