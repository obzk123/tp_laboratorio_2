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


            this.lblNameE1.Text =  this.e1.Nombre;
            this.richTxt1.Text +=  "Partidos jugados: " + this.e1.PartidosJugados;
            this.richTxt1.Text +=  "\nPartidos ganados: " + this.e1.Ganados;
            this.richTxt1.Text += "\nPartidos empatados: " + this.e1.Empatados;
            this.richTxt1.Text += "\nPartidos perdidos: " + this.e1.Perdidos;
            this.richTxt1.Text += "\nGoles a favor: " + this.e1.GolesAFavor;
            this.richTxt1.Text += "\nGoles en contra: " + this.e1.GolesEnContra;
            this.richTxt1.Text += "\nDiferencia de goles: " + this.e1.Diferencia;
            if (this.e1.Ganados > 0)
            {
             
                probGanados = probGanados.MiPromedio((float)this.e1.Ganados, (float)this.e1.PartidosJugados, 100);
                this.richTxt1.Text += String.Format("\nProbabilidad de victoria: {0:0.00}%", probGanados);
            }
            else
            {
                this.richTxt1.Text += "\nProbabilidad de victoria: 0%";
            }

            if (this.e1.Perdidos > 0)
            {
                probPerdidos = probPerdidos.MiPromedio((float)this.e1.Perdidos, (float)this.e1.PartidosJugados, 100);
                this.richTxt1.Text += String.Format("\nProbabilidad de derrota: {0:0.00}%", probPerdidos);
            }
            else
            {
                this.richTxt1.Text += "\nProbabilidad de derrota: 0%";
            }

            if (this.e1.GolesAFavor > 0)
            {
                promGolesFavor = promGolesFavor.MiPromedioGoles((float)this.e1.GolesAFavor, (float)this.e1.PartidosJugados);
                this.richTxt1.Text += String.Format("\nPromedio de gol a favor por partido: {0:0.00}", promGolesFavor);
            }
            else
            {
                this.richTxt1.Text += "\nPromedio de gol a favor por partido: 0";
            }

            if (this.e1.GolesEnContra > 0)
            {
                promGolesEnContra = promGolesEnContra.MiPromedioGoles((float)this.e1.GolesEnContra,(float)this.e1.PartidosJugados);
                this.richTxt1.Text += String.Format("\nPromedio de gol en contra por partido: {0:0.00}", promGolesEnContra);
            }
            else 
            {
                this.richTxt1.Text += "\nPromedio de gol en contra por partido: 0";
            }
            
        }
        public void CargarDatosE2()
        {
            float probGanados = 0;
            float probPerdidos = 0;
            float promGolesFavor = 0;
            float promGolesEnContra = 0;

            this.lblNameE2.Text = this.e2.Nombre;
            this.richTxt2.Text += "Partidos jugados: " + this.e2.PartidosJugados;
            this.richTxt2.Text += "\nPartidos ganados: " + this.e2.Ganados;
            this.richTxt2.Text += "\nPartidos empatados: " + this.e2.Empatados;
            this.richTxt2.Text += "\nPartidos perdidos: " + this.e2.Perdidos;
            this.richTxt2.Text += "\nGoles a favor: " + this.e2.GolesAFavor;
            this.richTxt2.Text += "\nGoles en contra: " + this.e2.GolesEnContra;
            this.richTxt2.Text += "\nDiferencia de goles: " + this.e2.Diferencia;


            if (this.e2.Ganados > 0)
            {
                probGanados = probGanados.MiPromedio((float)this.e2.Ganados, (float)this.e2.PartidosJugados, 100);
                this.richTxt2.Text += String.Format("\nProbabilidad de victoria: {0:0.00}%", probGanados);
            }
            else
            {
                this.richTxt2.Text += "\nProbabilidad de victoria: 0%";
            }

            if (this.e2.Perdidos > 0)
            {
                probPerdidos = probPerdidos.MiPromedio((float)this.e2.Perdidos, (float)this.e2.PartidosJugados, 100);
                this.richTxt2.Text += String.Format("\nProbabilidad de derrota: {0:0.00}%", probPerdidos);
            }
            else
            {
                this.richTxt2.Text += "\nProbabilidad de derrota: 0%";
            }

            if (this.e2.GolesAFavor > 0)
            {
                promGolesFavor = promGolesFavor.MiPromedioGoles((float)this.e2.GolesAFavor, (float)this.e2.PartidosJugados);
                this.richTxt2.Text += String.Format("\nPromedio de gol a favor por partido: {0:0.00}", promGolesFavor);
            }
            else
            {
                this.richTxt2.Text += "\nPromedio de gol a favor por partido: 0";
            }

            if (this.e2.GolesEnContra > 0)
            {
                promGolesEnContra = promGolesEnContra.MiPromedioGoles((float)this.e2.GolesEnContra, (float)this.e2.PartidosJugados);
                this.richTxt2.Text += String.Format("\nPromedio de gol en contra por partido: {0:0.00}", promGolesEnContra);
            }
            else
            {
                this.richTxt2.Text += "\nPromedio de gol en contra por partido: 0";
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
                mensaje = String.Format("{0} y {1} estan iguales", this.e1.Nombre, this.e2.Nombre);
            }

            this.lblMensajeComparativo.Text = mensaje;
        }

        private void FormComparar_Load(object sender, EventArgs e)
        {
            this.CargarDatosE1();
            this.CargarDatosE2();
            this.PorcentajeVictoriaEntreEllos();
            this.CargarMensaje();
        }

        private void PorcentajeVictoriaEntreEllos()
        {
            int totalPartidos = this.e1.PartidosJugados + this.e2.PartidosJugados;

            float porcentajeDeGanarE1 = ((float)this.e1.Ganados / (float)totalPartidos) * 100;
            float porcentajeDeEmpatarE1 = ((float)this.e1.Empatados / (float)totalPartidos) * 100;
            float porcentajeDePerderE1 = ((float)this.e1.Perdidos / (float)totalPartidos) * 100;
            
            this.lblDiferencia.Text = this.e1.Nombre + " ante " + this.e2.Nombre + "\n";
            this.lblDiferencia.Text += String.Format("Probabilidad de victoria de {0:0.00}%, empate {1:0.00}%, derrota {2:0.00}%\n", porcentajeDeGanarE1, porcentajeDeEmpatarE1, porcentajeDePerderE1);
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnJugarPartido_Click(object sender, EventArgs e)
        {
            FormPartido frmPartido = new FormPartido(this.e1, this.e2);
            frmPartido.ShowDialog();
        }

    }
}
