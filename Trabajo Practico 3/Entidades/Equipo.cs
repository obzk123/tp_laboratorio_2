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
        public Equipo()
        {

        }

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

        public int PartidosJugados
        {
            get
            {
                return this.Ganados + this.Empatados + this.Perdidos;
            }
        }
        public int Puntos
        {
            get
            {
                return (this.Ganados * 3) + this.Empatados;
            }
        }

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

        public int Diferencia
        {
            get
            {
                return this.GolesAFavor - this.GolesEnContra;
            }
        }

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
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if(e1.Nombre == e2.Nombre)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public static bool operator >(Equipo e1, Equipo e2)
        {
            if(e1.Puntos > e2.Puntos || e1.Puntos == e2.Puntos && e1.Diferencia > e2.Diferencia)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Equipo e1, Equipo e2)
        {
            return !(e1 > e2);
        }
        #endregion

    }
}
