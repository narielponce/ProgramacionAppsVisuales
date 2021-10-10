using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAVI_Modulo2.LogicaNegocio;

namespace TP_PAVI_Modulo2.Interfaces
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios usu = new FrmUsuarios();
            usu.ShowDialog();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("¿Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.No)
                e.Cancel = true;
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            FrmCursos cur = new FrmCursos();
            cur.ShowDialog();
        }
    }
}
