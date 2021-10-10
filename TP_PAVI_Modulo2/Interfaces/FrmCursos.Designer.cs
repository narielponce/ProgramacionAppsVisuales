
namespace TP_PAVI_Modulo2.Interfaces
{
    partial class FrmCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitleCurso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlListado = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.lblTitleListUser = new System.Windows.Forms.Label();
            this.pnlAltaMod = new System.Windows.Forms.Panel();
            this.cboCateg = new System.Windows.Forms.ComboBox();
            this.dtpFechaVig = new System.Windows.Forms.DateTimePicker();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.lblCursoName = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.lblCursoCateg = new System.Windows.Forms.Label();
            this.lblFechaVig = new System.Windows.Forms.Label();
            this.lblCursoDesc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFiltro1 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.pnlAltaMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleCurso
            // 
            this.lblTitleCurso.AutoSize = true;
            this.lblTitleCurso.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleCurso.Location = new System.Drawing.Point(311, 9);
            this.lblTitleCurso.Name = "lblTitleCurso";
            this.lblTitleCurso.Size = new System.Drawing.Size(166, 28);
            this.lblTitleCurso.TabIndex = 0;
            this.lblTitleCurso.Text = "Gestión de cursos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitleCurso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 51);
            this.panel1.TabIndex = 1;
            // 
            // pnlListado
            // 
            this.pnlListado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListado.Controls.Add(this.btnBuscar);
            this.pnlListado.Controls.Add(this.textBox1);
            this.pnlListado.Controls.Add(this.lblBuscar);
            this.pnlListado.Controls.Add(this.lblFiltro1);
            this.pnlListado.Controls.Add(this.comboBox1);
            this.pnlListado.Controls.Add(this.btnEliminar);
            this.pnlListado.Controls.Add(this.btnModificar);
            this.pnlListado.Controls.Add(this.btnAgregar);
            this.pnlListado.Controls.Add(this.dgvCursos);
            this.pnlListado.Controls.Add(this.lblTitleListUser);
            this.pnlListado.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlListado.Location = new System.Drawing.Point(0, 51);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.Size = new System.Drawing.Size(567, 399);
            this.pnlListado.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(439, 336);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 35);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(311, 337);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 36);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(12, 336);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCursos.Location = new System.Drawing.Point(12, 100);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.RowTemplate.Height = 25;
            this.dgvCursos.Size = new System.Drawing.Size(537, 226);
            this.dgvCursos.TabIndex = 2;
            // 
            // lblTitleListUser
            // 
            this.lblTitleListUser.AutoSize = true;
            this.lblTitleListUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleListUser.Location = new System.Drawing.Point(12, 76);
            this.lblTitleListUser.Name = "lblTitleListUser";
            this.lblTitleListUser.Size = new System.Drawing.Size(130, 21);
            this.lblTitleListUser.TabIndex = 1;
            this.lblTitleListUser.Text = "Listado de cursos";
            // 
            // pnlAltaMod
            // 
            this.pnlAltaMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAltaMod.Controls.Add(this.cboCateg);
            this.pnlAltaMod.Controls.Add(this.dtpFechaVig);
            this.pnlAltaMod.Controls.Add(this.txtNombreCurso);
            this.pnlAltaMod.Controls.Add(this.lblCursoName);
            this.pnlAltaMod.Controls.Add(this.btnCancelar);
            this.pnlAltaMod.Controls.Add(this.btnAceptar);
            this.pnlAltaMod.Controls.Add(this.txtPuntuacion);
            this.pnlAltaMod.Controls.Add(this.lblCursoCateg);
            this.pnlAltaMod.Controls.Add(this.lblFechaVig);
            this.pnlAltaMod.Controls.Add(this.lblCursoDesc);
            this.pnlAltaMod.Controls.Add(this.label2);
            this.pnlAltaMod.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAltaMod.Location = new System.Drawing.Point(573, 51);
            this.pnlAltaMod.Name = "pnlAltaMod";
            this.pnlAltaMod.Size = new System.Drawing.Size(353, 399);
            this.pnlAltaMod.TabIndex = 3;
            // 
            // cboCateg
            // 
            this.cboCateg.FormattingEnabled = true;
            this.cboCateg.Location = new System.Drawing.Point(110, 236);
            this.cboCateg.Name = "cboCateg";
            this.cboCateg.Size = new System.Drawing.Size(217, 23);
            this.cboCateg.TabIndex = 18;
            // 
            // dtpFechaVig
            // 
            this.dtpFechaVig.Location = new System.Drawing.Point(110, 191);
            this.dtpFechaVig.Name = "dtpFechaVig";
            this.dtpFechaVig.Size = new System.Drawing.Size(217, 23);
            this.dtpFechaVig.TabIndex = 17;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(110, 91);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(217, 23);
            this.txtNombreCurso.TabIndex = 16;
            // 
            // lblCursoName
            // 
            this.lblCursoName.AutoSize = true;
            this.lblCursoName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCursoName.Location = new System.Drawing.Point(3, 95);
            this.lblCursoName.Name = "lblCursoName";
            this.lblCursoName.Size = new System.Drawing.Size(59, 19);
            this.lblCursoName.TabIndex = 15;
            this.lblCursoName.Text = "Nombre";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(221, 336);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 34);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(110, 336);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 34);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Location = new System.Drawing.Point(110, 142);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(217, 23);
            this.txtPuntuacion.TabIndex = 10;
            // 
            // lblCursoCateg
            // 
            this.lblCursoCateg.AutoSize = true;
            this.lblCursoCateg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCursoCateg.Location = new System.Drawing.Point(3, 240);
            this.lblCursoCateg.Name = "lblCursoCateg";
            this.lblCursoCateg.Size = new System.Drawing.Size(68, 19);
            this.lblCursoCateg.TabIndex = 9;
            this.lblCursoCateg.Text = "Categoría";
            // 
            // lblFechaVig
            // 
            this.lblFechaVig.AutoSize = true;
            this.lblFechaVig.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaVig.Location = new System.Drawing.Point(3, 196);
            this.lblFechaVig.Name = "lblFechaVig";
            this.lblFechaVig.Size = new System.Drawing.Size(97, 19);
            this.lblFechaVig.TabIndex = 8;
            this.lblFechaVig.Text = "Fecha vigencia";
            // 
            // lblCursoDesc
            // 
            this.lblCursoDesc.AutoSize = true;
            this.lblCursoDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCursoDesc.Location = new System.Drawing.Point(3, 146);
            this.lblCursoDesc.Name = "lblCursoDesc";
            this.lblCursoDesc.Size = new System.Drawing.Size(79, 19);
            this.lblCursoDesc.TabIndex = 6;
            this.lblCursoDesc.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(132, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alta - Modificacion ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // lblFiltro1
            // 
            this.lblFiltro1.AutoSize = true;
            this.lblFiltro1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiltro1.Location = new System.Drawing.Point(23, 9);
            this.lblFiltro1.Name = "lblFiltro1";
            this.lblFiltro1.Size = new System.Drawing.Size(65, 17);
            this.lblFiltro1.TabIndex = 7;
            this.lblFiltro1.Text = "Categoría";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.Location = new System.Drawing.Point(23, 37);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(46, 17);
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.Click += new System.EventHandler(this.lblBuscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(386, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(163, 37);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.pnlAltaMod);
            this.Controls.Add(this.pnlListado);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlListado.ResumeLayout(false);
            this.pnlListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.pnlAltaMod.ResumeLayout(false);
            this.pnlAltaMod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitleCurso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlListado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTitleListUser;
        private System.Windows.Forms.Panel pnlAltaMod;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.Label lblCursoCateg;
        private System.Windows.Forms.Label lblFechaVig;
        private System.Windows.Forms.Label lblCursoDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label lblCursoName;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.ComboBox cboCateg;
        private System.Windows.Forms.DateTimePicker dtpFechaVig;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblFiltro1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}