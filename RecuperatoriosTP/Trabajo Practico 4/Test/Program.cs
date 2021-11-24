using System;
using Entidades;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo torneo = new Torneo("Primera Divison", 10, 2);

            Equipo e1 = new Equipo("River Plate", 2, 1, 1, 10, 3);
            Equipo e2 = new Equipo("Aldosivi", 1, 2, 1, 10, 5);
            Equipo e3 = new Equipo("Arsenal", 0, 0, 0, 0, 0);


            Console.WriteLine("Se intentan agregar 3 equipos en un torneo con maximo de 2 equipos");

            //Se agregan los equipo 
            Console.WriteLine("Se agregan los equipos || true si se pudo agregar o false si no");
            Console.WriteLine(torneo + e1);
            Console.WriteLine(torneo + e2);
            Console.WriteLine(torneo + e3);
            
            //Se muestra todo el torneo
            Console.WriteLine("\n" + torneo.ToString());
            
            Console.ReadKey();
            
            Console.Clear();



            #region Metodos y Operadores Clase Equipo
            //Retorna el nombre, partidos, puntos, goles a favor, goles en contra, y diferencia de goles por
            //la sobreescritura del metodo ToString
            Console.WriteLine("Se muestra la informacion solo de los equipos");
            Console.WriteLine(e1.ToString());
            Console.WriteLine(e2.ToString());

            //Retorna true porque el equipo 1 tiene mas puntos que el equipo 2
            Console.WriteLine("Se compara el equipo 1 con el equipo 2 || true es si tiene mas puntos false si tiene menos");
            Console.WriteLine(e1 > e2);
            Console.WriteLine();


            //Retorna false porque el equipo 1 tiene mas puntos que el equipo 2
            Console.WriteLine("Se compara el equipo 2 con el equipo 1 || true es si tiene mas puntos false si tiene menos");
            Console.WriteLine(e1 < e2);
            Console.WriteLine();

            //Retorna false porque el nombre de equipo no es igual
            Console.WriteLine("Se comprueba si son el mismo equipo || true si tienen el mismo nombre false si no");
            Console.WriteLine(e1 == e2);
            Console.WriteLine();

            //Retorna true porque el nombre de equipo no es igual
            Console.WriteLine("Se comprueba si no son el mismo equipo || true si tienen el mismo nombre false si no");
            Console.WriteLine(e1 != e2);
            Console.WriteLine();
            #endregion 

            Console.ReadKey();
        }
    }
}
