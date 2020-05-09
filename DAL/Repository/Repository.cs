using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class Repository<T> :IRepository<T> where T : class, IBase
    {
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private ApplicationContext _context=new ApplicationContext();
        public async void Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async void AddGroup(IEnumerable<T> listOfEntities)
        {
               await _context.Set<T>().AddRangeAsync(listOfEntities);
               await _context.SaveChangesAsync();
        }

        public void Remove(int id)
        {
            _context.Set<T>().Remove(Get(id).Result);
        }

        public void RemoveAll()
        {
            _context.Set<T>().RemoveRange(GetAll());
        }

        public async Task<T> Get(int id)
        {
           return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void UpdateWithoutId(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}