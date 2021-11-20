using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class GestorBaseDeDatos<T> where T : Torneo
    {

        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;


        public GestorBaseDeDatos(string stringConnection)
        {
            this.sqlConnection = new SqlConnection(stringConnection);
            this.sqlCommand = new SqlCommand();
            this.sqlCommand.Connection = sqlConnection;
            this.sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        public T Leer()
        {
            try
            {
                Torneo nuevoTorneo = new Torneo();
                this.sqlCommand.CommandText = "SELECT * FROM tablaEquipos";
                this.sqlConnection.Open();
                SqlDataReader dataReader = this.sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Equipo nuevoEquipo = new Equipo();

                    nuevoEquipo.Nombre = dataReader["nombre"].ToString();
                    nuevoEquipo.Ganados = (int)dataReader["ganados"];
                    nuevoEquipo.Empatados = (int)dataReader["empatados"];
                    nuevoEquipo.Perdidos = (int)dataReader["perdidos"];
                    nuevoEquipo.GolesAFavor = (int)dataReader["golesafavor"];
                    nuevoEquipo.GolesEnContra = (int)dataReader["golesencontra"];
                    nuevoTorneo.CantidadDeFechas = (int)dataReader["fechasmaximas"];
                    nuevoTorneo.FechaActual = nuevoEquipo.PartidosJugados;
                    nuevoTorneo.Nombre = dataReader["nombretorneo"].ToString();
                    nuevoTorneo.CapacidadMaxima = (int)dataReader["capacidadMaxima"];
                    nuevoTorneo.Equipos.Add(nuevoEquipo);
                }
                sqlConnection.Close();
                return (T)nuevoTorneo;
            }
            catch(Exception ex)
            {
                throw new ExceptionSQL("Error al leer la base de datos", ex);
            }
        }

        public bool Guardar(T torneo)
        {

            try
            {
                sqlConnection.Open();
                this.sqlCommand.CommandText = "Delete from tablaEquipos";
                this.sqlCommand.ExecuteNonQuery();


                this.sqlCommand.CommandText = "INSERT INTO tablaEquipos " +
                    "(nombre, ganados, empatados, perdidos, golesafavor, golesencontra, fechasmaximas, nombretorneo, capacidadMaxima) " +
                    "VALUES (@nombre, @ganados, @empatados, @perdidos, @golesafavor, @golesencontra, @fechasmaximas, @nombretorneo, @capacidadMaxima)";
                Torneo nuevoTorneo = torneo;

                foreach (Equipo aux in nuevoTorneo.Equipos)
                {
                    this.sqlCommand.Parameters.AddWithValue("nombre", aux.Nombre);
                    this.sqlCommand.Parameters.AddWithValue("ganados", aux.Ganados);
                    this.sqlCommand.Parameters.AddWithValue("empatados", aux.Empatados);
                    this.sqlCommand.Parameters.AddWithValue("perdidos", aux.Perdidos);
                    this.sqlCommand.Parameters.AddWithValue("golesafavor", aux.GolesAFavor);
                    this.sqlCommand.Parameters.AddWithValue("golesencontra", aux.GolesEnContra);
                    this.sqlCommand.Parameters.AddWithValue("fechasmaximas", torneo.CantidadDeFechas);
                    this.sqlCommand.Parameters.AddWithValue("nombretorneo", torneo.Nombre);
                    this.sqlCommand.Parameters.AddWithValue("capacidadMaxima", torneo.CapacidadMaxima);
                    this.sqlCommand.ExecuteNonQuery();
                    this.sqlCommand.Parameters.Clear();
                }

                sqlConnection.Close();

                return true;
            }
            catch(Exception ex)
            {
                throw new ExceptionSQL("Error al guardar en la base de datos", ex);
            }
        }
    }
}
