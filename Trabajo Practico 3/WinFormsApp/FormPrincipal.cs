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
using System.IO;


namespace WinFormsApp
{
    public partial class FormPrincipal : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        SaveFileDialog saveFile = new SaveFileDialog();
        GestorDeArchivos gda;
        Torneo torneo; 
        FormEquipos frmEquipos;
        FormTorneo frmTorneo;


        public FormPrincipal()
        {
            this.gda = new GestorDeArchivos();
            this.torneo = new Torneo("Primera Divison", 20, 15);
            this.frmTorneo = new FormTorneo(this, this.torneo);
            this.frmEquipos = new FormEquipos(this.torneo, this);
            this.openFile.Filter = "Text Files |*.txt|Json File |*.json|Xml Files |*.xml";
            this.saveFile.Filter = "Text Files |*.txt|Json File |*.json|Xml Files |*.xml";
            
            
            InitializeComponent();
            this.ActualizarForm();
            
        }

        public void ActualizarForm()
        {
           
            this.tabla.Rows.Clear();
            for (int i = 0; i < torneo.Equipos.Count; i++)
            {
                int index = this.tabla.Rows.Add();
                this.tabla.Rows[index].Cells[0].Value = torneo.Equipos[i].Nombre;
                this.tabla.Rows[index].Cells[1].Value = torneo.Equipos[i].PartidosJugados;
                this.tabla.Rows[index].Cells[2].Value = torneo.Equipos[i].Ganados;
                this.tabla.Rows[index].Cells[3].Value = torneo.Equipos[i].Empatados;
                this.tabla.Rows[index].Cells[4].Value = torneo.Equipos[i].Perdidos;
                this.tabla.Rows[index].Cells[5].Value = torneo.Equipos[i].GolesAFavor;
                this.tabla.Rows[index].Cells[6].Value = torneo.Equipos[i].GolesEnContra;
                this.tabla.Rows[index].Cells[7].Value = torneo.Equipos[i].Diferencia;
                this.tabla.Rows[index].Cells[8].Value = torneo.Equipos[i].Puntos;
                
            }

            this.tabla.Sort(this.tabla.Columns[8], ListSortDirection.Descending);
            this.lblFecha.Text = "Fecha: " + this.torneo.FechaActual.ToString() + "/" + this.torneo.CantidadDeFechas.ToString();
            this.lblTorneo.Text = "Torneo: " + this.torneo.Nombre;
            this.lblMaximoEquipos.Text = "Capacidad maxima: " + this.torneo.CapacidadMaxima.ToString();
        }


