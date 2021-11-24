using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private string nombre;
        private int partidosGanados;
        private int partidosEmpatados;
        private int partidosPerdidos;
        private int golesAFavor;
        private int golesEnContra;

        #region Constructores

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Equipo()
        {

        }
        
        /// <summary>
        /// Constructor para asignar los atributos
        /// </summary>
        /// <param name="nombre"></param> 
        /// <param name="ganados"></param>
        /// <param name="empatados"></param>
        /// <param name="perdidos"></param>
        /// <param name="golesAFavor"></param>
        /// <param name="golesEnContra"></param>
        public Equipo(string nombre, int ganados, int empatados, int perdidos, int golesAFavor, int golesEnContra)
        {
            this.Nombre = nombre;
            this.Ganados = ganados;
            this.Empatados = empatados;
            this.Perdidos = perdidos;
            this.GolesAFavor = golesAFavor;
            this.GolesEnContra = golesEnContra;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad que nos permite retornar y setear el atributo nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        /// <summary>
        /// Propiedad que nos permite retornar un valor int para saber los Partidos Jugados
        /// </summary>
        public int PartidosJugados
        {
            get
            {
                return this.Ganados + this.Empatados + this.Perdidos;
            }
        }

        /// <summary>
        /// Propiedad que nos permite retornar un valor int para saber los Puntos
        /// </summary>
        public int Puntos
        {
            get
            {
                return (this.Ganados * 3) + this.Empatados;
            }
        }

        /// <summary>
        /// Propiedad que nos permite retornar y setear el atributo golesAFavor
        /// </summary>
        public int GolesAFavor
        {
            get
            {
                return this.golesAFavor;
            }
            set
            {
                this.golesAFavor = value;
            }
        }

        /// <summary>
        /// Propiedad que nos permite retornar y setear el atributo golesEnContra
        /// </summary>
        public int GolesEnContra
        {
            get
            {
                return this.golesEnContra;
            }
            set
            {
                this.golesEnContra = value;
            }
        }

        /// <summary>
        /// Propiedad que nos permite retornar un int con la diferencia de goles a favor y en contra
        /// </summary>
        public int Diferencia
        {
            get
            {
                return this.GolesAFavor - this.GolesEnContra;
            }
        }

        /// <summary>
        /// Propiedad que nos permite retornar y setear el atributo partidosGanados
        /// </summary>
        public int Ganados
        {
            get
            {
                return this.partidosGanados;
            }
            set
            {
                this.partidosGanados = value;
            }
        }

        /// <summary>
        /// Propiedad que nos permite retornar y setear el atributo partidosEmpatados
        /// </summary>
        public int Empatados
        {
            get
            {
                return this.partidosEmpatados;
            }
            set
            {
                this.partidosEmpatados = value;
            }
        }

        /// <summary>
        /// Propiedad que nos permite retornar y setear el atributo partidosPerdidos
        /// </summary>
        public int Perdidos
        {
            get
            {
                return this.partidosPerdidos;
            }
            set
            {
                this.partidosPerdidos = value;
            }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Una sobreescritura del metodo ToString para obtener todos los datos del Equipo y retornarno en un string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}\n" +
                "Partidos Jugados: {1}\n" +
                "Ganados: {2}\n" +
                "Empatados: {3}\n" +
                "Perdidos: {4}\n" +
                "Puntos: {5}\n" +
                "Goles a Favor: {6}\n" +
                "Goles En Contra: {7}\n" +
                "Diferencia: {8}\n",
                this.Nombre,
                this.PartidosJugados,
                this.Ganados,
                this.Empatados,
                this.Perdidos,
                this.Puntos,
                this.GolesAFavor,
                this.GolesEnContra,
                this.Diferencia);

            return sb.ToString();
        }

        #endregion

        #region Operadores
        
        /// <summary>
        /// Operador que compara dos equipos por su nombre retorna true si ambos nombres son iguales
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if(e1.Nombre == e2.Nombre)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Operador que compara dos equipos por su nombre pero retorna true si no son iguales y true si son iguales
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        /// <summary>
        /// Operador que compara dos equipos a través de sus puntos en caso de ser iguales compara por su diferencia
        /// retorna true si el e1 es mayor a e2 o false en caso contrario
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static int operator >(Equipo e1, Equipo e2)
        {
            if(e1.Puntos > e2.Puntos || e1.Puntos == e2.Puntos && e1.Diferencia > e2.Diferencia)
            {
                return 1;
            }else if(e1.Puntos == e2.Puntos && e1.Diferencia == e2.Diferencia)
            {
                return 0;
            }
            return -1;
        }

        /// <summary>
        /// Operador que compara dos equipos a través de sus puntos en caso de ser iguales compara por su diferencia
        /// retorna true si el e2 es mayor a e1 o false en caso contrario
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static int operator <(Equipo e1, Equipo e2)
        {
            if(e1 > e2 == 1)
            {
                return -1;
            }
            else if(e1 > e2 == -1)
            {
                return 1;
            }
            return 0;
                
        }


        #endregion

    }
}
