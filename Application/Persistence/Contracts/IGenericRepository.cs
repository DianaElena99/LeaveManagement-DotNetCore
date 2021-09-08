using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<T> Get(int Id);
        Task<IReadOnlyList<T>> GetAll();
        Task<bool> Exists(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
    }
}
