using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public interface IInsertAsync<T>
    {
        public Task<bool> InsertAsync(T entity);
    }
}
