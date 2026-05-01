using LicenseHub.DB;
using LicenseHub.Helpers;
using Microsoft.EntityFrameworkCore;

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

        public bool DeleteEntities(IEnumerable<object> entities)
        {
            try
            {
                foreach (var entity in entities) _db.Remove(entity);
                _db.SaveChanges();
                return true;
            }
            catch (InvalidOperationException ex)
            {
                RollbackDeletedEntities();
                throw new InvalidOperationException(
                    "An entry cannot be deleted! This entry is currently in use by another entity. Try deleting that entity first, if necessary."
                );
            }
            catch (Exception ex)
            {
                RollbackDeletedEntities();
                throw ex.InnerException ?? ex;
            }
        }

        private void RollbackDeletedEntities()
        {
            foreach (var entry in _db.ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted))
            {
                entry.State = EntityState.Unchanged;
            }
        }
    }
}
