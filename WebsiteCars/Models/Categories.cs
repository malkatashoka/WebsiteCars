using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteCars.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Cars = new HashSet<Cars>();
        }

        public int Id { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Cars> Cars { get; set; }
    }
}
