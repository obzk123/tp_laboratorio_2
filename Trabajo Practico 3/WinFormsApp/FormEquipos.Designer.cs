
namespace WinFormsApp
{
    partial class FormEquipos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGanados = new System.Windows.Forms.Label();
            this.lblEmpatados = new System.Windows.Forms.Label();
            this.lblPerdidos = new System.Windows.Forms.Label();
            this.lblGolesAFavor = new System.Windows.Forms.Label();
            this.lblGolesEnContra = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxGanados = new System.Windows.Forms.TextBox();
            this.txtBoxEmpatados = new System.Windows.Forms.TextBox();
            this.txtBoxPerdidos = new System.Windows.Forms.TextBox();
            this.txtBoxGolesEnContra = new System.Windows.Forms.TextBox();
            this.txtBoxGolesAFavor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(16, 14);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblGanados
            // 
            this.lblGanados.AutoSize = true;
            this.lblGanados.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGanados.Location = new System.Drawing.Point(16, 68);
            this.lblGanados.Name = "lblGanados";
            this.lblGanados.Size = new System.Drawing.Size(157, 25);
            this.lblGanados.TabIndex = 2;
            this.lblGanados.Text = "Partidos ganados";
            // 
            // lblEmpatados
            // 
            this.lblEmpatados.AutoSize = true;
            this.lblEmpatados.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmpatados.Location = new System.Drawing.Point(16, 123);
            this.lblEmpatados.Name = "lblEmpatados";
            this.lblEmpatados.Size = new System.Drawing.Size(178, 25);
            this.lblEmpatados.TabIndex = 3;
            this.lblEmpatados.Text = "Partidos empatados";
            // 
            // lblPerdidos
            // 
            this.lblPerdidos.AutoSize = true;
            this.lblPerdidos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPerdidos.Location = new System.Drawing.Point(16, 177);
            this.lblPerdidos.Name = "lblPerdidos";
            this.lblPerdidos.Size = new System.Drawing.Size(159, 25);
            this.lblPerdidos.TabIndex = 4;
            this.lblPerdidos.Text = "Partidos perdidos";
            // 
            // lblGolesAFavor
            // 
            this.lblGolesAFavor.AutoSize = true;
            this.lblGolesAFavor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGolesAFavor.Location = new System.Drawing.Point(16, 287);
            this.lblGolesAFavor.Name = "lblGolesAFavor";
            this.lblGolesAFavor.Size = new System.Drawing.Size(122, 25);
            this.lblGolesAFavor.TabIndex = 5;
            this.lblGolesAFavor.Text = "Goles a favor";
            // 
            // lblGolesEnContra
            // 
            this.lblGolesEnContra.AutoSize = true;
            this.lblGolesEnContra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGolesEnContra.Location = new System.Drawing.Point(16, 232);
            this.lblGolesEnContra.Name = "lblGolesEnContra";
            this.lblGolesEnContra.Size = new System.Drawing.Size(144, 25);
            this.lblGolesEnContra.TabIndex = 6;
            this.lblGolesEnContra.Text = "Goles en contra";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(16, 42);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(178, 23);
            this.txtBoxNombre.TabIndex = 7;
            // 
            // txtBoxGanados
            // 
            this.txtBoxGanados.Location = new System.Drawing.Point(16, 97);
            this.txtBoxGanados.Name = "txtBoxGanados";
            this.txtBoxGanados.Size = new System.Drawing.Size(178, 23);
            this.txtBoxGanados.TabIndex = 9;
            // 
            // txtBoxEmpatados
            // 
            this.txtBoxEmpatados.Location = new System.Drawing.Point(16, 151);
            this.txtBoxEmpatados.Name = "txtBoxEmpatados";
            this.txtBoxEmpatados.Size = new System.Drawing.Size(179, 23);
            this.txtBoxEmpatados.TabIndex = 10;
            // 
            // txtBoxPerdidos
            // 
            this.txtBoxPerdidos.Location = new System.Drawing.Point(16, 206);
            this.txtBoxPerdidos.Name = "txtBoxPerdidos";
            this.txtBoxPerdidos.Size = new System.Drawing.Size(179, 23);
            this.txtBoxPerdidos.TabIndex = 11;
            // 
            // txtBoxGolesEnContra
            // 
            this.txtBoxGolesEnContra.Location = new System.Drawing.Point(16, 261);
            this.txtBoxGolesEnContra.Name = "txtBoxGolesEnContra";
            this.txtBoxGolesEnContra.Size = new System.Drawing.Size(179, 23);
            this.txtBoxGolesEnContra.TabIndex = 12;
            // 
            // txtBoxGolesAFavor
            // 
            this.txtBoxGolesAFavor.Location = new System.Drawing.Point(16, 316);
            this.txtBoxGolesAFavor.Name = "txtBoxGolesAFavor";
            this.txtBoxGolesAFavor.Size = new System.Drawing.Size(179, 23);
            this.txtBoxGolesAFavor.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(230, 198);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 36);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(230, 240);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 36);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(230, 303);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 36);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 357);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBoxGolesAFavor);
            this.Controls.Add(this.txtBoxGolesEnContra);
            this.Controls.Add(this.txtBoxPerdidos);
            this.Controls.Add(this.txtBoxEmpatados);
            this.Controls.Add(this.txtBoxGanados);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblGolesEnContra);
            this.Controls.Add(this.lblGolesAFavor);
            this.Controls.Add(this.lblPerdidos);
            this.Controls.Add(this.lblEmpatados);
            this.Controls.Add(this.lblGanados);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEquipos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEquipos_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblGanados;
        private System.Windows.Forms.Label lblEmpatados;
        private System.Windows.Forms.Label lblPerdidos;
        private System.Windows.Forms.Label lblGolesAFavor;
        private System.Windows.Forms.Label lblGolesEnContra;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxGanados;
        private System.Windows.Forms.TextBox txtBoxEmpatados;
        private System.Windows.Forms.TextBox txtBoxPerdidos;
        private System.Windows.Forms.TextBox txtBoxGolesEnContra;
        private System.Windows.Forms.TextBox txtBoxGolesAFavor;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnModificar;
    }
}