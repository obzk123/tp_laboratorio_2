using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace WinFormsApp
{
    public partial class frmAvanzarFechas : Form
    {
        CancellationTokenSource tokenSource;
        Torneo torneo;
        FormPrincipal frmPrincipal;
        bool isRunning;
        int fechaLlegar;

        public frmAvanzarFechas(Torneo torneo, FormPrincipal frmPrincipal)
        {
            this.tokenSource = new CancellationTokenSource();
            this.torneo = torneo;
            this.frmPrincipal = frmPrincipal;
            this.torneo.eventoInformar += this.informar;
            this.isRunning = false;
            InitializeComponent();
        }

        public void informar(int fecha)
        {
            if (this.InvokeRequired)
            {
                InformarDelegado del = new InformarDelegado(this.informar);
                object[] args = new object[] { fecha };
                this.Invoke(del, args);
            }
            else
            {
                this.lblFechaActual.Text = "Fecha actual: " + this.torneo.FechaActual.ToString();
                this.progressBar1.Value = fecha;
                this.frmPrincipal.ActualizarForm();
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {

            if (this.isRunning)
            {
                this.tokenSource.Cancel();
                this.btnDetener.Text = "Continuar";
                this.isRunning = false;
                //this.ControlBox = true;
            }
            else
            {
                this.tokenSource = new CancellationTokenSource();
                this.AvanzarFechas();
                this.btnDetener.Text = "Detener";
                this.isRunning = true;
                //this.ControlBox = false;
            }
            
        }

        private void frmAvanzarFechas_Load(object sender, EventArgs e)
        {
            this.progressBar1.Minimum = 0;
            this.btnDetener.Enabled = false;
            this.btnDetener.Text = "Empezar";
            this.lblFechaActual.Text = "Fecha actual: " + this.torneo.FechaActual.ToString();
            this.lblFechaLlegar.Text = "Fecha maxima: " + this.torneo.CantidadDeFechas.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.torneo.eventoInformar -= this.informar;
            this.Close();
        }

        private void AvanzarFechas()
        {
            if (this.fechaLlegar > this.torneo.FechaActual && this.fechaLlegar <= this.torneo.CantidadDeFechas)
            {
                Task task = new Task(() => this.torneo.AvanzarHasta(this.fechaLlegar, tokenSource.Token));
                task.Start();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(this.txtBoxFecha.Text.ToString(), out this.fechaLlegar)
                && this.fechaLlegar > this.torneo.FechaActual && this.fechaLlegar <= this.torneo.CantidadDeFechas)
            {
                this.btnDetener.Enabled = true;
                this.progressBar1.Maximum = this.fechaLlegar;
                this.btnConfirmar.Enabled = false;
                this.txtBoxFecha.Enabled = false;
                this.lblFechaLlegar.Text = "Fecha a llegar: " + this.fechaLlegar.ToString();
            }
        }

        private void frmAvanzarFechas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.tokenSource.Cancel();
            this.torneo.eventoInformar -= this.informar;
        }
    }
}
