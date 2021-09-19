using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        /// <summary>
        /// Recibe un char para saber que operacion realizar y retorno el valor de la operacion realizada
        /// </summary>
        /// <param name="num1"></param> Este parametro recibe una clase Operando en la cual contiene el valor del numero 1
        /// <param name="num2"></param> Este parametro recibe una clase Operando en la cual contiene el valor del numero 2
        /// <param name="operador"></param> Recibe un char para saber que operacion realizar
        /// <returns></returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double valor = 0;
            switch(ValidarOperador(operador))
            {
                case '*':
                    valor = num1 * num2;
                    break;
                case '-':
                    valor = num1 - num2;
                    break;
                case '/':
                    valor = num1 / num2;
                    break;
                case '+':
                    valor = num1 + num2;
                    break;
            }
            return valor;
        }


        /// <summary>
        /// Este metodo valida el char pasado por parametro en caso de que el char no corresponda a ninguno valido de vuelve +
        /// </summary>
        /// <param name="operador"></param> el char pasado para validar como operando
        /// <returns></returns>
        private static char ValidarOperador(char operador)
        {
            if(operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }else
            {
                return '+';
            }
        }
    }
}
