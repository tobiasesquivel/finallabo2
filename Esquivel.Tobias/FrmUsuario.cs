using Entidades.Final;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esquivel.Tobias
{
    public partial class FrmUsuario : Form
    {
        public Usuario? Usuario { get; }
        private string usoFormulario;
        public FrmUsuario(string usoFormulario)
        {
            InitializeComponent();
            this.usoFormulario = usoFormulario;
        }

        public FrmUsuario(string usoFormulario, Usuario usuario) : this(usoFormulario)
        {
            this.Usuario = usuario;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            switch (this.usoFormulario)
            {
                case "agregar":
                    btnAceptar.Click += btnAceptarAgregar_Click;
                    break;
                case "modificar":
                    this.RellenarTextBoxes();
                    this.txtDni.ReadOnly = true;
                    btnAceptar.Click += btnAceptarModificar_Click;
                    break;
                case "eliminar":
                    this.RellenarTextBoxes();
                    this.HacerTextBoxesReadonly([this.txtNombre, this.txtApellido, this.txtDni, this.txtCorreo, this.txtClave]);
                    btnAceptar.Click += btnAceptarEliminar_Click;
                    break;
            }
        }

        private async void btnAceptarAgregar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (CamposCompletados() == true)
                {
                    ADO ado = new ADO();
                    Usuario usuario = new Usuario(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), txtCorreo.Text, txtClave.Text
                        );

                    ado.ApellidoUsuarioExistente += Manejadora.Manejador_ApellidoExistenteLog;
                    ado.ApellidoUsuarioExistente += Manejadora.Manejador_ApellidoExistenteJSON;

                    bool usuarioAgregado = await ado.AgregarYContemplarApellidoExistente(usuario);

                    MessageBox.Show( usuarioAgregado ? "Usuario agregado" : "El usuario no pudo ser agregado");
                }
                else
                {
                    MessageBox.Show("Complete todos los campos\n(Clave no es obligatorio)");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un valor numerico en DNI");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnAceptarModificar_Click(object? sender, EventArgs e)
        {
            ADO ado = new ADO();
            Usuario usuario = this.ObtenerUsuarioDeForm();
            bool fueModificado = await ado.Modificar(usuario ?? throw new ArgumentNullException());

            if (fueModificado) MessageBox.Show("Usuario modificado");

            else MessageBox.Show("Usuario no modificado");
        }

        private void RellenarTextBoxes()
        {
            if(this.Usuario != null)
            {
                this.txtNombre.Text = Usuario.Nombre;
                this.txtApellido.Text = Usuario.Apellido;
                this.txtDni.Text = Usuario.Dni.ToString();
                this.txtCorreo.Text = Usuario.Correo;
                this.txtClave.Text = Usuario.Clave;
            }
        }

        private async void btnAceptarEliminar_Click(object? sender, EventArgs e)
        {
            ADO ado = new ADO();
            Usuario usuario = this.ObtenerUsuarioDeForm();
            bool fueEliminado = await ado.Eliminar(usuario ?? throw new ArgumentNullException());
            
            if (fueEliminado) MessageBox.Show("Usuario eliminado");

            else MessageBox.Show("Usuario no eliminado");
        }

        private bool CamposCompletados()
        {
            List<TextBox> textBoxesObligatorios = new List<TextBox>()
            {
                this.txtNombre, this.txtApellido, this.txtDni, this.txtCorreo
            };

            bool todosCompletos = textBoxesObligatorios.All
                ((textbox) => textbox.Text != string.Empty);

            return todosCompletos;
        }

        private Usuario ObtenerUsuarioDeForm()
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            int dni = int.Parse(this.txtDni.Text);
            string correo = this.txtCorreo.Text;
            string clave = this.txtClave.Text;

            return new Usuario(nombre, apellido, dni, correo, clave);
        }

        private void HacerTextBoxesReadonly(TextBox[] textBoxes)
        {
            foreach(TextBox textBox in textBoxes) 
            {
                if (this.Controls.Contains(textBox))
                {
                    textBox.ReadOnly = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
