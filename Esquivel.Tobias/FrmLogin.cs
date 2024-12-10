using Entidades.Final;

namespace Esquivel.Tobias
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string correo = this.txtCorreo.Text;
            string clave = this.txtClave.Text;

            Login login = new Login(correo, clave);

            bool usuarioFueEncontrado = await login.Loguear();
           
            if(usuarioFueEncontrado) 
            {
                FrmPrincipal formPrincipal = new FrmPrincipal();
                this.Hide();
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("No existe usuario con ese correo y contraseña");
            }
        }
    }
}
