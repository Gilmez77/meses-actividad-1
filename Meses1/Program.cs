using System;

namespace Meses1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mes = {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio",
            "Agosto","Septiembre","Octubre","Noviembre","Diciembre"};

            Console.WriteLine("Escrib Numero de Mez:");
            int numeroMes = 0;
            bool esEntero = Int32.TryParse(Console.ReadLine(), out numeroMes);

            if (numeroMes < 1 || numeroMes > 12)
            {
                try
                {
                    for (int i = 0; i < 13; i++)
                    {
                        Console.WriteLine(mes[i]);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Vuelva a Intentar, no introdujo numero de mes");
                }

            }

            else
            {
                Console.WriteLine("El Mes Seleccionado es:" + mes[numeroMes - 1]);
            }
            //Gilberto
        }
    }
}
