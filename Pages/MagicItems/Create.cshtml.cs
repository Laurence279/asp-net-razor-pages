#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages.MagicItems
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMagicItemContext _context;

        public CreateModel(RazorPagesMagicItemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MagicItem MagicItem { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MagicItem.Add(MagicItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
