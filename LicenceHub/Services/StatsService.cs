using LicenseHub.DB;
using LicenseHub.Models;

namespace LicenseHub.Services
{
    public class StatsService
    {
        private readonly AppDbContext _db;

        public StatsService(AppDbContext db) => _db = db;

        public (int Total, int ExpiringSoon, int Expired) GetLicenseStats()
        {
            int total = _db.Licenses.Local.Count;
            int expiring = _db.Licenses.Local.Count(l => l.ExpirationStatus == ExpirationStatus.ExpiringSoon);
            int expired = _db.Licenses.Local.Count(l => l.ExpirationStatus == ExpirationStatus.Expired);

            return (total, expiring, expired);
        }
    }
}
