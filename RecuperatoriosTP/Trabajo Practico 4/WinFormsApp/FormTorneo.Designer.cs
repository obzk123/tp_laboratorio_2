
namespace WinFormsApp
{
    partial class FormTorneo
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
            this.lblTorneo = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblFechasMaximas = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.lblMaximoEquipos = new System.Windows.Forms.Label();
            this.txtBoxFechas = new System.Windows.Forms.TextBox();
            this.txtBoxEquipos = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTorneo
            // 
            this.lblTorneo.AutoSize = true;
            this.lblTorneo.Location = new System.Drawing.Point(13, 13);
            this.lblTorneo.Name = "lblTorneo";
            this.lblTorneo.Size = new System.Drawing.Size(108, 15);
            this.lblTorneo.TabIndex = 0;
            this.lblTorneo.Text = "Nombre del torneo";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(13, 32);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(162, 23);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // lblFechasMaximas
            // 
            this.lblFechasMaximas.AutoSize = true;
            this.lblFechasMaximas.Location = new System.Drawing.Point(13, 62);
            this.lblFechasMaximas.Name = "lblFechasMaximas";
            this.lblFechasMaximas.Size = new System.Drawing.Size(108, 15);
            this.lblFechasMaximas.TabIndex = 2;
            this.lblFechasMaximas.Text = "Cantidad de fechas";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Location = new System.Drawing.Point(12, 159);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(73, 15);
            this.lblFechaActual.TabIndex = 3;
            this.lblFechaActual.Text = "Fecha actual";
            // 
            // lblMaximoEquipos
            // 
            this.lblMaximoEquipos.AutoSize = true;
            this.lblMaximoEquipos.Location = new System.Drawing.Point(13, 106);
            this.lblMaximoEquipos.Name = "lblMaximoEquipos";
            this.lblMaximoEquipos.Size = new System.Drawing.Size(162, 15);
            this.lblMaximoEquipos.TabIndex = 4;
            this.lblMaximoEquipos.Text = "Cantidad maxima de equipos";
            // 
            // txtBoxFechas
            // 
            this.txtBoxFechas.Location = new System.Drawing.Point(13, 80);
            this.txtBoxFechas.Name = "txtBoxFechas";
            this.txtBoxFechas.Size = new System.Drawing.Size(162, 23);
            this.txtBoxFechas.TabIndex = 5;
            // 
            // txtBoxEquipos
            // 
            this.txtBoxEquipos.Location = new System.Drawing.Point(13, 124);
            this.txtBoxEquipos.Name = "txtBoxEquipos";
            this.txtBoxEquipos.Size = new System.Drawing.Size(162, 23);
            this.txtBoxEquipos.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(13, 186);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(100, 186);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 223);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtBoxEquipos);
            this.Controls.Add(this.txtBoxFechas);
            this.Controls.Add(this.lblMaximoEquipos);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.lblFechasMaximas);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblTorneo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Torneo";
            this.Load += new System.EventHandler(this.FormTorneo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTorneo;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblFechasMaximas;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label lblMaximoEquipos;
        private System.Windows.Forms.TextBox txtBoxFechas;
        private System.Windows.Forms.TextBox txtBoxEquipos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnVolver;
    }
}