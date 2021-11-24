using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public delegate void InformarPartido(int r1, int r2, int minutos);

    public static class Partido
    {
        public static event InformarPartido eventoPartido;

        public static void JugarPartido(Equipo e1, Equipo e2, CancellationToken cancelToken)
        {
            Random random = new Random();
            
            int resultadoE1 = 0;
            int resultadoE2 = 0;
            float probabilidadE1 = 0;
            float probabilidadE2 = 0;
            int probabilidadGol = 0;
            int partidoTotales = e1.PartidosJugados + e2.PartidosJugados;

            for (int minutos = 0; minutos < 91; minutos++)
            {
                probabilidadGol = random.Next(0, 30);
                if (probabilidadGol == 1)
                {
                    int factorSuerte1 = random.Next(0, 100);
                    int factorSuerte2 = random.Next(0, 100);

                    probabilidadE1 = probabilidadE1.MiPromedio((float)e1.Ganados, (float)partidoTotales, 100) + factorSuerte1;
                    probabilidadE2 = probabilidadE1.MiPromedio((float)e2.Ganados, (float)partidoTotales, 100) + factorSuerte2;

                    if (probabilidadE1 > probabilidadE2)
                    {
                        resultadoE1++;
                    }
                    else
                    {
                        resultadoE2++;
                    }
                }

                Partido.eventoPartido.Invoke(resultadoE1, resultadoE2, minutos);
                if (minutos == 45)
                {
                    Thread.Sleep(2000);
                }
                else
                {
                    Thread.Sleep(100);
                }

                if(cancelToken.IsCancellationRequested)
                {
                    break;
                }
            }
        }

    }
}
