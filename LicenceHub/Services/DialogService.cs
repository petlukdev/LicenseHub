using LicenseHub.DB;

namespace LicenseHub.Services
{
    public class DialogService
    {
        private readonly AppDbContext _db;

        public DialogService(AppDbContext db) => _db = db;

        public bool AddEntity(Form form)
        {
            using (form)
            {
                if (form.ShowDialog() != DialogResult.OK) return false;

                object result = ((dynamic)form).Result
                    ?? throw new ArgumentNullException("Result is null!");

                _db.Add(result);

                try
                {
                    _db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    _db.Remove(result); // Rollback the addition if save fails
                    throw ex.InnerException ?? ex;
                }
            }
        }

        public bool ModifyEntity(Form form, object entity)
        {
            using (form)
            {
                if (form.ShowDialog() != DialogResult.OK) return false;

                object result = ((dynamic)form).Result
                    ?? throw new ArgumentNullException("Result is null!");

                try
                {
                    var entry = _db.Entry(entity);
                    entry.CurrentValues.SetValues(result);

                    foreach (var navigation in entry.Navigations)
                    {
                        var propertyInfo = entry.Metadata.ClrType.GetProperty(navigation.Metadata.Name);
                        if (propertyInfo != null && propertyInfo.CanWrite)
                        {
                            var newValue = propertyInfo.GetValue(result);
                            propertyInfo.SetValue(entity, newValue);
                        }
                    }

                    _db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    _db.Entry(entity).CurrentValues.SetValues(_db.Entry(entity).OriginalValues);
                    throw ex.InnerException ?? ex;
                }
            }
        }
    }
}
