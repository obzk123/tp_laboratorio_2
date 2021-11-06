using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExceptionXml : Exception
    {
        private string metodo;
        private string clase;

        public ExceptionXml(string mensaje, string metodo, string clase)
            : this(mensaje, metodo, clase, null)
        {

        }

        public ExceptionXml(string mensaje, string metodo, string clase, Exception innerException)
            : base(mensaje, innerException)
        {
            this.metodo = metodo;
            this.clase = clase;
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
