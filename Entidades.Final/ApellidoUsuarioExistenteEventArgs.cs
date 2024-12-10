using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public class ApellidoUsuarioExistenteEventArgs : EventArgs
    {
        private List<Usuario> usuarios;
        private DateTime fecha;
        private string? apellido;

        public ApellidoUsuarioExistenteEventArgs()
        {
            this.usuarios = new List<Usuario>();
            this.fecha = DateTime.Now;
        }

        public ApellidoUsuarioExistenteEventArgs(List<Usuario> usuarios) : this()
        {
            if (usuarios == null || usuarios.Count == 0)
                throw new ArgumentException("La lista de usuarios no puede estar vacía", nameof(usuarios));

            this.usuarios = usuarios;
            this.apellido = usuarios.First().Apellido;
        }


        public List<Usuario> Usuarios { get => usuarios; set => usuarios=value; }
        public DateTime Fecha { get => fecha; set => fecha=value; }
        public string? Apellido { get => apellido; set => apellido=value; }
    }
}
