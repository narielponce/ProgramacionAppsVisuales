
namespace TP_PAVI_Modulo2.Interfaces
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnObjetivos = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitleMain = new System.Windows.Forms.Label();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnObjetivos);
            this.panel1.Controls.Add(this.btnCategorias);
            this.panel1.Controls.Add(this.btnCursos);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 54);
            this.panel1.TabIndex = 5;
            // 
            // btnObjetivos
            // 
            this.btnObjetivos.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnObjetivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObjetivos.Location = new System.Drawing.Point(349, 12);
            this.btnObjetivos.Name = "btnObjetivos";
            this.btnObjetivos.Size = new System.Drawing.Size(107, 31);
            this.btnObjetivos.TabIndex = 9;
            this.btnObjetivos.Text = "Objetivos";
            this.btnObjetivos.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Location = new System.Drawing.Point(236, 12);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(107, 31);
            this.btnCategorias.TabIndex = 8;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // btnCursos
            // 
            this.btnCursos.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Location = new System.Drawing.Point(123, 12);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(107, 31);
            this.btnCursos.TabIndex = 7;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = true;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Location = new System.Drawing.Point(12, 12);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(105, 31);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitleMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 100);
            this.panel2.TabIndex = 6;
            // 
            // lblTitleMain
            // 
            this.lblTitleMain.AutoSize = true;
            this.lblTitleMain.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleMain.Location = new System.Drawing.Point(12, 50);
            this.lblTitleMain.Name = "lblTitleMain";
            this.lblTitleMain.Size = new System.Drawing.Size(414, 41);
            this.lblTitleMain.TabIndex = 0;
            this.lblTitleMain.Text = "Gestion de cursos por usuario";
            // 
            // pbUsers
            // 
            this.pbUsers.Image = ((System.Drawing.Image)(resources.GetObject("pbUsers.Image")));
            this.pbUsers.Location = new System.Drawing.Point(551, 205);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(128, 128);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUsers.TabIndex = 0;
            this.pbUsers.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1246, 531);
            this.Controls.Add(this.pbUsers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnObjetivos;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitleMain;
        private System.Windows.Forms.PictureBox pbUsers;
    }
}