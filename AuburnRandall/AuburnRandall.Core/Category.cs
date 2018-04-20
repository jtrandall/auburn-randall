using System;
using System.Collections.Generic;
using System.Text;

namespace AuburnRandall.Core
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Subheader { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
    }
}
