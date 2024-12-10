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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void TSMIListadoCrud_Click(object sender, EventArgs e)
        {
            FrmListado formListado = new FrmListado();

            formListado.MdiParent = this;

            formListado.Show();
        }

        private void TSMIVerLog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title  = "Abrir archivo de usuarios",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "Archivos de log (*.log)|*log",
                DefaultExt = "log",
                FileName = "usuarios"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string contenido = File.ReadAllText(ofd.FileName);

                    MessageBox.Show(contenido, "Contenido del log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TSMIDeserializarJSON_Click(object sender, EventArgs e)
        {

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "usuarios_repetidos.json");

            if (Manejadora.DeserializarJSON(path, out List<Usuario> usuarios))
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var usuario in usuarios)
                {
                    stringBuilder.AppendLine($"Nombre: {usuario.Nombre} - Apellido: {usuario.Apellido} - DNI: {usuario.Dni} - Correo: {usuario.Correo}");
                }

                FrmJsonLog frmJsonLog = new FrmJsonLog(stringBuilder.ToString());
                frmJsonLog.MdiParent = this;
                frmJsonLog.Show();
            }
            else
            {
                MessageBox.Show("No se pudo deserializar el archivo JSON o está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSMITask_Click(object sender, EventArgs e)
        {
            FrmTodosUsuarios frmTodosUsuarios = new FrmTodosUsuarios();
            frmTodosUsuarios.MdiParent = this; 
            frmTodosUsuarios.Show();
        }

    }
}