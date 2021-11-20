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

namespace WinFormsApp
{
    public partial class FormComparar : Form
    {
        Equipo e1;
        Equipo e2;

        public FormComparar(Equipo e1, Equipo e2)
        {
            this.e1 = e1;
            this.e2 = e2;
            InitializeComponent();
        }

        public void CargarDatosE1()
        {
            float probGanados = 0;
            float probPerdidos = 0;
            float promGolesFavor = 0;
            float promGolesEnContra = 0;

            this.lblNameE1.Text = "Nombre equipo: " + this.e1.Nombre;
            this.lblPartidosJugadosE1.Text = "Partidos jugados: " + this.e1.PartidosJugados;
            this.lblPartidosGanadosE1.Text = "Partidos ganados: " + this.e1.Ganados;
            this.lblPartidosEmpatadosE1.Text = "Partidos empatados: " + this.e1.Empatados;
            this.lblPartidosPerdidosE1.Text = "Partidos perdidos: " + this.e1.Perdidos;
            this.lblGolesAFavorE1.Text = "Goles a favor: " + this.e1.GolesAFavor;
            this.lblGolesEnContraE1.Text = "Goles en contra: " + this.e1.GolesEnContra;
            this.lblDiferenciaE1.Text = "Diferencia de goles: " + this.e1.Diferencia;
            if (this.e1.Ganados > 0)
            {
             
                probGanados = probGanados.MiPromedio((float)this.e1.Ganados, (float)this.e1.PartidosJugados, 100);
                this.lblProbVictoriaE1.Text = String.Format("Probabilidad de victoria: {0}%", probGanados);
            }
            else
            {
                this.lblProbVictoriaE1.Text = "Probabilidad de victoria: 0%";
            }

            if (this.e1.Perdidos > 0)
            {
                probPerdidos = probPerdidos.MiPromedio((float)this.e1.Perdidos, (float)this.e1.PartidosJugados, 100);
                this.lblProbDerrotaE1.Text = String.Format("Probabilidad de derrota: {0}%", probPerdidos);
            }
            else
            {
                this.lblProbDerrotaE1.Text = "Probabilidad de derrota: 0%";
            }

            if (this.e1.GolesAFavor > 0)
            {
                promGolesFavor = promGolesFavor.MiPromedioGoles((float)this.e1.GolesAFavor, (float)this.e1.PartidosJugados);
                this.lblPromGolesFavorE1.Text = String.Format("Promedio de gol a favor por partido: {0}", promGolesFavor);
            }
            else
            {
                this.lblPromGolesFavorE1.Text = "Promedio de gol a favor por partido: 0";
            }

            if (this.e1.GolesEnContra > 0)
            {
                promGolesEnContra = promGolesEnContra.MiPromedioGoles((float)this.e1.GolesEnContra,(float)this.e1.PartidosJugados);
                this.lblPromGolesContraE1.Text = String.Format("Promedio de gol en contra por partido: {0}", promGolesEnContra);
            }
            else 
            {
                this.lblPromGolesContraE1.Text = "Promedio de gol en contra por partido: 0";
            }
            
        }
        public void CargarDatosE2()
        {
            float probGanados = 0;
            float probPerdidos = 0;
            float promGolesFavor = 0;
            float promGolesEnContra = 0;

            this.lblNameE2.Text = "Nombre equipo: " + this.e2.Nombre;
            this.lblPartidosJugadosE2.Text = "Partidos jugados: " + this.e2.PartidosJugados;
            this.lblPartidosGanadosE2.Text = "Partidos ganados: " + this.e2.Ganados;
            this.lblPartidosEmpatadosE2.Text = "Partidos empatados: " + this.e2.Empatados;
            this.lblPartidosPerdidosE2.Text = "Partidos perdidos: " + this.e2.Perdidos;
            this.lblGolesAFavorE2.Text = "Goles a favor: " + this.e2.GolesAFavor;
            this.lblGolesEnContraE2.Text = "Goles en contra: " + this.e2.GolesEnContra;
            this.lblDiferenciaE2.Text = "Diferencia de goles: " + this.e2.Diferencia;


            if (this.e2.Ganados > 0)
            {
                probGanados = probGanados.MiPromedio((float)this.e2.Ganados, (float)this.e2.PartidosJugados, 100);
                this.lblProbVictoriaE2.Text = String.Format("Probabilidad de victoria: {0}%", probGanados);
            }
            else
            {
                this.lblProbVictoriaE2.Text = "Probabilidad de victoria: 0%";
            }

            if (this.e2.Perdidos > 0)
            {
                probPerdidos = probPerdidos.MiPromedio((float)this.e2.Perdidos, (float)this.e2.PartidosJugados, 100);
                this.lblProbDerrotaE2.Text = String.Format("Probabilidad de derrota: {0}%", probPerdidos);
            }
            else
            {
                this.lblProbDerrotaE2.Text = "Probabilidad de derrota: 0%";
            }

            if (this.e2.GolesAFavor > 0)
            {
                promGolesFavor = promGolesFavor.MiPromedioGoles((float)this.e2.GolesAFavor, (float)this.e2.PartidosJugados);
                this.lblPromGolesFavorE2.Text = String.Format("Promedio de gol a favor por partido: {0}", promGolesFavor);
            }
            else
            {
                this.lblPromGolesFavorE2.Text = "Promedio de gol a favor por partido: 0";
            }

            if (this.e2.GolesEnContra > 0)
            {
                promGolesEnContra = promGolesEnContra.MiPromedioGoles((float)this.e2.GolesEnContra, (float)this.e2.PartidosJugados);
                this.lblPromGolesContraE2.Text = String.Format("Promedio de gol en contra por partido: {0}", promGolesEnContra);
            }
            else
            {
                this.lblPromGolesContraE2.Text = "Promedio de gol en contra por partido: 0";
            }
        }

        public void CargarMensaje()
        {
            string mensaje = String.Empty;
            if (this.e1 > this.e2 == 1)
            {
                mensaje = String.Format("{0} esta mejor que {1}", this.e1.Nombre, this.e2.Nombre);
            }
            else if (this.e1 < this.e2 == 1)
            {
                mensaje = String.Format("{0} esta mejor que {1}", this.e2.Nombre, this.e1.Nombre);
            }
            else
            {
                mensaje = String.Format("{0} y {1} tienen igualdad de puntos y igualdad de diferencia en goles", this.e1.Nombre, this.e2.Nombre);
            }

            this.lblMensajeComparativo.Text = mensaje;
        }

        private void FormComparar_Load(object sender, EventArgs e)
        {
            this.CargarDatosE1();
            this.CargarDatosE2();
            this.CargarMensaje();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
