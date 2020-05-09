using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repository
{
    public interface IRepository<T> where T:IBase
    {
        void Add(T entity);
        void AddGroup(IEnumerable<T> listOfEntities);
        void Remove(int id);
        void RemoveAll();
        Task<T> Get(int id);
        IEnumerable<T> GetAll();
        void UpdateWithoutId(T entity);
    }
}