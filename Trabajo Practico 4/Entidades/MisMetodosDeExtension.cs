using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MisMetodosDeExtension
    {

        public static float MiPromedio(this float valor, float dato1, float dato2, int multiplicador)
        {
            return dato1 / dato2 * multiplicador;
        }

        public static float MiPromedioGoles(this float valor, float dato1, float dato2)
        {
            return dato1 / dato2;
        }
    }
}
