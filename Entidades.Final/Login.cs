using Microsoft.Data.SqlClient;

namespace Entidades.Final
{
    public class Login
    {
        private string email;
        private string clave;
        public Login(string correo, string clave)
        {
            this.email = correo;
            this.clave = clave;
        }

        public async Task<bool> Loguear()
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();
            Usuario? usuario = await usuarioRepository.GetByEmailAndPassword(this.email, this.clave);
            return usuario != null;
        }
    }
}
