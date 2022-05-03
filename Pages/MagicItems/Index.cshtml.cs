#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

namespace razor_page_app.Pages_MagicItems
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMagicItemContext _context;

        public IndexModel(RazorPagesMagicItemContext context)
        {
            _context = context;
        }

        public IList<MagicItem> MagicItem { get;set; }

        public async Task OnGetAsync()
        {
            MagicItem = await _context.MagicItem.ToListAsync();
        }
    }
}
