using Entidades.Final;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Esquivel.Tobias
{
    public partial class FrmListado : Form
    {
        private List<Usuario> usuarios;


        public FrmListado()
        {
            InitializeComponent();
            this.usuarios = new List<Usuario>();
        }


        private async void FrmListado_Load(object sender, EventArgs e)
        {

            this.usuarios = await ADO.ObtenerTodos() ?? new List<Usuario>(); ;

            if (this.usuarios.Count > 0)
            {
                this.RellenarDataGrid(this.usuarios);
            }

        }

        private void RellenarDataGrid(List<Usuario> usuarios)
        {

            foreach (Usuario usuario in usuarios)
            {
                DataGridViewRow fila = new DataGridViewRow();

                DataGridViewTextBoxCell celNombre = new DataGridViewTextBoxCell() { Value = usuario.Nombre };

                DataGridViewTextBoxCell celApellido = new DataGridViewTextBoxCell() { Value = usuario.Apellido };

                DataGridViewTextBoxCell celDni = new DataGridViewTextBoxCell() { Value = usuario.Dni };

                DataGridViewTextBoxCell celCorreo = new DataGridViewTextBoxCell() { Value = usuario.Correo };

                DataGridViewTextBoxCell celClave = new DataGridViewTextBoxCell() { Value = usuario.Clave };

                fila.Cells.AddRange([celNombre, celApellido, celDni, celCorreo, celClave]);

                this.dgListado.Rows.Add(fila);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmUsuario formUsuario = new FrmUsuario("agregar");

            formUsuario.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgListado.SelectedCells.Count != 5)
                MessageBox.Show("Seleccione un solo usuario para modificar");

            else
            {
                Usuario usuario = this.ObtenerUsuarioDG();
                FrmUsuario formUsuario = new FrmUsuario("modificar", usuario);
                formUsuario.ShowDialog();

                this.RefrescarListado(sender, e);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgListado.SelectedCells.Count != 5)
                MessageBox.Show("Seleccione un solo usuario para modificar");

            else
            {
                Usuario usuario = this.ObtenerUsuarioDG();
                FrmUsuario formUsuario = new FrmUsuario("eliminar", usuario);
                formUsuario.ShowDialog();
                this.RefrescarListado(sender, e);
            }
        }

        private Usuario ObtenerUsuarioDG()
        {
            string nombre = this.dgListado.SelectedCells[0].Value?.ToString() ?? "Sin nombre";
            string apellido = this.dgListado.SelectedCells[1].Value?.ToString() ?? "Sin apellido";
            int dni = int.Parse(this.dgListado.SelectedCells[2].Value.ToString() ?? "0");
            string correo = this.dgListado.SelectedCells[3].Value?.ToString() ?? "Sin correo";
            string clave = this.dgListado.SelectedCells[4].Value?.ToString() ?? string.Empty;


            Usuario usuario = new Usuario(nombre, apellido, dni, correo, clave);

            return usuario;
        }

        private void RefrescarListado(object sender, EventArgs e)
        {
            this.dgListado.Rows.Clear();
            this.FrmListado_Load(sender, e);
        }
    }
}
