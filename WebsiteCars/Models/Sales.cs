using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteCars.Models
{
    public partial class Sales
    {
        public int Id { get; set; }
        public DateTime? SaleDate { get; set; }
        public int ClientsId { get; set; }
        public int CarsId { get; set; }

        public virtual Cars Cars { get; set; }
        public virtual Clients Clients { get; set; }
    }
}
