using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IRepository<T> where T : class 
    {
        Task<T> GetbyId(int Id);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task<T> GetAllAsync();
        Task DeleteAsync(T entity);
    }

}
