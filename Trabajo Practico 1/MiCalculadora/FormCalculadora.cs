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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            
            this.cmbOperador.Items.Add("");
            this.cmbOperador.Items.Add("+");
            this.cmbOperador.Items.Add("-");
            this.cmbOperador.Items.Add("/");
            this.cmbOperador.Items.Add("*");    
        }

        /// <summary>
        /// Pide al usuario confirmacion para cerrar al apretar el boton Cerrar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Al iniciar la aplicacion ejecuta un metodo llamado Limpiar para limpiar la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Es un metodo que sirve para limpiar el combo box, el label del resultado y el text box de los numeros
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = String.Empty;
            this.txtNumero2.Text = String.Empty;
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = String.Empty;
        }

        /// <summary>
        /// Al hacer click en el boton limpiar llama al metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Es un metodo que sirve para llamar a el metodo operar de la clase Calculadora para realizar la operacion
        /// </summary>
        /// <param name="numero1"></param> Es un string que recibe el string del textBox Numero 1
        /// <param name="numero2"></param> Es un string que recibe el string del textBox Numero 2
        /// <param name="operador"></param> Es un string que recibe el string del combo box del operador
        /// <returns></returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            char operadorVar;
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            char.TryParse(operador, out operadorVar);
            return Calculadora.Operar(operando1, operando2, operadorVar);
        }

        
        /// <summary>
        /// Al hacer click en el boton operar se llama al metodo operar pasando los parametros de los txtNumeros y el texto del combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string texto = String.Empty;
            string operador = this.cmbOperador.Text;
            if(this.cmbOperador.Text == "")
            {
                operador = "+";
            }
            double resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
            texto = String.Format(this.txtNumero1.Text + operador + this.txtNumero2.Text + " = " + Convert.ToString(resultado) + "\n");
            this.lstOperaciones.Items.Add(texto);
            this.lblResultado.Text = Convert.ToString(resultado);

        }

        /// <summary>
        /// Este metodo sirve para cuando se presiona la "X" de la parte superior izquierda se consulte para cerrar el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Este metodo se ejecuta al hacer click en el boton convertir a binario y llama a un metodo de la clase Operando para realizar la accion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando operador = new Operando();
            string cadena = operador.DecimalBinario(this.lblResultado.Text);
            this.lblResultado.Text = cadena;
            this.lstOperaciones.Items.Add(cadena);

        }


        /// <summary>
        ///  Este metodo se ejecuta al hacer click en el boton convertir a decimal y llama a un metodo de la clase Operando para realizar la accion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando operador = new Operando();
            string cadena = operador.BinarioDecimal(this.lblResultado.Text);
            this.lblResultado.Text = cadena;
            this.lstOperaciones.Items.Add(cadena);
        }
    }
}
