using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;
using System.Media;

namespace WinFormsApp
{
    public partial class FormPartido : Form
    {
        private Equipo e1;
        private Equipo e2;
        private int resultado1;
        private int resultado2;
        private CancellationTokenSource cancellationTokenSource;
        private SoundPlayer audio;

        public FormPartido(Equipo e1, Equipo e2)
        {
            this.e1 = e1;
            this.e2 = e2;
            this.resultado1 = 0;
            this.resultado2 = 0;
            this.cancellationTokenSource = new CancellationTokenSource();
            InitializeComponent();
        }
        public void EmpezarPartido()
        {
            //this.audio = new SoundPlayer(Properties.Resources.Silbato_Inicio);
            //audio.Play();
            Task.Run(() => Partido.JugarPartido(this.e1, this.e2, this.cancellationTokenSource.Token));
        }


        public void InformarPartido(int r1, int r2, int minutos)
        {
            if (this.lblMinutos.InvokeRequired)
            {
                InformarPartido del = new InformarPartido(this.InformarPartido);
                object[] args = new object[] { r1, r2, minutos };
                this.lblMinutos.Invoke(del, args);
            }
            else
            {
                this.ModificarMinutos(minutos);
                this.ModificarRelato(r1, r2, minutos);
                this.lblResultado.Text = String.Format("{0} {1} - {2} {3}", e1.Nombre, r1, r2, e2.Nombre);
                if (minutos == 90)
                {
                    this.FinDePartido(r1, r2);
                }
            }
        }

        private void FormPartido_Load(object sender, EventArgs e)
        {
            Partido.eventoPartido += this.InformarPartido;
            this.LimpiarTextos();
            this.EmpezarPartido();
        }

        private void FormPartido_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cancellationTokenSource.Cancel();
            Partido.eventoPartido -= this.InformarPartido;
        }

        public void LimpiarTextos()
        {
            this.lblRelato.Text = String.Empty;
            this.lblMinutos.Text = String.Empty;
            this.lblResultado.Text = String.Empty;
            this.lblFinal.Text = String.Empty;
        }

        public void ModificarMinutos(int minutos)
        {
            if (minutos < 45)
            {
                this.lblMinutos.Text = minutos.ToString() + "° PT";
            }
            else if (minutos == 45)
            {
                this.lblMinutos.Text = "Entretiempo";
            }
            else
            {
                this.lblMinutos.Text = minutos.ToString() + "° ST";
            }
        }

        public void ModificarRelato(int r1, int r2, int minutos)
        {
            if (r1 != this.resultado1)
            {
                this.resultado1 = r1;
                this.lblRelato.Text += String.Format("Gol de {0} minuto {1}° \n", e1.Nombre, minutos);
            }
            else if (r2 != this.resultado2)
            {
                this.resultado2 = r2;
                this.lblRelato.Text += String.Format("Gol de {0} minuto {1}° \n", e2.Nombre, minutos);
            }
        }

        public void FinDePartido(int r1, int r2)
        {
            if (r1 > r2)
            {
                this.lblFinal.Text = "El ganador es " + e1.Nombre;
            }
            else if (r2 > r1)
            {
                this.lblFinal.Text = "El ganador es " + e2.Nombre;
            }
            else
            {
                this.lblFinal.Text = "Hubo un empate";
            }

            //this.audio = new SoundPlayer(Properties.Resources.Silbato_Final);
            //this.audio.Play();
        }
    }
}
