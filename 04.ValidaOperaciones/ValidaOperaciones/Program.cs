using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaOperaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.MaxValue;
            //Console.WriteLine(numero++);

            checked
            {
                //numero++;
                try
                {
                    numero++;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            //numero = checked(numero++);
            //numero = unchecked(numero++);
            // Console.WriteLine(numero);

            try
            {

                Console.WriteLine("Digite un numero para el Mes:");
                int numeroMes = int.Parse(Console.ReadLine());
                Console.WriteLine(ValidaMes(numeroMes));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                //sirve para liberar recursos o finalizar conexiones a base de datos etc..
                Console.WriteLine("Bloque Finally");
            }


            Console.ReadLine();
        }


        static string ValidaMes(int numeroMes)
        {
            string mesIngresado = string.Empty;

            switch (numeroMes)
            {
                case 1:
                    mesIngresado = "Enero";
                    break;
                case 2:
                    mesIngresado = "Febrero";
                    break;
                case 3:
                    mesIngresado = "Marzo";
                    break;
                case 4:
                    mesIngresado = "Abril";
                    break;
                default:

                    throw new InvalidOperationException("Mes no registrado!.");
            }

            return mesIngresado;
        }
    }
}
