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
    public partial class FormEquipos : Form
    {
        Torneo torneo;
        FormPrincipal frmPrincipal;
        private int indexEquipo;

        public FormEquipos(Torneo torneo, FormPrincipal frmPrincipal)
        {
            this.torneo = torneo;
            this.frmPrincipal = frmPrincipal;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Equipo nuevoEquipo = this.CargarCampos();
            if ( !(nuevoEquipo is null) )
            {
                if (this.torneo + nuevoEquipo)
                {
                    MessageBox.Show("Equipo agregado", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.frmPrincipal.ActualizarForm();
                }
                else
                {
                    MessageBox.Show("Error al agregar el equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool Validar()
        {
            if( !(String.IsNullOrEmpty(this.txtBoxNombre.Text)) &&
                !(String.IsNullOrEmpty(this.txtBoxGanados.Text)) &&
                !(String.IsNullOrEmpty(this.txtBoxEmpatados.Text)) &&
                !(String.IsNullOrEmpty(this.txtBoxPerdidos.Text)) &&
                !(String.IsNullOrEmpty(this.txtBoxGolesAFavor.Text)) &&
                !(String.IsNullOrEmpty(this.txtBoxGolesEnContra.Text)) )
            {
                return true;
            }
            return false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Seguro desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public void ModificarEquipo(int indexEquipo)
        {
            this.indexEquipo = indexEquipo;
            Equipo equipoModificar = this.torneo.Equipos[indexEquipo];

            this.txtBoxNombre.Text = equipoModificar.Nombre;
            this.txtBoxGanados.Text = equipoModificar.Ganados.ToString();
            this.txtBoxEmpatados.Text = equipoModificar.Empatados.ToString();
            this.txtBoxPerdidos.Text = equipoModificar.Perdidos.ToString();
            this.txtBoxGolesAFavor.Text = equipoModificar.GolesAFavor.ToString();
            this.txtBoxGolesEnContra.Text = equipoModificar.GolesEnContra.ToString();
        }

        private void LimpiarTextos()
        {
            this.txtBoxNombre.Text = String.Empty;
            this.txtBoxGanados.Text = String.Empty;
            this.txtBoxEmpatados.Text = String.Empty;
            this.txtBoxPerdidos.Text = String.Empty;
            this.txtBoxGolesAFavor.Text = String.Empty;
            this.txtBoxGolesEnContra.Text = String.Empty;
        }

        private void FormEquipos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.btnAgregar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.LimpiarTextos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Equipo nuevoEquipo = this.CargarCampos();

            if (!(nuevoEquipo is null))
            {
                MessageBox.Show(this.torneo.Equipos[this.indexEquipo].Nombre + " Modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.torneo.Equipos[this.indexEquipo] = nuevoEquipo;
                this.frmPrincipal.ActualizarForm();
            }
            
        }

        private Equipo CargarCampos()
        {
            Equipo nuevoEquipo = new Equipo();

            int ganados;
            int empatados;
            int perdidos;
            int golesAFavor;
            int golesEnContra;

            if (this.Validar())
            {
                if (int.TryParse(this.txtBoxGanados.Text, out ganados) &&
                    int.TryParse(this.txtBoxEmpatados.Text, out empatados) &&
                    int.TryParse(this.txtBoxPerdidos.Text, out perdidos) &&
                    int.TryParse(this.txtBoxGolesAFavor.Text, out golesAFavor) &&
                    int.TryParse(this.txtBoxGolesEnContra.Text, out golesEnContra))
                {
                    nuevoEquipo.Nombre = this.txtBoxNombre.Text;
                    nuevoEquipo.Ganados = ganados;
                    nuevoEquipo.Empatados = empatados;
                    nuevoEquipo.Perdidos = perdidos;
                    nuevoEquipo.GolesAFavor = golesAFavor;
                    nuevoEquipo.GolesEnContra = golesEnContra;
                    if (nuevoEquipo.PartidosJugados != this.torneo.FechaActual)
                    {
                        MessageBox.Show("Error, ingreso mas partidos o menos de lo que va en la fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    else if (this.torneo.FechaActual == 0 && (golesAFavor > 0 || golesEnContra > 0))
                    {
                        MessageBox.Show("No puede modifcar goles a favor y en contra con 0 partidos jugados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    return nuevoEquipo;
                }
                else
                {
                    MessageBox.Show("Ingrese solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;    
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
