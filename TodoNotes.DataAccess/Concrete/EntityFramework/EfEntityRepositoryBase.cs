using System.Data.Entity;
using System.Linq;
using TodoNotes.Entities.Abstract;
using TodoNotes.DataAccess.Abstract;

namespace TodoNotes.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> :
        IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                try
                {
                    context.Entry(entity).State = EntityState.Added;
                    context.SaveChanges();
                    return;
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    // Try to detect common SQL conversion errors (datetime range) and auto-fix
                    var baseMsg = ex.GetBaseException()?.Message ?? string.Empty;
                    if (baseMsg.IndexOf("datetime2", System.StringComparison.OrdinalIgnoreCase) >= 0 &&
                        baseMsg.IndexOf("datetime", System.StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        // Fix any non-nullable DateTime properties that are DateTime.MinValue by setting to UtcNow
                        var props = typeof(TEntity).GetProperties()
                            .Where(p => p.PropertyType == typeof(System.DateTime) && p.CanWrite);

                        var fixedAny = false;
                        foreach (var p in props)
                        {
                            var val = (System.DateTime)p.GetValue(entity);
                            if (val == System.DateTime.MinValue)
                            {
                                p.SetValue(entity, System.DateTime.UtcNow);
                                fixedAny = true;
                            }
                        }

                        if (fixedAny)
                        {
                            // Retry save once
                            try
                            {
                                context.Entry(entity).State = EntityState.Added;
                                context.SaveChanges();
                                return;
                            }
                            catch (System.Data.Entity.Infrastructure.DbUpdateException)
                            {
                                // fall through to rethrow original
                            }
                        }
                    }

                    // If not handled above, rethrow to preserve original stack and error
                    throw;
                }
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                try
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                    return;
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    var baseMsg = ex.GetBaseException()?.Message ?? string.Empty;
                    if (baseMsg.IndexOf("datetime2", System.StringComparison.OrdinalIgnoreCase) >= 0 &&
                        baseMsg.IndexOf("datetime", System.StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        var props = typeof(TEntity).GetProperties()
                            .Where(p => p.PropertyType == typeof(System.DateTime) && p.CanWrite);

                        var fixedAny = false;
                        foreach (var p in props)
                        {
                            var val = (System.DateTime)p.GetValue(entity);
                            if (val == System.DateTime.MinValue)
                            {
                                p.SetValue(entity, System.DateTime.UtcNow);
                                fixedAny = true;
                            }
                        }

                        if (fixedAny)
                        {
                            try
                            {
                                context.Entry(entity).State = EntityState.Modified;
                                context.SaveChanges();
                                return;
                            }
                            catch (System.Data.Entity.Infrastructure.DbUpdateException)
                            {
                                // fall through to rethrow original below
                            }
                        }
                    }

                    throw;
                }
            }
        }

        public void Delete(TEntity entity)  
        {
            using (var context = new TContext())
            {
                try
                {
                    context.Entry(entity).State = EntityState.Deleted;
                    context.SaveChanges();
                    return;
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    var baseMsg = ex.GetBaseException()?.Message ?? string.Empty;
                    if (baseMsg.IndexOf("datetime2", System.StringComparison.OrdinalIgnoreCase) >= 0 &&
                        baseMsg.IndexOf("datetime", System.StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        var props = typeof(TEntity).GetProperties()
                            .Where(p => p.PropertyType == typeof(System.DateTime) && p.CanWrite);

                        var fixedAny = false;
                        foreach (var p in props)
                        {
                            var val = (System.DateTime)p.GetValue(entity);
                            if (val == System.DateTime.MinValue)
                            {
                                p.SetValue(entity, System.DateTime.UtcNow);
                                fixedAny = true;
                            }
                        }

                        if (fixedAny)
                        {
                            try
                            {
                                context.Entry(entity).State = EntityState.Deleted;
                                context.SaveChanges();
                                return;
                            }
                            catch (System.Data.Entity.Infrastructure.DbUpdateException)
                            {
                                // fall through
                            }
                        }
                    }

                    throw;
                }
            }
        }

        public TEntity Get(System.Linq.Expressions.Expression<System.Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public System.Collections.Generic.List<TEntity> GetAll(
            System.Linq.Expressions.Expression<System.Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }
    }
}
