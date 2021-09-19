using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {


        private double numero;

        /// <summary>
        /// El constructor inicial, inicializa el numero es 0
        /// </summary>
        public Operando()
        {
            numero = 0;
        }


        /// <summary>
        /// Este constructor inicializa el numero de acuerdo al parametro pasado
        /// </summary>
        /// <param name="numero"></param> Es un double para asignar a nuestro atributo numero
        public Operando(double numero) : this()
        {
            this.numero = numero;
        }


        /// <summary>
        /// Este contructor inicializa el numero pasando un string
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero) : this()
        {
            Numero = strNumero;
        }

        /// <summary>
        /// Esta propiedad solo sirve para setear el valor del numero
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }  
        }

        /// <summary>
        /// Este metodo transforma el string pasado por parametro a un double si es que puedo y lo retorna en caso contrario retorna 0
        /// </summary>
        /// <param name="strNumero"></param> Es un string para transformarlo en double
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            double numero;
            if(double.TryParse(strNumero, out numero))
            {
                return numero;
            }
            
            return 0;
        }


        /// <summary>
        /// Este verifica que el string pasado por parametro sea un numero binario, en caso de no serlo retorna false caso contrario true
        /// </summary>
        /// <param name="binario"></param> Es un string que se verifica que sea un numero binario
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            for(int i = 0; i < binario.Length - 1; i++)
            {
                if(binario[i] != '0' && binario[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Este metodo transforma el numero binario pasado por string a un numero deciaml, en caso de no ser un numero binario retorna "Valor invalido"
        /// </summary>
        /// <param name="binario"></param> Es un string donde se pasa el un numero binario
        /// <returns></returns>
        public string BinarioDecimal(string binario)
        {
            if(EsBinario(binario))
            {
                double total = 0;
                int contador = 0;
                for(int i = binario.Length - 1; i > -1; i--)
                {
                    
                    if(binario[i] == '1')
                    {
                        total += Math.Pow(2, contador);
                    }
                    contador++;
                }

                return Convert.ToString(total);
            }else
            {
                return "Valor invalido";
            }
        }


        /// <summary>
        /// Transforma un numero decimal a binario a través de un double, en caso de no poder realizar de vuelve "Valor invalido", caso contrario el numero en forma de string
        /// </summary>
        /// <param name="numero"></param> Es un double que recibe el numero a convertir
        /// <returns></returns>
        public string DecimalBinario(double numero)
        {
            if(numero > -1)
            {
                string total = string.Empty;
                string aux = string.Empty;
                while((int)numero > 0)
                {
                    aux += Convert.ToString(  ((int)(numero % 2))  );
                    numero = numero / 2;
                }

                for(int i = aux.Length -1; i > -1; i--)
                {
                    total += aux[i];
                }

                return Convert.ToString(total);
            }

            return "Valor invalido";
        }


        /// <summary>
        /// Este metodo transforma un numero decimal paso como string a un numero binario
        /// </summary>
        /// <param name="numero"></param> Es un string que recibe el string a convertir
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            double numeroAConvertir;
            if(double.TryParse(numero, out numeroAConvertir))
            {
                return DecimalBinario(numeroAConvertir);
            }else
            {
                return "Valor invalido";
            }
            
        }


        /// <summary>
        /// Este operador reste el valor del atributo numero de la clase Operando 1 con el de la clase Operando 2, retorna el resultado
        /// </summary>
        /// <param name="n1"></param> Recibe una clase Operando para restar con el Operando 2
        /// <param name="n2"></param> Recibe una clase Operando para restar con el Operando 1
        /// <returns></returns>
        public static double operator-(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }


        /// <summary>
        /// Este operador suma el valor del atributo numero de la clase Operando 1 con el de la clase Operando 2, retorna el resultado
        /// </summary>
        /// <param name="n1"></param> Recibe una clase Operando para sumar con el Operando 2
        /// <param name="n2"></param> Recibe una clase Operando para sumar con el Operando 1
        /// <returns></returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }


        /// <summary>
        /// Este operador divide el valor del atributo numero de la clase Operando 1 con el de la clase Operando 2, en caso de no poder retorna el valor minimo de un double
        /// </summary>
        /// <param name="n1"></param> Recibe una clase Operando para dividir con el Operando 1
        /// <param name="n2"></param> Recibe una clase Operando para dividir con el Operando 1
        /// <returns></returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero > 0)
            {
                return n1.numero / n2.numero;
            }else
            {
                return double.MinValue;
            }
            
        }


        /// <summary>
        /// Este operador multiplica el valor del atributo numero de la clase Operando 1 con el de la clase Operando 2, retorna el resultado
        /// </summary>
        /// <param name="n1"></param> Recibe una clase Operando para multiplicar con el Operando 1
        /// <param name="n2"></param> Recibe una clase Operando para multiplicar con el Operando 2
        /// <returns></returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
    }
}
