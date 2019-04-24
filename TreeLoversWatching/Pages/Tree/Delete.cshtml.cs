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
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trees = await _context.Trees.FindAsync(id);

            if (Trees != null)
            {
                _context.Trees.Remove(Trees);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
