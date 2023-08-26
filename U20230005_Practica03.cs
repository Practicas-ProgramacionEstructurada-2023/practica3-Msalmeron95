using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaracion de variables.
            string? Marca_Zapato;
            string? Color_Zapato;
            int cantidad;
            double precio;

            //Capturando datos.
            Console.WriteLine("\n------------------- Capturando Variables -------------------\n");
            Console.WriteLine("Ingrese la marca del Zapato a comprar:\n ");
            Marca_Zapato = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese el color del Zapato a comprar:\n ");
            Color_Zapato = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de Zapatos a comprar:\n ");
            cantidad = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Ingrese el precio del par Zapato:\n ");
            precio = Convert.ToDouble(Console.ReadLine());

            //


        }
    }
}