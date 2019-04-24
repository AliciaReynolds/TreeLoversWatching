using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TreeLoversWatching.Data;
using TreeLoversWatching.Models;

namespace TreeLoversWatching.Pages.Tree
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Trees Trees { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trees = await _context.Trees.FirstOrDefaultAsync(m => m.ID == id);

            if (Trees == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