        #region Menu Strip Archivo
        private void toolStripGuardarComo_Click(object sender, EventArgs e)
        {
            this.saveFile.ShowDialog();
            if (this.saveFile.FileName != String.Empty)
            {
                if (Path.GetExtension(this.saveFile.FileName) == ".txt")
                {
                    try
                    {
                        this.gda.GuardarTxt(this.saveFile.FileName, this.torneo);
                    }
                    catch (ExceptionTxt ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.saveFile.FileName) == ".json")
                {
                    try
                    {
                        this.gda.GuardarJSON(this.saveFile.FileName, this.torneo);
                    }
                    catch (ExceptionJson ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (Path.GetExtension(this.saveFile.FileName) == ".xml")
                {
                    try
                    {
                        this.gda.GuardarXML(this.saveFile.FileName, this.torneo);
                    }
                    catch (ExceptionXml ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.ActualizarForm();
                this.openFile.FileName = this.saveFile.FileName;
            }
        }

        private void toolStripAbrir_Click(object sender, EventArgs e)
        {
            this.openFile.ShowDialog();
            if (this.openFile.FileName != null)
            {
                if (Path.GetExtension(this.openFile.FileName) == ".txt")
                {
                    try
                    {
                        this.torneo = this.gda.AbrirTxt(this.openFile.FileName, this.torneo);
                    }
                    catch (ExceptionTxt ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.openFile.FileName) == ".json")
                {
                    try
                    {
                        this.torneo = this.gda.AbrirJSON(this.openFile.FileName, this.torneo);
                    }
                    catch (ExceptionJson ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.openFile.FileName) == ".xml")
                {
                    try
                    {
                        this.torneo = this.gda.AbrirXML(this.openFile.FileName, this.torneo);
                    }
                    catch (ExceptionXml ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.ActualizarForm();
            }


        }

        private void toolStripGuardar_Click(object sender, EventArgs e)
        {
            if (this.openFile.FileName != String.Empty)
            {
                if (Path.GetExtension(this.openFile.FileName) == ".txt")
                {
                    try
                    {
                        this.gda.GuardarTxt(this.openFile.FileName, this.torneo);
                    }
                    catch (ExceptionTxt ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Path.GetExtension(this.openFile.FileName) == ".json")
                {
                    try
                    {
                        this.gda.GuardarJSON(this.openFile.FileName, this.torneo);
                    }
                    catch (ExceptionJson ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (Path.GetExtension(this.openFile.FileName) == ".xml")
                {
                    try
                    {
                        this.gda.GuardarXML(this.openFile.FileName, this.torneo);
                    }
                    catch (ExceptionXml ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                this.ActualizarForm();
            }
            else
            {
                this.toolStripGuardarComo_Click(sender, e);
            }


        }

        #endregion

        #region Menu Strip Equipo

        private void toolStripAgregar_Click(object sender, EventArgs e)
        {
            this.frmEquipos.btnAgregar.Enabled = true;
            this.frmEquipos.ShowDialog();
        }


        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            if (this.tabla.CurrentCell != null)
            {
                int rowIndex = this.tabla.CurrentCell.RowIndex;
                int indexEquipo = this.torneo.BuscarEquipo(this.tabla.Rows[rowIndex].Cells[0].Value.ToString());
                this.frmEquipos.btnModificar.Enabled = true;
                this.frmEquipos.ModificarEquipo(indexEquipo);
                this.frmEquipos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione a un equipo para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            if (this.tabla.CurrentCell != null)
            {
                int rowIndex = this.tabla.CurrentCell.RowIndex;
                int indexEquipo = this.torneo.BuscarEquipo(this.tabla.Rows[rowIndex].Cells[0].Value.ToString());
                string nombre = this.torneo.Equipos[indexEquipo].Nombre;
                if (this.torneo - this.torneo.Equipos[indexEquipo])
                {
                    MessageBox.Show(nombre + " eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ActualizarForm();
                }
            }else
            {
                MessageBox.Show("Seleccione a un equipo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Menu Strip Torneo
        private void toolStripAvanzar_Click(object sender, EventArgs e)
        {
            if (this.torneo.AvanzarTorneo())
            {
                this.ActualizarForm();
            }else
            {
                MessageBox.Show("Error, no puede avanzar de fecha. Faltan equipos o llego a la ultima fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripResetear_Click(object sender, EventArgs e)
        {
            this.torneo.ResetearTorneo();
            this.ActualizarForm();
        }

        private void toolStripComparar_Click(object sender, EventArgs e)
        {
            if(this.tabla.SelectedRows.Count > 0 && this.tabla.SelectedRows.Count < 3)
            {
                string mensaje = String.Empty;
                int indexEquipo1;
                int indexEquipo2;
                DataGridViewRow row1 = this.tabla.SelectedRows[0];
                DataGridViewRow row2 = this.tabla.SelectedRows[1];

                indexEquipo1 = torneo.BuscarEquipo(row1.Cells[0].Value.ToString());
                indexEquipo2 = torneo.BuscarEquipo(row2.Cells[0].Value.ToString());

                if(this.torneo.Equipos[indexEquipo1] > this.torneo.Equipos[indexEquipo2])
                {
                    mensaje = String.Format("{0} esta mejor poisicionado que {1}", this.torneo.Equipos[indexEquipo1].Nombre, this.torneo.Equipos[indexEquipo2].Nombre);
                    MessageBox.Show(mensaje, "Comparacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    mensaje = String.Format("{0} esta mejor poisicionado que {1}", this.torneo.Equipos[indexEquipo2].Nombre, this.torneo.Equipos[indexEquipo1].Nombre);
                    MessageBox.Show(mensaje, "Comparacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            else
            {
                MessageBox.Show("Para comparar seleccione dos filas apretando a la izquierda del nombre manteniendo el CTRL", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

        private void toolStripInfoTorneo_Click(object sender, EventArgs e)
        {
            this.frmTorneo.ShowDialog();
        }

        #endregion
    }
}
