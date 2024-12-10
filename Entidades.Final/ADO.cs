using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public delegate void ApellidoUsuarioExistenteDelegado(object sender, ApellidoUsuarioExistenteEventArgs e);

    public class ADO
    {
        private string conexionString;
        private SqlConnection conexion;
        public event ApellidoUsuarioExistenteDelegado? ApellidoUsuarioExistente;
        public ADO()
        {
            this.conexionString = @"Server=.;Database=ModeloFinalLabo2;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True";
            this.conexion = new SqlConnection(this.conexionString);
        }

        public async Task<bool> Agregar(Usuario usuario)
        {
            string query = "INSERT INTO Usuarios VALUES (@dni,@nombre,@apellido,@correo,@clave)";
            SqlParameter[] parametros =
            {
                new SqlParameter("@nombre",usuario.Nombre),
                new SqlParameter("@apellido",usuario.Apellido),
                new SqlParameter("@dni",usuario.Dni),
                new SqlParameter("@correo",usuario.Correo),
                new SqlParameter("@clave",usuario.Clave),
            };

            return await this.EjecutarQueryAsync(query, parametros) > 0;
        }

        public async Task<bool> AgregarYContemplarApellidoExistente(Usuario usuario)
        {
            List<Usuario> usuarios = await ADO.ObtenerTodos(usuario.Apellido);

            if (usuarios.Any(usuarioLista => usuarioLista.Apellido == usuario.Apellido))
            {
                ApellidoUsuarioExistenteEventArgs eventInfo = new(usuarios);
                this.OnApellidoUsuarioExistente(eventInfo);
            }
            return await this.Agregar(usuario);
        }
        public async Task<bool> Eliminar(Usuario usuario)
        {
            string query = "DELETE FROM Usuarios WHERE Dni = @dni";
            SqlParameter[] parametro = { new SqlParameter("@dni", usuario.Dni) };
            int filasAfectadas = await EjecutarQueryAsync(query, parametro);
            return filasAfectadas > 0;
        }
        public async Task<bool> Modificar(Usuario usuario)
        {
            string query = "UPDATE Usuarios SET Dni = @dni, Nombre = @nombre, Apellido = @apellido, correo = @correo, clave = @clave WHERE Dni = @dni";
            SqlParameter[] parametros =
            {
                new SqlParameter("@nombre",usuario.Nombre),
                new SqlParameter("@apellido",usuario.Apellido),
                new SqlParameter("@dni",usuario.Dni),
                new SqlParameter("@correo",usuario.Correo),
                new SqlParameter("@clave",usuario.Clave),
            };

            int filasAfectadas = await this.EjecutarQueryAsync(query, parametros);

            return filasAfectadas > 0;
        }

        public async static Task<List<Usuario>> ObtenerTodos()
        {
            string query = "SELECT * FROM Usuarios";
            UsuarioMapper mapper = new UsuarioMapper();
            SqlParameter[] parametros = [];
            List<Usuario>? usuarios = await new ADO().ObtenerColeccionAsync(query, parametros, mapper);

            return usuarios;
        }

        public async static Task<List<Usuario>> ObtenerTodos(string apellidoUsuario)
        {
            string query = "SELECT * FROM Usuarios WHERE Apellido = @apellido";
            UsuarioMapper mapper = new UsuarioMapper();
            SqlParameter[] parametros = [ new SqlParameter("Apellido",apellidoUsuario)];
            List<Usuario>? usuarios = await new ADO().ObtenerColeccionAsync(query, parametros, mapper);

            return usuarios;
        }

        public async Task<List<T>> ObtenerColeccionAsync<T>(string query, SqlParameter[] parametrosConsulta, IMapper<T> mapeador)
        {
            try
            {
                List<T> objetos = new List<T>();
                await this.conexion.OpenAsync();
                using (SqlCommand comando = new SqlCommand(query, this.conexion))
                {
                    comando.Parameters.AddRange(parametrosConsulta);
                    using (IDataReader dataReader = await comando.ExecuteReaderAsync())
                    {
                        while (dataReader.Read())
                        {
                            objetos.Add(mapeador.MapearDataReader(dataReader));
                        }

                        return objetos;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                await this.conexion.CloseAsync();
            }
        }
        public async Task<T?> ObtenerAsync<T>(string query, SqlParameter[] parametrosConsulta, IMapper<T> mapeador)
        {
            try
            {
                await this.conexion.OpenAsync();
                using (SqlCommand comando = new SqlCommand(query, this.conexion))
                {
                    comando.Parameters.AddRange(parametrosConsulta);
                    using (IDataReader dataReader = await comando.ExecuteReaderAsync())
                    {
                        if (dataReader.Read())
                        {
                            return mapeador.MapearDataReader(dataReader);
                        }
                        return default;
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception($"{e.Message}");
            }
            finally
            {
                await this.conexion.CloseAsync();
            }
        }
        public async Task<int> EjecutarQueryAsync(string query, SqlParameter[]? parametrosConsulta = null)
        {
            try
            {
                await this.conexion.OpenAsync();
                int filasAfectadas = 0;
                using (SqlCommand comando = new SqlCommand(query, this.conexion))
                {
                    if (parametrosConsulta != null)
                    {
                        comando.Parameters.AddRange(parametrosConsulta);
                    }
                    filasAfectadas = await comando.ExecuteNonQueryAsync();
                }
                return filasAfectadas;
            }
            catch
            {
                throw new Exception("Error en la base de datos");
            }
            finally
            {
                this.conexion.Close();
            }
        }

        protected virtual void OnApellidoUsuarioExistente(ApellidoUsuarioExistenteEventArgs e)
        {
            this.ApellidoUsuarioExistente?.Invoke(this,e);
        }
    }
}
