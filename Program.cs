using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema04_Sem13
{
    internal class Program
    {
        private static int cantidadRespuestas;

        // Agrega esta función al código existente
        static void EliminarDato()
        {
            if (cantidadRespuestas == 0)
            {
                Console.WriteLine("No hay datos para eliminar.");
            }
            else
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Eliminar un dato");
                Console.WriteLine("===============================");

                MostrarDatosConIndice();

                Console.WriteLine("===============================");
                Console.Write("Ingrese la posición a eliminar: ");

                if (int.TryParse(Console.ReadLine(), out int posicion) && posicion >= 0 && posicion < cantidadRespuestas)
                {
                    EliminarEncuesta(posicion);
                    Console.WriteLine("\nDato eliminado con éxito.");
                }
                else
                {
                    Console.WriteLine("Posición no válida. Intente nuevamente.");
                }
            }

            Console.WriteLine("\nPresione una tecla para regresar ...");
            Console.ReadKey();
        }

        private static void EliminarEncuesta(int posicion)
        {
            throw new NotImplementedException();
        }

        // Agrega esta función al código existente
        static void MostrarDatosConIndice()
        {
            for (int i = 0; i < cantidadRespuestas; i++)
            {
                Console.Write($"{i:D3}:[{"respuestasEncuesta"[i]}]  ");
            }
            Console.WriteLine();
        }


    }
}
