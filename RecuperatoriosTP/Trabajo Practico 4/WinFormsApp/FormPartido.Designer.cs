
namespace WinFormsApp
{
    partial class FormPartido
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
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblRelato = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMinutos
            // 
            this.lblMinutos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblMinutos.Location = new System.Drawing.Point(12, 9);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(81, 15);
            this.lblMinutos.TabIndex = 1;
            this.lblMinutos.Text = "90° ST";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(0, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(316, 46);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "San Lorenzo 3 -  3 Estudiantes";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRelato
            // 
            this.lblRelato.AutoSize = true;
            this.lblRelato.Location = new System.Drawing.Point(12, 55);
            this.lblRelato.Name = "lblRelato";
            this.lblRelato.Size = new System.Drawing.Size(40, 15);
            this.lblRelato.TabIndex = 0;
            this.lblRelato.Text = "Relato";
            // 
            // lblFinal
            // 
            this.lblFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinal.Location = new System.Drawing.Point(0, 149);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFinal.Size = new System.Drawing.Size(316, 21);
            this.lblFinal.TabIndex = 2;
            this.lblFinal.Text = "El ganador es river";
            this.lblFinal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // FormPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 179);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblRelato);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblFinal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPartido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPartido_FormClosing);
            this.Load += new System.EventHandler(this.FormPartido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblRelato;
        private System.Windows.Forms.Label lblFinal;
    }
}