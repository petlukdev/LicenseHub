using System;
using System.Collections.Generic;
using System.Text;

namespace LicenseHub.Models
{
    public class License
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Key { get; set; }
        public LicenseType Type { get; set; }
        public double Cost { get; set; }
        public DateTime ExpirationDate { get; set; }
        public ExpirationStatus ExpirationStatus
        {
            get
            {
                var daysToExpire = (ExpirationDate - DateTime.Now).TotalDays;
                if (daysToExpire < 0) return ExpirationStatus.Expired;
                if (daysToExpire < 30) return ExpirationStatus.ExpiringSoon;
                return ExpirationStatus.Active;
            }
        }
        public int OwnerId { get; set; }
        public required Owner Owner { get; set; }
        public int SupplierId { get; set; }
        public required Supplier Supplier { get; set; }
    }

    public enum LicenseType
    {
        Perpetual,
        Subscription
    }

    public enum ExpirationStatus
    {
        Active,
        Expired,
        ExpiringSoon
    }
}
