
namespace WinFormsApp
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEquipo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTorneo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAvanzar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComparar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripResetear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripInfoTorneo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAvanzarHasta = new System.Windows.Forms.ToolStripMenuItem();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ganados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empatados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perdidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GolesAFavor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GolesEnContra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiferenciaGoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTorneo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMaximoEquipos = new System.Windows.Forms.Label();
            this.toolStripAbrirBase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGuardarEnBase = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripArchivo,
            this.toolStripEquipo,
            this.toolStripTorneo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripArchivo
            // 
            this.toolStripArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAbrir,
            this.toolStripGuardar,
            this.toolStripGuardarComo,
            this.toolStripAbrirBase,
            this.toolStripGuardarEnBase});
            this.toolStripArchivo.Name = "toolStripArchivo";
            this.toolStripArchivo.Size = new System.Drawing.Size(60, 20);
            this.toolStripArchivo.Text = "Archivo";
            // 
            // toolStripAbrir
            // 
            this.toolStripAbrir.Name = "toolStripAbrir";
            this.toolStripAbrir.Size = new System.Drawing.Size(207, 22);
            this.toolStripAbrir.Text = "Abrir";
            this.toolStripAbrir.Click += new System.EventHandler(this.toolStripAbrir_Click);
            // 
            // toolStripGuardar
            // 
            this.toolStripGuardar.Name = "toolStripGuardar";
            this.toolStripGuardar.Size = new System.Drawing.Size(207, 22);
            this.toolStripGuardar.Text = "Guardar";
            this.toolStripGuardar.Click += new System.EventHandler(this.toolStripGuardar_Click);
            // 
            // toolStripGuardarComo
            // 
            this.toolStripGuardarComo.Name = "toolStripGuardarComo";
            this.toolStripGuardarComo.Size = new System.Drawing.Size(207, 22);
            this.toolStripGuardarComo.Text = "Guardar Como";
            this.toolStripGuardarComo.Click += new System.EventHandler(this.toolStripGuardarComo_Click);
            // 
            // toolStripEquipo
            // 
            this.toolStripEquipo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAgregar,
            this.toolStripEliminar,
            this.toolStripEditar});
            this.toolStripEquipo.Name = "toolStripEquipo";
            this.toolStripEquipo.Size = new System.Drawing.Size(61, 20);
            this.toolStripEquipo.Text = "Equipos";
            // 
            // toolStripAgregar
            // 
            this.toolStripAgregar.Name = "toolStripAgregar";
            this.toolStripAgregar.Size = new System.Drawing.Size(117, 22);
            this.toolStripAgregar.Text = "Agregar";
            this.toolStripAgregar.Click += new System.EventHandler(this.toolStripAgregar_Click);
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(117, 22);
            this.toolStripEliminar.Text = "Eliminar";
            this.toolStripEliminar.Click += new System.EventHandler(this.toolStripEliminar_Click);
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(117, 22);
            this.toolStripEditar.Text = "Editar";
            this.toolStripEditar.Click += new System.EventHandler(this.toolStripEditar_Click);
            // 
            // toolStripTorneo
            // 
            this.toolStripTorneo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAvanzar,
            this.toolStripComparar,
            this.toolStripResetear,
            this.toolStripInfoTorneo,
            this.toolStripAvanzarHasta});
            this.toolStripTorneo.Name = "toolStripTorneo";
            this.toolStripTorneo.Size = new System.Drawing.Size(55, 20);
            this.toolStripTorneo.Text = "Torneo";
            // 
            // toolStripAvanzar
            // 
            this.toolStripAvanzar.Name = "toolStripAvanzar";
            this.toolStripAvanzar.Size = new System.Drawing.Size(157, 22);
            this.toolStripAvanzar.Text = "Avanzar Fecha";
            this.toolStripAvanzar.Click += new System.EventHandler(this.toolStripAvanzar_Click);
            // 
            // toolStripComparar
            // 
            this.toolStripComparar.Name = "toolStripComparar";
            this.toolStripComparar.Size = new System.Drawing.Size(157, 22);
            this.toolStripComparar.Text = "Comparar";
            this.toolStripComparar.Click += new System.EventHandler(this.toolStripComparar_Click);
            // 
            // toolStripResetear
            // 
            this.toolStripResetear.Name = "toolStripResetear";
            this.toolStripResetear.Size = new System.Drawing.Size(157, 22);
            this.toolStripResetear.Text = "Resetear Torneo";
            this.toolStripResetear.Click += new System.EventHandler(this.toolStripResetear_Click);
            // 
            // toolStripInfoTorneo
            // 
            this.toolStripInfoTorneo.Name = "toolStripInfoTorneo";
            this.toolStripInfoTorneo.Size = new System.Drawing.Size(157, 22);
            this.toolStripInfoTorneo.Text = "Info Torneo";
            this.toolStripInfoTorneo.Click += new System.EventHandler(this.toolStripInfoTorneo_Click);
            // 
            // toolStripAvanzarHasta
            // 
            this.toolStripAvanzarHasta.Name = "toolStripAvanzarHasta";
            this.toolStripAvanzarHasta.Size = new System.Drawing.Size(157, 22);
            this.toolStripAvanzarHasta.Text = "Avanzar Hasta";
            this.toolStripAvanzarHasta.Click += new System.EventHandler(this.toolStripAvanzarHasta_Click);
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeColumns = false;
            this.tabla.AllowUserToResizeRows = false;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.PJ,
            this.Ganados,
            this.Empatados,
            this.Perdidos,
            this.GolesAFavor,
            this.GolesEnContra,
            this.DiferenciaGoles,
            this.Puntos});
            this.tabla.Location = new System.Drawing.Point(15, 30);
            this.tabla.Name = "tabla";
            this.tabla.RowTemplate.Height = 25;
            this.tabla.Size = new System.Drawing.Size(464, 511);
            this.tabla.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // PJ
            // 
            this.PJ.HeaderText = "PJ";
            this.PJ.Name = "PJ";
            this.PJ.ReadOnly = true;
            this.PJ.Width = 40;
            // 
            // Ganados
            // 
            this.Ganados.HeaderText = "G";
            this.Ganados.Name = "Ganados";
            this.Ganados.ReadOnly = true;
            this.Ganados.Width = 40;
            // 
            // Empatados
            // 
            this.Empatados.HeaderText = "E";
            this.Empatados.Name = "Empatados";
            this.Empatados.ReadOnly = true;
            this.Empatados.Width = 40;
            // 
            // Perdidos
            // 
            this.Perdidos.HeaderText = "P";
            this.Perdidos.Name = "Perdidos";
            this.Perdidos.ReadOnly = true;
            this.Perdidos.Width = 40;
            // 
            // GolesAFavor
            // 
            this.GolesAFavor.HeaderText = "GF";
            this.GolesAFavor.Name = "GolesAFavor";
            this.GolesAFavor.ReadOnly = true;
            this.GolesAFavor.Width = 40;
            // 
            // GolesEnContra
            // 
            this.GolesEnContra.HeaderText = "GC";
            this.GolesEnContra.Name = "GolesEnContra";
            this.GolesEnContra.ReadOnly = true;
            this.GolesEnContra.Width = 40;
            // 
            // DiferenciaGoles
            // 
            this.DiferenciaGoles.HeaderText = "DG";
            this.DiferenciaGoles.Name = "DiferenciaGoles";
            this.DiferenciaGoles.ReadOnly = true;
            this.DiferenciaGoles.Width = 40;
            // 
            // Puntos
            // 
            this.Puntos.HeaderText = "Pts";
            this.Puntos.Name = "Puntos";
            this.Puntos.ReadOnly = true;
            this.Puntos.Width = 40;
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTorneo.Location = new System.Drawing.Point(15, 569);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(58, 19);
            this.lblTorneo.TabIndex = 7;
            this.lblTorneo.Text = "Torneo: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(15, 544);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(57, 21);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblMaximoEquipos
            // 
            this.lblMaximoEquipos.AutoSize = true;
            this.lblMaximoEquipos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaximoEquipos.Location = new System.Drawing.Point(332, 569);
            this.lblMaximoEquipos.Name = "lblMaximoEquipos";
            this.lblMaximoEquipos.Size = new System.Drawing.Size(136, 19);
            this.lblMaximoEquipos.TabIndex = 9;
            this.lblMaximoEquipos.Text = "Maximo de equipos: ";
            // 
            // toolStripAbrirBase
            // 
            this.toolStripAbrirBase.Name = "toolStripAbrirBase";
            this.toolStripAbrirBase.Size = new System.Drawing.Size(207, 22);
            this.toolStripAbrirBase.Text = "Abrir con Base de datos";
            this.toolStripAbrirBase.Click += new System.EventHandler(this.toolStripAbrirBase_Click);
            // 
            // toolStripGuardarEnBase
            // 
            this.toolStripGuardarEnBase.Name = "toolStripGuardarEnBase";
            this.toolStripGuardarEnBase.Size = new System.Drawing.Size(207, 22);
            this.toolStripGuardarEnBase.Text = "Guardar en base de datos";
            this.toolStripGuardarEnBase.Click += new System.EventHandler(this.toolStripGuardarEnBase_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 597);
            this.Controls.Add(this.lblMaximoEquipos);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTorneo);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torneo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripArchivo;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbrir;
        private System.Windows.Forms.ToolStripMenuItem toolStripGuardar;
        private System.Windows.Forms.ToolStripMenuItem toolStripGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem toolStripEquipo;
        private System.Windows.Forms.ToolStripMenuItem toolStripAgregar;
        private System.Windows.Forms.ToolStripMenuItem toolStripEliminar;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditar;
        private System.Windows.Forms.ToolStripMenuItem toolStripTorneo;
        private System.Windows.Forms.ToolStripMenuItem toolStripAvanzar;
        private System.Windows.Forms.ToolStripMenuItem toolStripComparar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ganados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empatados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perdidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn GolesAFavor;
        private System.Windows.Forms.DataGridViewTextBoxColumn GolesEnContra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiferenciaGoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMaximoEquipos;
        private System.Windows.Forms.ToolStripMenuItem toolStripResetear;
        private System.Windows.Forms.ToolStripMenuItem toolStripInfoTorneo;
        public System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.ToolStripMenuItem toolStripAvanzarHasta;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbrirBase;
        private System.Windows.Forms.ToolStripMenuItem toolStripGuardarEnBase;
    }
}