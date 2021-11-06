using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Torneo
    {
        private string nombre;
        List<Equipo> equipos;
        private int fechaActual;
        private int cantidadDeFechas;
        private int capacidadMaxima;

        #region Constructores
        public Torneo(string nombre, int cantidadDeFechas, int capacidadMaxima)
        {
            this.nombre = nombre;
            this.equipos = new List<Equipo>();
            this.fechaActual = 0;
            this.cantidadDeFechas = cantidadDeFechas;
            this.capacidadMaxima = capacidadMaxima;
        }
        #endregion

        #region Propiedades
        public List<Equipo> Equipos
        {
            get
            {
                return this.equipos;
            }
            set
            {
                this.equipos = value;
            }
        }

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

        public int FechaActual
        {
            get
            {
                return this.fechaActual;
            }
            set
            {
                this.fechaActual = value;
            }
        }

        public int CantidadDeFechas
        {
            get
            {
                return this.cantidadDeFechas;
            }
            set
            {
                this.cantidadDeFechas = value;
            }
        }
        
        public int CapacidadMaxima
        {
            get
            {
                return this.capacidadMaxima;
            }
            set
            {
                this.capacidadMaxima = value;
            }
        }

        #endregion

        #region Metodos

        public int BuscarEquipo(string nombre)
        {
            for(int i = 0; i < this.Equipos.Count; i++)
            {
                if(nombre == this.Equipos[i].Nombre)
                {
                    return i;
                }
            }
            return -1;
        }

        public string MostrarEquipos()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach(Equipo aux in this.Equipos)
            {
                sb.AppendFormat("{0}\n", aux.ToString());
            }

            return sb.ToString();
            
        }

        public bool AvanzarTorneo()
        {
            if (this.fechaActual < this.CantidadDeFechas && this.Equipos.Count > 1)
            {
                Random numeroRandomGolesFavor = new Random();
                Random numeroRandomGolesEnContra = new Random();
                int numerosGolesFavor;
                int numerosGolesEnContra;

                for (int i = 0; i < this.Equipos.Count; i++)
                {
                    numerosGolesFavor = numeroRandomGolesFavor.Next(0, 5);
                    numerosGolesEnContra = numeroRandomGolesEnContra.Next(0, 5);

                    if(numerosGolesFavor > numerosGolesEnContra)
                    {
                        this.Equipos[i].Ganados++;
                    }else if(numerosGolesFavor == numerosGolesEnContra)
                    {
                        this.Equipos[i].Empatados++;

                    }else
                    {
                        this.Equipos[i].Perdidos++;
                    }

                    this.Equipos[i].GolesAFavor += numerosGolesFavor;
                    this.Equipos[i].GolesEnContra += numerosGolesEnContra;
                }

                this.fechaActual++;
                return true;
            }

            return false;
        }

        public void ResetearTorneo()
        {
            this.fechaActual = 0;
            for(int i = 0; i < this.Equipos.Count; i++)
            {
                this.Equipos[i].Ganados = 0;
                this.Equipos[i].Empatados = 0;
                this.Equipos[i].Perdidos = 0;
                this.Equipos[i].GolesAFavor = 0;
                this.Equipos[i].GolesEnContra = 0;
            }
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Torneo: {0}\nCantidad de equipos: {1}\nFecha actual: {2} de {3}\n\n",
                this.Nombre, this.CapacidadMaxima, this.FechaActual, this.CantidadDeFechas);

            sb.Append("Equipos:\n" + this.MostrarEquipos());

            return sb.ToString();
        }

        #endregion

        #region Operadores
        public static bool operator +(Torneo t, Equipo e)
        {
            if(t.CapacidadMaxima > t.Equipos.Count)
            {
                foreach (Equipo aux in t.Equipos)
                {
                    if (aux == e)
                    {
                        return false;
                    }
                }
                t.Equipos.Add(e);
                return true;
            }
            return false;
        }

        public static bool operator -(Torneo t, Equipo e)
        {
            foreach(Equipo aux in t.Equipos)
            {
                if(aux == e)
                {
                    t.Equipos.Remove(e);
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
