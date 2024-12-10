using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public interface IGetAllAsync<T>
    {
        public Task<List<T>?> GetAllAsync();
    }
}
