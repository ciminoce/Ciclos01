using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos01
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeroGenerado = 0;
            Random r = new Random();//Objeto para generar números al azar
            var sumaDeNumeros = 0;
            //var contadorDeNumeros = 0;
            //while (contadorDeNumeros < 5)
            //{
            //    numeroGenerado = r.Next(1, 11);//Método del objeto Random para generar un nro entre 1 y 10
            //    Console.WriteLine($"{contadorDeNumeros + 1}º Número generado={numeroGenerado}");
            //    sumaDeNumeros += numeroGenerado;//Equivalente a sumaDeNumeros=SumaDeNumeros+numeroGenerado
            //    contadorDeNumeros++;//Equivalente a contadorDeNumeros=contadorDeNumeros+1
            //}
            //do
            //{
            //    numeroGenerado = r.Next(1, 11);//Método del objeto Random para generar un nro entre 1 y 10
            //    Console.WriteLine($"{contadorDeNumeros + 1}º Número generado={numeroGenerado}");
            //    sumaDeNumeros += numeroGenerado;//Equivalente a sumaDeNumeros=SumaDeNumeros+numeroGenerado
            //    contadorDeNumeros++;//Equivalente a contadorDeNumeros=contadorDeNumeros+1

            //} while (contadorDeNumeros < 5);

            //Generar numeros hasta que la suma sea superior a 50
            //do
            //{
            //    numeroGenerado = r.Next(1, 11);//Método del objeto Random para generar un nro entre 1 y 10
            //    Console.WriteLine($"{contadorDeNumeros + 1}º Número generado={numeroGenerado}");
            //    sumaDeNumeros += numeroGenerado;//Equivalente a sumaDeNumeros=SumaDeNumeros+numeroGenerado
            //    contadorDeNumeros++;//Equivalente a contadorDeNumeros=contadorDeNumeros+1

            //} while (sumaDeNumeros<=50);
            for (int contadorDeNumeros = 0; contadorDeNumeros <= 5; contadorDeNumeros++)
            {
                numeroGenerado = r.Next(1, 11);//Método del objeto Random para generar un nro entre 1 y 10
                Console.WriteLine($"{contadorDeNumeros + 1}º Número generado={numeroGenerado}");
                sumaDeNumeros += numeroGenerado;//Equivalente a sumaDeNumeros=SumaDeNumeros+numeroGenerado

            }
            Console.WriteLine($"La suma de los números generados es {sumaDeNumeros}");
            Console.ReadLine();
        }
    }
}
