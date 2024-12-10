using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public interface IRepository<T> : IInsertAsync<T>, IGetAllAsync<T>
    {
        public Task<bool> UpdateAsync(T entity);
        public Task<bool> DeleteAsync(int dni);
        public Task<T?> GetByDniAsync(int dni);
    }
}
