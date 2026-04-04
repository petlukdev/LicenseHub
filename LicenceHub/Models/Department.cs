using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LicenseHub.Models
{
    public class Department
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<Owner> Owners { get; } = [];
    }
}
