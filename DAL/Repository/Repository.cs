using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Models;

namespace DAL.Repository
{
    public class Repository<T> :IRepository<T> where T : class, IBase
    {
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        private ApplicationContext _context=new ApplicationContext();
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void AddGroup(IEnumerable<T> listOfEntities)
        {
            foreach (var entity in listOfEntities)
            {
                _context.Set<T>().Add(entity);
            }

            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            _context.Set<T>().Remove(Get(id));
        }

        public void RemoveAll()
        {
            _context.Set<T>().RemoveRange(GetAll());
        }

        public T Get(int id)
        {
           return _context.Set<T>().FirstOrDefault(x => x.Id == id);
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