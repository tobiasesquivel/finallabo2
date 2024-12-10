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
    public partial class FrmTodosUsuarios : Form
    {
        private CancellationTokenSource? _cancellationTokenSource;

        public FrmTodosUsuarios()
        {
            InitializeComponent();
        }

        private void FrmTodosUsuarios_Load(object sender, EventArgs e)
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => RefrescarListaUsuarios(_cancellationTokenSource.Token));
        }

        private async Task RefrescarListaUsuarios(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    List<Usuario> usuarios = await ADO.ObtenerTodos();

                    Invoke(new Action(() =>
                    {
                        lstUsuarios.Items.Clear();
                        foreach (Usuario usuario in usuarios)
                        {
                            lstUsuarios.Items.Add(
                                $"Nombre: {usuario.Nombre} - Apellido: {usuario.Apellido} - DNI: {usuario.Dni} - Correo: {usuario.Correo}"
                            );
                        }
                    }));

                    AlternarColores();

                    await Task.Delay(1500, token);
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AlternarColores()
        {
            Invoke(new Action(() =>
            {
                if (lstUsuarios.BackColor == Color.Black)
                {
                    lstUsuarios.BackColor = Color.White;
                    lstUsuarios.ForeColor = Color.Black;
                }
                else
                {
                    lstUsuarios.BackColor = Color.Black;
                    lstUsuarios.ForeColor = Color.White;
                }
            }));
        }

        private void FrmTodosUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }
    }
}
