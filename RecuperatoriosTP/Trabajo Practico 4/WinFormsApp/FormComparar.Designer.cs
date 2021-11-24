
namespace WinFormsApp
{
    partial class FormComparar
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
            this.lblNameE1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblMensajeComparativo = new System.Windows.Forms.Label();
            this.lblNameE2 = new System.Windows.Forms.Label();
            this.richTxt1 = new System.Windows.Forms.RichTextBox();
            this.richTxt2 = new System.Windows.Forms.RichTextBox();
            this.btnJugarPartido = new System.Windows.Forms.Button();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameE1
            // 
            this.lblNameE1.AutoSize = true;
            this.lblNameE1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameE1.Location = new System.Drawing.Point(13, 19);
            this.lblNameE1.Name = "lblNameE1";
            this.lblNameE1.Size = new System.Drawing.Size(131, 21);
            this.lblNameE1.TabIndex = 0;
            this.lblNameE1.Text = "Nombre equipo";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(459, 257);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(95, 29);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblMensajeComparativo
            // 
            this.lblMensajeComparativo.AutoSize = true;
            this.lblMensajeComparativo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeComparativo.Location = new System.Drawing.Point(13, 264);
            this.lblMensajeComparativo.Name = "lblMensajeComparativo";
            this.lblMensajeComparativo.Size = new System.Drawing.Size(206, 20);
            this.lblMensajeComparativo.TabIndex = 13;
            this.lblMensajeComparativo.Text = "Equipo A mejor que Equipo B";
            // 
            // lblNameE2
            // 
            this.lblNameE2.AutoSize = true;
            this.lblNameE2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameE2.Location = new System.Drawing.Point(292, 19);
            this.lblNameE2.Name = "lblNameE2";
            this.lblNameE2.Size = new System.Drawing.Size(131, 21);
            this.lblNameE2.TabIndex = 14;
            this.lblNameE2.Text = "Nombre equipo";
            // 
            // richTxt1
            // 
            this.richTxt1.Location = new System.Drawing.Point(13, 43);
            this.richTxt1.Name = "richTxt1";
            this.richTxt1.ReadOnly = true;
            this.richTxt1.Size = new System.Drawing.Size(256, 172);
            this.richTxt1.TabIndex = 27;
            this.richTxt1.Text = "";
            // 
            // richTxt2
            // 
            this.richTxt2.Location = new System.Drawing.Point(292, 43);
            this.richTxt2.Name = "richTxt2";
            this.richTxt2.ReadOnly = true;
            this.richTxt2.Size = new System.Drawing.Size(256, 172);
            this.richTxt2.TabIndex = 28;
            this.richTxt2.Text = "";
            // 
            // btnJugarPartido
            // 
            this.btnJugarPartido.Location = new System.Drawing.Point(322, 256);
            this.btnJugarPartido.Name = "btnJugarPartido";
            this.btnJugarPartido.Size = new System.Drawing.Size(131, 30);
            this.btnJugarPartido.TabIndex = 29;
            this.btnJugarPartido.Text = "Jugar un partido";
            this.btnJugarPartido.UseVisualStyleBackColor = true;
            this.btnJugarPartido.Click += new System.EventHandler(this.btnJugarPartido_Click);
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Location = new System.Drawing.Point(13, 222);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(66, 30);
            this.lblDiferencia.TabIndex = 30;
            this.lblDiferencia.Text = "sadasd\r\nsasdasdasd\r\n";
            // 
            // FormComparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 293);
            this.Controls.Add(this.lblDiferencia);
            this.Controls.Add(this.btnJugarPartido);
            this.Controls.Add(this.richTxt2);
            this.Controls.Add(this.richTxt1);
            this.Controls.Add(this.lblNameE2);
            this.Controls.Add(this.lblMensajeComparativo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblNameE1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormComparar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparacion equipos";
            this.Load += new System.EventHandler(this.FormComparar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameE1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblMensajeComparativo;
        private System.Windows.Forms.Label lblNameE2;
        private System.Windows.Forms.RichTextBox richTxt1;
        private System.Windows.Forms.RichTextBox richTxt2;
        private System.Windows.Forms.Button btnJugarPartido;
        private System.Windows.Forms.Label lblDiferencia;
    }
}