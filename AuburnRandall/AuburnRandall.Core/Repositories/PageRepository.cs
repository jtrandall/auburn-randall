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
                    Title = "Projects",
                    Subheader = "Things that I've been working on",
                    Summary = "This is the content of the card",
                    Icon = "build",
                    Url = "/Home/Projects"
                },

                new Page()
                {
                    Title = "Articles",
                    Subheader = "Things that I've written about",
                    Summary = "This is the content of the card",
                    Icon = "lightbulb_outline",
                    Url = "/Home/Articles"
                },

                new Page()
                {
                    Title = "About Me",
                    Subheader = "A little about myself",
                    Summary = "This is the content of the card",
                    Icon = "person",
                    Url = "/Home/About"
                }
            };

            return pages;
        }
    }
}
