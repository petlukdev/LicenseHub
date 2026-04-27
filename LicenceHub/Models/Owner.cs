using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LicenseHub.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public ICollection<License> Licenses { get; } = [];

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public override string ToString()
        {
            return FullName;
        }
    }
}
