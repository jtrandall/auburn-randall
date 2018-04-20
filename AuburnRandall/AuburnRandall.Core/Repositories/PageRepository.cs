using System;
using System.Collections.Generic;
using System.Text;

namespace AuburnRandall.Core.Repositories
{
    public class PageRepository
    {
        public static IEnumerable<Page> GetPages()
        {
            var pages = new List<Page>
            {
                new Page()
                {
                    Id = Guid.Parse("0B18643C-E289-4184-A408-A19C4EE660AA"),
                    Title = "Projects",
                    Subheader = "Things that I've been working on",
                    Summary = "Projects and tasks that I have am working on.",
                    Icon = "build"
                },

                new Page()
                {
                    Id = Guid.Parse("6F9740E9-1982-4A08-B570-3A7CD5A7F476"),
                    Title = "Articles",
                    Subheader = "Things that I've written about",
                    Summary = "Thoughts and notes about topics that interest me.",
                    Icon = "lightbulb_outline"
                },

                new Page()
                {
                    Id = Guid.Parse("B44F4F45-D7FA-4E7C-A51E-AADBC32DFE04"),
                    Title = "About Me",
                    Subheader = "A little about myself",
                    Summary = "A glimpse into my life",
                    Icon = "person"
                }
            };

            return pages;
        }
    }
}
