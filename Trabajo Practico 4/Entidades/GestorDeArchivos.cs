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
    public class GestorDeArchivos : IArchivos<Torneo>
    {
        /// <summary>
        /// Este metodo es una implementacion de la interfaz IArchivos y nos permite abrir un archivo en formato JSON,
        /// retorna un torneo nuevo con los equipos que se leeyeron del archivo
        /// </summary>
        /// <param name="path"></param>
        /// <param name="torneo"></param>
        /// <returns></returns>
        public Torneo AbrirJSON(string path)
        {
            string archivoTXT = String.Empty;
            try
            {
                StreamReader archivo = new StreamReader(path);
                Torneo nuevoTorneo = new Torneo();
                archivoTXT = archivo.ReadToEnd();
                nuevoTorneo = JsonSerializer.Deserialize<Torneo>(archivoTXT);
                archivo.Close();
                return nuevoTorneo;
            }
            catch (FileNotFoundException)
            {
                throw new ExceptionJson("Archivo no encontrado", "AbrirJson", "Torneo");
            }
            catch (OutOfMemoryException)
            {
                throw new ExceptionJson("Error al abrir el archivo, memoria insuficiente", "AbrirJson", "Torneo");
            }
            catch (IOException)
            {
                throw new ExceptionJson("Archivo al abrir el archivo", "AbrirJson", "Torneo");
            }
            catch (JsonException)
            {
                throw new ExceptionJson("Error en el archivo Json", "AbrirJson", "Torneo");
            }

            
        }

        /// <summary>
        /// Este metodo es una implementacion de la interfaz IArchivos y nos permite abrir un archivo en formato txt,
        /// retorna un torneo nuevo con los equipos que se leeyeron del archivo
        /// </summary>
        /// <param name="path"></param>
        /// <param name="torneo"></param>
        /// <returns></returns>
        public Torneo AbrirTxt(string path)
        {
            int fechaActual;
            int fechaMaxima;
            int capacidadMaxima;
            int ganados;
            int empatados;
            int perdidos;
            int golesAFavor;
            int golesEnContra;
            bool aux;
            string linea = String.Empty;
            try
            {
                StreamReader archivo = new StreamReader(path);
                Torneo nuevoTorneo = new Torneo();
                
                //Lee la primer linea que es el nombre de las filas del torneo
                archivo.ReadLine();
                linea = archivo.ReadLine();
                string[] torneo = linea.Split(',');
                nuevoTorneo.Nombre = torneo[0];
                
                if (int.TryParse(torneo[1], out fechaActual) &&
                   int.TryParse(torneo[2], out fechaMaxima) &&
                   int.TryParse(torneo[3], out capacidadMaxima))
                {
                    nuevoTorneo.FechaActual = fechaActual;
                    nuevoTorneo.CantidadDeFechas = fechaMaxima;
                    nuevoTorneo.CapacidadMaxima = capacidadMaxima;
                }
                else
                {
                    throw new ExceptionTxt("Error al abrir el archivo, archivo modificado", "AbrirTxt", "GestorDeArchivos");
                }


                //Lee la linea de los nombres de las filas de equipo
                archivo.ReadLine();
                linea = archivo.ReadLine();
                
                while (!String.IsNullOrEmpty(linea))
                {
                    Equipo nuevoEquipo = new Equipo();

                    string[] equipo = linea.Split(',');
                    if (int.TryParse(equipo[2], out ganados) && int.TryParse(equipo[3], out empatados) &&
                       int.TryParse(equipo[4], out perdidos) && int.TryParse(equipo[5], out golesAFavor) &&
                       int.TryParse(equipo[6], out golesEnContra))
                    {
                        nuevoEquipo.Nombre = equipo[0];
                        nuevoEquipo.Ganados = ganados;
                        nuevoEquipo.Empatados = empatados;
                        nuevoEquipo.Perdidos = perdidos;
                        nuevoEquipo.GolesAFavor = golesAFavor;
                        nuevoEquipo.GolesEnContra = golesEnContra;
                        aux = nuevoTorneo + nuevoEquipo;
                        linea = archivo.ReadLine();
                    }
                    else
                    {
                        throw new ExceptionTxt("Error al abrir el archivo, archivo modificado", "AbrirTxt", "Torneo");
                    }
                }

                archivo.Close();
                return nuevoTorneo;
            }
            catch (ArgumentException)
            {
                throw new ExceptionTxt("Error al pasar los parametros", "AbrirTxt", "Torneo");
            }
            catch (FileNotFoundException)
            {
                throw new ExceptionTxt("Archivo no encontrado", "AbrirTxt", "Torneo");
            }
            catch (IOException)
            {
                throw new ExceptionTxt("Archivo al abrir el archivo", "AbrirJson", "Torneo");
            }
            catch (OutOfMemoryException)
            {
                throw new ExceptionTxt("Error al abrir el archivo, memoria insuficiente", "AbrirTxt", "Torneo");
            }
            catch (IndexOutOfRangeException)
            {
                throw new ExceptionTxt("Error al abrir el archivo, verifique que el archivo sea correcto", "AbrirTxt", "Torneo");
            }
        }

        /// <summary>
        /// Este metodo es una implementacion de la interfaz IArchivos y nos permite abrir un archivo en formato XML,
        /// retorna un torneo nuevo con los equipos que se leeyeron del archivo
        /// </summary>
        /// <param name="path"></param>
        /// <param name="torneo"></param>
        /// <returns></returns>
        public Torneo AbrirXML(string path)
        {
            try
            {
                XmlTextReader archivo = new XmlTextReader(path);
                XmlSerializer ser = new XmlSerializer(typeof(Torneo));
                Torneo nuevoTorneo = new Torneo();
                nuevoTorneo = (Torneo)ser.Deserialize(archivo);
                archivo.Close();
                return nuevoTorneo;
            }
            catch (FileNotFoundException)
            {
                throw new ExceptionXml("Archivo no encontrado", "AbrirXml", "Torneo");
            }
            catch (DirectoryNotFoundException)
            {
                throw new ExceptionXml("Directorio no encontrado", "AbrirXml", "Torneo");
            }
            catch (UriFormatException)
            {
                throw new ExceptionXml("Error en el archivo xml", "AbrirXml", "Torneo");
            }
            catch (InvalidOperationException)
            {
                throw new ExceptionXml("Error al deserealizar el archivo xml", "AbrirXml", "Torneo");
            }
        }


        /// <summary>
        /// Este metodo es una implementacion de la interfaz IArchivos y nos permite guardar un archivo en formato JSON,
        /// retorna un bool, true si pudo guardar o false en caso contrario
        /// </summary>
        /// <param name="path"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        public bool GuardarJSON(string path, Torneo dato)
        {
            if (Path.GetExtension(path) == ".json")
            {
                try
                {
                    StreamWriter archivo = new StreamWriter(path);
                    if (archivo != null)
                    {
                        string jsonString = JsonSerializer.Serialize(dato);
                        archivo.WriteLine(jsonString);
                        archivo.Close();
                        return true;
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    throw new ExceptionJson("Error al guardar, no tienes acceso a esa ruta", "GuardarJSON", "Torneo");
                }

                catch (ArgumentNullException)
                {
                    throw new ExceptionJson("Error al guardar, no tienes acceso a esa ruta", "GuardarJSON", "Torneo");
                }
                catch (DirectoryNotFoundException)
                {
                    throw new ExceptionJson("Error al guardar", "GuardarJSON", "Torneo");
                }
                catch (PathTooLongException)
                {
                    throw new ExceptionJson("Error al guardar, ruta muy larga", "GuardarJSON", "Torneo");
                }
                catch (IOException)
                {
                    throw new ExceptionJson("Error al guardar", "GuardarJSON", "Torneo");
                }
                catch (NotSupportedException)
                {
                    throw new ExceptionJson("Error al serializar el archivo", "GuardarJSON", "Torneo");
                }
            }
            throw new ExceptionJson("Error al guardor, tipo de dato equivocado", "GuardarJSON", "Torneo");
        }

        /// <summary>
        /// Este metodo es una implementacion de la interfaz IArchivos y nos permite guardar un archivo en formato txt,
        /// retorna un bool, true si pudo guardar o false en caso contrario
        /// </summary>
        /// <param name="path"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        public bool GuardarTxt(string path, Torneo dato)
        {
            if (Path.GetExtension(path) == ".txt")
            {
                try
                {
                    StreamWriter archivo = new StreamWriter(path);
                    if (archivo != null)
                    {
                        archivo.WriteLine("Nombre Torneo Fecha Actual Fecha Maxima Cantidad de equipos maximos");
                        archivo.WriteLine(String.Format("{0},{1},{2},{3}",
                            dato.Nombre, 
                            dato.FechaActual, 
                            dato.CantidadDeFechas, 
                            dato.CapacidadMaxima));

                        archivo.WriteLine("Nombre PJ G E P GF GC DG Pts");
                        foreach (Equipo aux in dato.Equipos)
                        {
                            archivo.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                                aux.Nombre,
                                aux.PartidosJugados,
                                aux.Ganados,
                                aux.Empatados,
                                aux.Perdidos,
                                aux.GolesAFavor,
                                aux.GolesEnContra,
                                aux.Diferencia,
                                aux.Puntos));
                        }
                        archivo.Close();
                        return true;
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    throw new ExceptionTxt("Error al guardar, ruta no autorizada", "GuardarTxt", "Torneo");
                }
                catch (DirectoryNotFoundException)
                {
                    throw new ExceptionTxt("Error al guardar, ruta no encontrada", "GuardarTxt", "Torneo");
                }
                catch (PathTooLongException)
                {
                    throw new ExceptionTxt("Error al guardar, ruta muy larga", "GuardarTxt", "Torneo");
                }
                catch (IOException)
                {
                    throw new ExceptionTxt("Error al guardar", "GuardarTxt", "Torneo");
                }
            }
            throw new ExceptionTxt("Error al guardor, tipo de dato equivocado", "GuardarTxt", "Torneo");
        }

        /// <summary>
        /// Este metodo es una implementacion de la interfaz IArchivos y nos permite guardar un archivo en formato XML,
        /// retorna un bool, true si pudo guardar o false en caso contrario
        /// </summary>
        /// <param name="path"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        public bool GuardarXML(string path, Torneo dato)
        {
            if (Path.GetExtension(path) == ".xml")
            {
                try
                {
                    XmlTextWriter archivo = new XmlTextWriter(path, Encoding.UTF8);
                    XmlSerializer ser = new XmlSerializer(typeof(Torneo));
                    ser.Serialize(archivo, dato);
                    archivo.Close();
                    return true;
                }
                catch (UnauthorizedAccessException)
                {
                    throw new ExceptionXml("Error al guardar, no tienes acceso a esa ruta", "GuardarXML", "Torneo");
                }
                catch (DirectoryNotFoundException)
                {
                    throw new ExceptionXml("Error al guardar", "GuardarXML", "Torneo");
                }
                catch (IOException)
                {
                    throw new ExceptionXml("Error al guardar", "GuardarXML", "Torneo");
                }
                catch (InvalidOperationException)
                {
                    throw new ExceptionXml("Error al serializar el archivo", "GuardarXML", "Torneo");
                }
            }
            throw new ExceptionXml("Error al guardor, tipo de dato equivocado", "GuardarXml", "Torneo");
        }
    }
}
