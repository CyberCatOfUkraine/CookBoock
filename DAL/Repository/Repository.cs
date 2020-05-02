using System.Collections.Generic;
using DAL.Models;

namespace DAL.Repository
{
    public class Repository<T> :IRepository<T> where T : IBase
    {
        public void Add(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void AddGroup(IEnumerable<T> listOfEntities)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAll()
        {
            throw new System.NotImplementedException();
        }

        public T Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}