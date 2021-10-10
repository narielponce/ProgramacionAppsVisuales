using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP_PAVI_Modulo2.LogicaNegocio;
using TP_PAVI_Modulo2.Entidades;

namespace TP_PAVI_Modulo2.Interfaces
{
    public partial class FrmUsuarios : Form
    {
        private FormMode formMode = FormMode.nuevo;
        private UsuarioService oUsuarioService;
        public FrmUsuarios()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            CargarFormulario();
        }

        public enum FormMode
        {
            nuevo,
            eliminar = 99,
            modificar
        }


        private void CargarFormulario()
        {
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            txtPuntuacion.Enabled = false;
            txtObservaciones.Enabled = false;
            txtFechaInicio.Enabled = false;
            txtFechaFin.Enabled = false;
        }

        private void HabilitarFormulario()
        {
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            txtPuntuacion.Enabled = true;
            txtObservaciones.Enabled = true;
            txtFechaInicio.Enabled = true;
            txtFechaFin.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HabilitarFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        { 
            /*{
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (ExisteUsuario() == false)
                        {
                            if (ValidarCampos())
                            {
                                var oUsuario = new UsuarioCurso();
                                oUsuario. = txtNombre.Text;
                                oUsuario.Password = txtPassword.Text;
                                oUsuario.Email = txtEmail.Text;
                                oUsuario.Perfil = new Perfil();
                                oUsuario.Perfil.IdPerfil = (int)cboPerfil.SelectedValue;

                                if (oUsuarioService.CrearUsuario(oUsuario))
                                {
                                    MessageBox.Show("Usuario insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.modificar:
                    {
                        if (ValidarCampos())
                        {
                            oUsuarioSelected.NombreUsuario = txtNombre.Text;
                            oUsuarioSelected.Password = txtPassword.Text;
                            oUsuarioSelected.Email = txtEmail.Text;
                            oUsuarioSelected.Perfil = new Perfil();
                            oUsuarioSelected.Perfil.IdPerfil = (int)cboPerfil.SelectedValue;

                            if (oUsuarioService.ActualizarUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("Usuario actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.eliminar:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oUsuarioService.EliminarUsuario(oUsuarioSelected))
                            {
                                MessageBox.Show("Usuario Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al eliminar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }
            }*/
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CargarFormulario();
            MessageBox.Show("Operacion Cancelada");
        }
        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dgvUsuarios.ColumnCount = 3;
            dgvUsuarios.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvUsuarios.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvUsuarios.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            //dgvUsuarios.Columns[0].Name = "ID";
            //dgvUsuarios.Columns[0].DataPropertyName = "idUsuario";
            // Definimos el ancho de la columna.
            //dgvUsuarios.Columns[0].Width = 50;

            dgvUsuarios.Columns[0].Name = "Nombre";
            dgvUsuarios.Columns[0].DataPropertyName = "nombreUsuario";
            dgvUsuarios.Columns[0].Width = 100;

            dgvUsuarios.Columns[1].Name = "Email";
            dgvUsuarios.Columns[1].DataPropertyName = "email";
            dgvUsuarios.Columns[1].Width = 150;

            dgvUsuarios.Columns[2].Name = "Perfil";
            dgvUsuarios.Columns[2].DataPropertyName = "perfil";
            dgvUsuarios.Columns[2].Width = 100;

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvUsuarios.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvUsuarios.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            dgvUsuarios.DataSource = oUsuarioService.ObtenerTodos();
        }
        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtNombreUsuario.Text == string.Empty)
            {
                txtNombreUsuario.BackColor = Color.Red;
                txtNombreUsuario.Focus();
                return false;
            }
            else
                txtNombreUsuario.BackColor = Color.White;

            return true;
        }

        private bool ExisteUsuario()
        {
            return oUsuarioService.ObtenerUsuario(txtNombreUsuario.Text) != null;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }
    }
}
