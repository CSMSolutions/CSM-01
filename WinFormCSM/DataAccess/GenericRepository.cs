using Microsoft.EntityFrameworkCore;
using Models;
using System.Linq.Expressions;

namespace DataAccess
{
    public class GenericRepository<T> where T : class
    {
        public void Delete(object id)
        {
            using var context = new CSMContext();
            var dbSet = context.Set<T>();
            var entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"Entity with ID {id} not found.");
            }
        }

        public async Task DeleteAsync(object id)
        {
            using var context = new CSMContext();
            var dbSet = context.Set<T>();
            var entity = await dbSet.FindAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException($"Entity with ID {id} not found.");
            }
        }

        public async Task<List<T>> FindListAsync(Expression<Func<T, bool>> predicate)
        {
            using var context = new CSMContext();
            try
            {
                return await context.Set<T>().Where(predicate).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while retrieving the list of entities.", ex);
            }
        }

        public async Task<T?> FindAsync(Expression<Func<T, bool>> predicate)
        {
            using var context = new CSMContext();
            try
            {
                return await context.Set<T>().FirstOrDefaultAsync(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while retrieving the entity.", ex);
            }
        }

        public IEnumerable<T> Get(int index, int pageSize)
        {
            using var context = new CSMContext();
            try
            {
                return context.Set<T>().Skip(index * pageSize).Take(pageSize).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while retrieving paginated entities.", ex);
            }
        }

        public List<T> GetAll()
        {
            using var context = new CSMContext();
            try
            {
                return [.. context.Set<T>()];
            }
            catch (Exception ex)
            {
                throw new Exception("Error while retrieving all entities.", ex);
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            using var context = new CSMContext();
            try
            {
                return await context.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while retrieving all entities asynchronously.", ex);
            }
        }

        public T GetById(object id)
        {
            using var context = new CSMContext();
            var entity = context.Set<T>().Find(id);
            return entity ?? throw new KeyNotFoundException($"Entity with ID {id} not found.");
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            using var context = new CSMContext();
            var entity = await context.Set<T>().FindAsync(id);
            return entity ?? throw new KeyNotFoundException($"Entity with ID {id} not found.");
        }

        public void Insert(T obj)
        {
            using var context = new CSMContext();
            var dbSet = context.Set<T>();
            dbSet.Add(obj);
            context.SaveChanges();
        }

        public async Task InsertAsync(T obj)
        {
            using var context = new CSMContext();
            var dbSet = context.Set<T>();
            await dbSet.AddAsync(obj);
            await context.SaveChangesAsync();
        }

        public void InsertRange(List<T> obj)
        {
            using var context = new CSMContext();
            var dbSet = context.Set<T>();
            dbSet.AddRange(obj);
            context.SaveChanges();
        }

        public async Task InsertCollection(ICollection<T> collection)
        {
            using var context = new CSMContext();
            var dbSet = context.Set<T>();
            await dbSet.AddRangeAsync(collection);
            await context.SaveChangesAsync();
        }

        public void Update(T obj)
        {
            using var context = new CSMContext();
            var dbSet = context.Set<T>();
            dbSet.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();
        }

        public async Task UpdateAsync(T obj)
        {
            using var context = new CSMContext();
            var dbSet = context.Set<T>();
            dbSet.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
