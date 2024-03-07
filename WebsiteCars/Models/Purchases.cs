using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteCars.Models
{
    public partial class Purchases
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal? Price { get; set; }
    }
}
