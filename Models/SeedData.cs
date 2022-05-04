using Microsoft.EntityFrameworkCore;

namespace RazorPagesApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMagicItemContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMagicItemContext>>()))
            {
                if (context == null || context.MagicItem == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.MagicItem.Any())
                {
                    return;   // DB has been seeded
                }

                context.MagicItem.AddRange(
                    new MagicItem
                    {
                        Name = "Crown of Thorns",
                        Rarity = 2,
                        Type = "Helmet",
                        Description = "A woven band of jagged thorns.",
                        Cost = 50
                    },

                    new MagicItem
                    {
                        Name = "Bottomless Mug of Ale",
                        Rarity = 4,
                        Type = "Accessory",
                        Description = "This mug replenishes itself once every few minutes.",
                        Cost = 75
                    },

                    new MagicItem
                    {
                        Name = "Ice Spear",
                        Rarity = 1,
                        Type = "Weapon",
                        Description = "A pointy weapon enchanted with frost.",
                        Cost = 20
                    }
                );
                context.SaveChanges();
            }
        }
    }
}