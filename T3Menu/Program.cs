using System;
using System.Diagnostics.Contracts;
using System.Net.Mime;

namespace T3

{

    class Program

    {

            static string [] codigos = new string [8]; 
            static string [] nombres = new string [8]; 
            static double [] precios = new double [8]; 
            static int [] stock = new int [8]; 

            static int cantidad = 0 ;
            static void Main (string[] args)

        {
            int opcion; 
            do
            {
                Console.WriteLine("------MENU BODEGA------"); 
                Console.WriteLine("1. Registrar el  producto"); 
                Console.WriteLine("2. Mostrar el  productos");
                Console.WriteLine("3. Buscar el producto"); 
                Console.WriteLine("4. modificar el producto"); 
                Console.WriteLine("5. insertar producto"); 
                Console.WriteLine("6.Eliminar producto"); 
                Console.WriteLine("7. orden  por precio ");
                Console.WriteLine("8. Resumen ");
                Console.WriteLine("9. Salir");
                Console.WriteLine("Ingrese una opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: 
                    Registrar(); 
                    break; 
                    case 2:
                    Mostrar();
                    break;
                    case 3:
                    Buscar();
                    break; 
                    case 4: 
                    modificar (); 
                    break; 
                    case 5: 
                    Insertar();
                    break; 
                    case 6:
                    Eliminar();
                    break;
                    case 7:
                    Ordenar();
                    break;
                    case 8:
                    Resumen();
                    break;
                }
            }
             while (opcion != 9);
        }
    }
}