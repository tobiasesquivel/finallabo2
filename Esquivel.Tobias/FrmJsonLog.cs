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
    public partial class FrmJsonLog : Form
    {

        private string usuariosJson;

        public FrmJsonLog(string usuariosJson)
        {
            InitializeComponent();
            this.usuariosJson = usuariosJson;
        }

        public string UsuariosJson { get => usuariosJson; set => usuariosJson=value; }

        private void FrmJsonLog_Load(object sender, EventArgs e)
        {
            this.txtUsuariosLog.Text = this.usuariosJson;
        }
    }
}
