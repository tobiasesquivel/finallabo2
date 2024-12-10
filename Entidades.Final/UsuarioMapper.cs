using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public class UsuarioMapper : IMapper<Usuario>
    {
        public Usuario MapearDataReader(IDataReader dataReader)
        {
            if (dataReader == null) throw new ArgumentNullException();
            int dni = (int)dataReader["Dni"];
            string nombre = dataReader["Nombre"].ToString() ?? string.Empty;
            string apellido = dataReader["Apellido"].ToString() ?? string.Empty;
            string correo = dataReader["Correo"].ToString() ?? string.Empty;
            string clave = dataReader["Clave"].ToString() ?? string.Empty;

            return new Usuario(nombre, apellido, dni, correo, clave);
        }
    }
}
