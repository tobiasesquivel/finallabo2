using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public class UsuarioRepository : IRepository<Usuario>
    {
        public async Task<Usuario?> GetByEmailAndPassword(string correo, string clave)
        {
            string query = $"SELECT * FROM Usuarios WHERE Correo = @Correo AND Clave = @Clave";
            SqlParameter[] parametros =
            {
                new SqlParameter("@Correo", correo),
                new SqlParameter("@Clave", clave)
            };

            UsuarioMapper mapper = new UsuarioMapper();
            return await new ADO().ObtenerAsync(query, parametros, mapper);
        }

        public Task<bool> DeleteAsync(int dni)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>?> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario?> GetByDniAsync(int dni)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
