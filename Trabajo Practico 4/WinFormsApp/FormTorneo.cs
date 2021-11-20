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
    public partial class FormTorneo : Form
    {
        FormPrincipal frmPrincipal;
        Torneo torneo; 
        public FormTorneo(FormPrincipal frmPrincipal, Torneo torneo)
        {
            this.frmPrincipal = frmPrincipal;
            this.torneo = torneo;
            InitializeComponent();
        }


        private bool ValidarCampos()
        {
            if ( !String.IsNullOrEmpty(this.txtBoxNombre.Text) &&
                 !String.IsNullOrEmpty(this.txtBoxFechas.Text) &&
                 !String.IsNullOrEmpty(this.txtBoxEquipos.Text) )
            {
                return true;
            }
            return false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(this.ValidarCampos())
            {
                int cantidadFechas;
                int capacidadMaxima;
                if (int.TryParse(this.txtBoxFechas.Text, out cantidadFechas) && 
                    int.TryParse(this.txtBoxEquipos.Text, out capacidadMaxima))
                {

                    if (cantidadFechas >= this.torneo.FechaActual && capacidadMaxima > this.torneo.Equipos.Count)
                    {
                        this.torneo.Nombre = this.txtBoxNombre.Text;
                        this.torneo.CantidadDeFechas = cantidadFechas;
                        this.torneo.CapacidadMaxima = capacidadMaxima;
                        this.frmPrincipal.ActualizarForm();
                        MessageBox.Show("Modificado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error la cantidad de fechas es menor a la actual o la capacidad maxima es menor a la actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                {
                    MessageBox.Show("Ingrese solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTorneo_Load(object sender, EventArgs e)
        {
            this.txtBoxNombre.Text = this.torneo.Nombre;
            this.txtBoxFechas.Text = this.torneo.CantidadDeFechas.ToString();
            this.txtBoxEquipos.Text = this.torneo.CapacidadMaxima.ToString();
            this.lblFechaActual.Text = "Fecha actual: " + this.torneo.FechaActual;
        }
    }
}
