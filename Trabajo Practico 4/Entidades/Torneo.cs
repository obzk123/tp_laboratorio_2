using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Channels;
using System.Threading;

namespace Entidades
{
    public delegate void InformarDelegado(int fecha);
    public class Torneo
    {
        private string nombre;
        List<Equipo> equipos;
        private int fechaActual;
        private int cantidadDeFechas;
        private int capacidadMaxima;

        public event InformarDelegado eventoInformar;

        #region Constructores

        public Torneo()
        {
            this.equipos = new List<Equipo>();
        }

        /// <summary>
        /// Un constructor que nos permite inicializar la lista de equipos, y asignar un valor a los atributos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cantidadDeFechas"></param>
        /// <param name="capacidadMaxima"></param>
        public Torneo(string nombre, int cantidadDeFechas, int capacidadMaxima) : this()
        {
            this.nombre = nombre;
            
            this.fechaActual = 0;
            this.cantidadDeFechas = cantidadDeFechas;
            this.capacidadMaxima = capacidadMaxima;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que nos permite obtener y setear la lista de equipos
        /// </summary>
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

        /// <summary>
        /// Propiedad que nos permite obtener y setear el atributo nombre
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
        /// Propiedad que nos permite obtener y setear el atributo fechaActual
        /// </summary>
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

        /// <summary>
        /// Propiedad que nos permite obtener y setear el atributo cantidadDeFechas
        /// </summary>
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

        /// <summary>
        /// Propiedad que nos permite obtener y setear el atributo capacidadMaxima
        /// </summary>
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
        public void OrdenarEquipos()
        {
            Equipo aux;
            for(int i = 0; i < this.Equipos.Count - 1; i++)
            {
                for(int j = i + 1; j < this.Equipos.Count; j++)
                {
                    if(this.Equipos[j] > this.Equipos[i] == 1)
                    {
                        aux = this.Equipos[i];
                        this.Equipos[i] = this.Equipos[j];
                        this.Equipos[j] = aux;
                    }
                }
            }
        }

        /// <summary>
        /// Este metodo recibe un string para buscar en el atributo nombre de un equipo recorriendo de la lista de equipos
        /// en caso que el nombre del equipo coinsida con el parametro, retorna la ubicacion del equipo de la lista, en caso
        /// contrario retorna -1
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Reccore la lista de equipos y los muestra utilizando la sobrecarga ToString de equipos, retorna la lista entera en un string
        /// </summary>
        /// <returns></returns>
        public string MostrarEquipos()
        {
            StringBuilder sb = new StringBuilder();
            
            foreach(Equipo aux in this.Equipos)
            {
                sb.AppendFormat("{0}\n", aux.ToString());
            }

            return sb.ToString();
            
        }

        /// <summary>
        /// Avanza una fecha del torneo aumentando en 1 la fechaActual y agregandole golesEnContra, GolesAFavor, victoria, derrota o empate
        /// a cada equipo, retorna true si es posible avanzar o false en caso contrario
        /// </summary>
        /// <returns></returns>
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

        public bool AvanzarHasta(int fechaAvanzar, CancellationToken token)
        {
            do
            {
                if(this.AvanzarTorneo())
                {
                    if (eventoInformar != null)
                    {
                        this.eventoInformar.Invoke(this.FechaActual);
                    }
                }else
                {
                    return false;
                }
                Thread.Sleep(500);
            } while (fechaAvanzar != this.FechaActual && !token.IsCancellationRequested);
            return true;
        }

        /// <summary>
        /// Setea la fechaActual a 0 y todos los atributos de los equipos de la lista equipos a 0, manteniendo solo el nombre del equipo
        /// </summary>
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
        

        /// <summary>
        /// Sobreecarga el metodo ToString para mostrar el nombre, cantidad de equipos, fecha actual y cantidad de fechas de torneo
        /// ademas recorre la lista de equipos para mostrarlos con la sobreecarga de su metodo ToString, retorna la lista en un string
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Agrega un equipo al torneo, si es que este no esta en el torneo, retorna true si lo pudo agregar o false en caso contrario
        /// </summary>
        /// <param name="t"></param>
        /// <param name="e"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Quita un equipo del torneo, en caso de que este se encuentre. Retorna true si pudo o false en caso contrario
        /// </summary>
        /// <param name="t"></param>
        /// <param name="e"></param>
        /// <returns></returns>
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
