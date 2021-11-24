
namespace WinFormsApp
{
    partial class frmAvanzarFechas
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.lblFechaLlegar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFecha = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 80);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(275, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(12, 106);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(81, 31);
            this.btnDetener.TabIndex = 1;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(206, 106);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(81, 31);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaActual.Location = new System.Drawing.Point(12, 56);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(120, 21);
            this.lblFechaActual.TabIndex = 3;
            this.lblFechaActual.Text = "Fecha actual: 20";
            // 
            // lblFechaLlegar
            // 
            this.lblFechaLlegar.AutoSize = true;
            this.lblFechaLlegar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaLlegar.Location = new System.Drawing.Point(153, 56);
            this.lblFechaLlegar.Name = "lblFechaLlegar";
            this.lblFechaLlegar.Size = new System.Drawing.Size(134, 21);
            this.lblFechaLlegar.TabIndex = 4;
            this.lblFechaLlegar.Text = "Fecha maxima: 20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha a llegar: ";
            // 
            // txtBoxFecha
            // 
            this.txtBoxFecha.Location = new System.Drawing.Point(119, 15);
            this.txtBoxFecha.Name = "txtBoxFecha";
            this.txtBoxFecha.Size = new System.Drawing.Size(83, 23);
            this.txtBoxFecha.TabIndex = 6;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(208, 16);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(79, 23);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmAvanzarFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 146);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtBoxFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaLlegar);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAvanzarFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avanzar Fechas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAvanzarFechas_FormClosing);
           
            this.Load += new System.EventHandler(this.frmAvanzarFechas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Label lblFechaLlegar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFecha;
        private System.Windows.Forms.Button btnConfirmar;
    }
}