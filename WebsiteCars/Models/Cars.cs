using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteCars.Models
{
    public partial class Cars
    {
        public Cars()
        {
            Sales = new HashSet<Sales>();
        }

        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public decimal? Price { get; set; }
        public int EngineId { get; set; }
        public int CategoryId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Engines Engine { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
