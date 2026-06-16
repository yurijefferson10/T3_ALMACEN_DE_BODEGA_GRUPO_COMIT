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
        static void Registrar()
        {
            if ( cantidad == codigos.Length)
            {
                Console.WriteLine(" no hay suficiente espacio para mas productos"); 
                return; 
            }
            Console.WriteLine("Codigo del producto: "); 

            codigos[cantidad] = Console.ReadLine();
            if ( codigos[cantidad]== "")
            {
                Console.WriteLine(" El codigo no puede ser vacio, agregar ubn valor" ); 
                return ; 
            }

            Console.WriteLine("Nombre del producto: ");
            nombres[cantidad] = Console.ReadLine();

            Console.WriteLine("Precio del producto: "); 
            precios[cantidad] = double.Parse(Console.ReadLine()); 
            if (precios[cantidad]< 0 )
            {
                Console.WriteLine( " el preccio no tiene que ser negativo "); 
                return ; 
            }

            Console.WriteLine("Stock del producto: ");
            stock[cantidad] = int.Parse(Console.ReadLine()); 
            
            if ( stock[cantidad] < 0 )
            {
                Console.WriteLine(" el stock no puede ser negativo "); 
                return;
            }
            cantidad++; 

            Console.WriteLine(" El producto se ha registrado correctamente:" ) ; 
                    
        }
        static void Buscar()
        {
            Console.WriteLine("INGRESAR EL CODIGO DEL PRODUCTO QUE BUSCAS "); 
            string codigoaBuscar= Console.ReadLine();
            bool producto_encontrado = false ; 

            for ( int i = 0 ; i < cantidad ; i++)
                {
                if ( codigos[i] == codigoaBuscar)
                {
                   Console.WriteLine(" producto encotnrado:" ); 
                   Console.WriteLine("nombre: " + nombres[i] );
                   Console.WriteLine("precios:$/" + precios[i]); 
                   Console.WriteLine("stock:" + stock[i] ); 
                   producto_encontrado =true ; 
                }
                if (!producto_encontrado)
            {
                Console.WriteLine(" El producto que busca no se encuentra  en la bodega");
            }    
        }
        static void modificar()
             {
            Console.WriteLine(" ingrese el codigo del producto:"); 
            string codigoamodificar = Console.ReadLine(); 

            for( int i = 0 ; i < cantidad; i++)
            {
                if(codigos[i]==codigoamodificar)
                 {
                    Console.WriteLine(" Nuevo nombre para el producto: "); 
                    nombres[i] = Console.ReadLine(); 

                    Console.WriteLine(" Nuevo precio del producto"); 
                    precios[i] = double.Parse(Console.ReadLine()); 

                    Console.WriteLine(" Nuevo tock en tienda"); 
                    stock [i] = int.Parse(Console.ReadLine()); 

                    Console.WriteLine(" producto modifcado correctamente "); 
                    return;     
                }
            }
             Console.WriteLine(" producto no encontrado"); 
            
                    
            

        
        
    }
}
