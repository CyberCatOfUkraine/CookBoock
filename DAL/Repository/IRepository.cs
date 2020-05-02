using System.Collections;
using System.Collections.Generic;
using DAL.Models;

namespace DAL.Repository
{
    public interface IRepository<T> where T:IBase
    {
        void Add(T entity);
        void AddGroup(IEnumerable<T> listOfEntities);
        void Remove(int id);
        void RemoveAll();
        T Get(int id);
        IEnumerable<T> GetAll();
        void Update(int id, T entity);
    }
}