#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages.MagicItems
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMagicItemContext _context;

        public DeleteModel(RazorPagesMagicItemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MagicItem MagicItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MagicItem = await _context.MagicItem.FirstOrDefaultAsync(m => m.ID == id);

            if (MagicItem == null)
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

            MagicItem = await _context.MagicItem.FindAsync(id);

            if (MagicItem != null)
            {
                _context.MagicItem.Remove(MagicItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
