using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public interface IMapper<T>
    {
        public T MapearDataReader(IDataReader dataReader);
    }
}
