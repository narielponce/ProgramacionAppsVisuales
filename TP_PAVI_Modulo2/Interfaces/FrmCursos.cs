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
    public partial class FrmCursos : Form
    {
        private FormMode formMode = FormMode.nuevo;
        private CursoService oCursoService;
        public FrmCursos()
        {
            InitializeComponent();
            oCursoService = new CursoService();
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
            //txtPuntuacion.Enabled = false;
            //txtObservaciones.Enabled = false;
            //txtFechaInicio.Enabled = false;
            //txtFechaFin.Enabled = false;
        }

        private void HabilitarFormulario()
        {
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            //txtPuntuacion.Enabled = true;
            //txtObservaciones.Enabled = true;
            //txtFechaInicio.Enabled = true;
            //txtFechaFin.Enabled = true;
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
            dgvCursos.ColumnCount = 4;
            dgvCursos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dgvCursos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvCursos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource

            dgvCursos.Columns[0].Name = "Nombre";
            dgvCursos.Columns[0].DataPropertyName = "nombre";
            dgvCursos.Columns[0].Width = 100;

            dgvCursos.Columns[1].Name = "Descripción";
            dgvCursos.Columns[1].DataPropertyName = "descripcion";
            dgvCursos.Columns[1].Width = 150;

            dgvCursos.Columns[2].Name = "Fecha vigencia";
            dgvCursos.Columns[2].DataPropertyName = "fechaVigencia";
            dgvCursos.Columns[2].Width = 120;

            dgvCursos.Columns[3].Name = "Categoría";
            dgvCursos.Columns[3].DataPropertyName = "categoria";
            dgvCursos.Columns[3].Width = 100;

            // Cambia el tamaño de la altura de los encabezados de columna.
            dgvCursos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dgvCursos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            dgvCursos.DataSource = oCursoService.ObtenerTodos();
        }
        private bool ValidarCampos()
        {
            // campos obligatorios
            if (txtNombreCurso.Text == string.Empty)
            {
                txtNombreCurso.BackColor = Color.Red;
                txtNombreCurso.Focus();
                return false;
            }
            else
                txtNombreCurso.BackColor = Color.White;

            return true;
        }

        //private bool ExisteUsuario()
        //{
        //    return oCursoService.ObtenerUsuario(txtNombreCurso.Text) != null;
        //}

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
