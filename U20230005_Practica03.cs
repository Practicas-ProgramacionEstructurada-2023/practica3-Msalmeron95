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
            Console.WriteLine("\nIngrese la marca del Zapato a comprar: ");
            Marca_Zapato = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nIngrese el color del Zapato a comprar: ");
            Color_Zapato = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nIngrese la cantidad de Zapatos a comprar: ");
            cantidad = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nIngrese el precio del par Zapato: ");
            precio = Convert.ToDouble(Console.ReadLine());

            //Capturando el total a pagar.
            double Total = cantidad * precio;


        //Imprimiendo resultado
        Console.WriteLine("\n------------------- Imprimiendo resultados -------------------\n");
        Console.WriteLine("\n La marca de zapatos a comprar es: " + Marca_Zapato);
        Console.WriteLine("\n El color de los zapatos a comprar es: " + Color_Zapato);
        Console.WriteLine("\n La cantidad de zapatos a comprar es: " + cantidad);
        Console.WriteLine("\n El precio poar de zapatos a comprar es: " + precio);
        Console.WriteLine("\n El total a pagar es: " + "$" + Total);
        Console.WriteLine("\n------------------- Fin imprimiendo resultados -------------------\n");
        }
    }
}