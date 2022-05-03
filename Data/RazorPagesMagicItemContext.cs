#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesApp.Models;

    public class RazorPagesMagicItemContext : DbContext
    {
        public RazorPagesMagicItemContext (DbContextOptions<RazorPagesMagicItemContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesApp.Models.MagicItem>? MagicItem { get; set; }
    }
