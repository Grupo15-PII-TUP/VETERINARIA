
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veterNetFram.Dominio;
using veterNetFram.Presentacion.UsuarioF;

namespace veterNetFram.Presentacion
{
    public partial class frmPrincipal : Form
    {
        public Usuarios uLog{ get; set; }
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            
            lblUsuarioLogueado.Text = "Usuario Logeado:   "+uLog.ToString().ToUpper();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;
        }

      
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmUsuario frmU = new frmUsuario();
            frmU.ShowDialog();
            
        }

        private void animalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
