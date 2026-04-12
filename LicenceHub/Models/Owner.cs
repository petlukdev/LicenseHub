using System;
using System.Collections.Generic;
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

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
