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

        public ExceptionJson(string mensaje, string metodo, string clase)
            : this(mensaje, metodo, clase, null)
        {

        }

        public ExceptionJson(string mensaje, string metodo, string clase, Exception innerException)
            : base(mensaje, innerException)
        {
            this.clase = clase;
            this.metodo = metodo;
        }

        public string Clase
        {
            get 
            {
                return this.clase;
            }
        }

        public string Metodo
        {
            get
            {
                return this.metodo;
            }
        }
    }
}
