using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWarNaves.ControleAcesso
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnControle_Click(object sender, EventArgs e)
        {

        }

        private void btnSicronizar_Click(object sender, EventArgs e)
        {
           // var sincronizador = new SincronizadorService();

            Cursor = Cursors.WaitCursor;
           // await sincronizador.Sincronizar();
            Cursor = Cursors.Default;

            MessageBox.Show("Sincronização finalizada com sucesso", "Sincronização", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
