using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LicenseHub.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ContactEmail { get; set; }
        public required string ContactPhone { get; set; }
        public ICollection<License> Licenses { get; } = [];
    }
}
