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
using TP_PAVI_Modulo2.Interfaces;
using TP_PAVI_Modulo2.LogicaNegocio;

namespace TP_PAVI_Modulo2
{
    public partial class Login : Form
    {
        private readonly UsuarioService usuarioService;
        public string UsuarioLogueado { get; internal set; }
        public Login()
        {
            InitializeComponent();
            usuarioService = new UsuarioService();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario.
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validamos que se haya ingresado una password
            if ((txtPassword.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var usr = usuarioService.ValidarUsuario(txtUsuario.Text, txtPassword.Text);
            //Controlamos que las creadenciales sean las correctas. 
            if (usr != null)
            {
                // Login OK
                UsuarioLogueado = usr.nombreUsuario;
                FrmPrincipal main = new FrmPrincipal();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                //Limpiamos el campo password, para que el usuario intente ingresar un usuario distinto.
                txtPassword.Text = "";
                // Enfocamos el cursor en el campo password para que el usuario complete sus datos.
                txtPassword.Focus();
                //Mostramos un mensaje indicando que el usuario/password es invalido.
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
