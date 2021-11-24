using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExceptionJson : Exception
    {
        private string clase;
        private string metodo;

        /// <summary>
        /// Recibe un mensaje, un metodo y una clase, utiliza la reutilizacion del otro constructor pasando como null una Exception
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="metodo"></param>
        /// <param name="clase"></param>
        public ExceptionJson(string mensaje, string metodo, string clase)
            : this(mensaje, metodo, clase, null)
        {

        }

        /// <summary>
        /// Recibe un mensaje, un metodo, una clase y un Excepcion, utilizando el constructor base de la clase base Exception
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="metodo"></param>
        /// <param name="clase"></param>
        /// <param name="innerException"></param>
        public ExceptionJson(string mensaje, string metodo, string clase, Exception innerException)
            : base(mensaje, innerException)
        {
            this.clase = clase;
            this.metodo = metodo;
        }


        /// <summary>
        /// Retorna el atributo clase
        /// </summary>
        public string Clase
        {
            get 
            {
                return this.clase;
            }
        }

        /// <summary>
        /// Retorna el atributo metodo
        /// </summary>
        public string Metodo
        {
            get
            {
                return this.metodo;
            }
        }
    }
}
