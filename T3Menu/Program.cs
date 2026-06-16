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
         static void Mostrar()
        {
            Console.WriteLine("------LISTA DE LOS PRODUCTOS------"); 

            for (int i = 0 ; i < cantidad ; i++ )
            {
                Console.WriteLine(" codigo:" + codigos[i]); 
                Console.WriteLine(" nombre:" + nombres[i]); 
                Console.WriteLine(" precio: $/ " + precios[i]); 
                Console.WriteLine(" stock:" + stock[i]);
            }
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
            static void Insertar()
            {
                  if (cantidad == codigos.Length)
                     {
                       Console.WriteLine(" no hay suficiente espacio para mas productos ");
                      return;
                     }
                 Console.WriteLine(" INgrese la posicion a insertar ( o a " + cantidad + "):");
                int posicion = int.Parse(Console.ReadLine());

               if (posicion < 0 || posicion > cantidad)
                  {
                    Console.WriteLine(" ERROR posicion no valida ");
                    return;
                  }
                for (int i = cantidad; i > posicion; i--)
                   {
                     codigos[i] = codigos[i - 1];
                     nombres[i] = nombres[i - 1];
                     precios[i] = precios[i - 1];
                     stock[i] = stock[i - 1];
                    }
                    Console.WriteLine(" CODIGOS ");
                    codigos[posicion] = Console.ReadLine();
                    Console.WriteLine(" nombres");
                    nombres[posicion] = Console.ReadLine();
                    Console.WriteLine("precios");
                    precios[posicion] = double.Parse(Console.ReadLine());
                    Console.WriteLine(" stock ");
                    stock[posicion] = int.Parse(Console.ReadLine());
                    cantidad++;

               Console.WriteLine("EL PRODUCTO SE INSERTO CORRECTAMENTE");
 
                
            }
            static void Eliminar()
        {
            Console.WriteLine(" ingrese le codigo del prducto que desea eliminar:"); 
            string codigoaeliminar = Console.ReadLine(); 

            for ( int i = 0 ; i < cantidad ; i++)
            {
                if (codigos[i] == codigoaeliminar)
                {
                    for (int j = i ; j < cantidad - 1 ; j++ )
                    {
                        codigos[j] = codigos[j+ 1 ]; 
                        nombres[j] = nombres[j + 1 ];
                        precios[j] = precios[j + 1 ];
                        stock[j] = stock[j + 1 ]; 
                    }
                    cantidad--;

                    Console.WriteLine(" El producto se a eliminado correctamente "); 
                    return; 
                }
            }
            Console.WriteLine(" el producto no se encontro"); 
            
        } 
            static void Ordenar()
        {
            for( int i = 0; i <cantidad  - 1; i++)
            {
                for (int j = 0 ; j < cantidad - 1 - i ; j++)
                {
                    if ( precios[j] < precios[j + 1 ])
                    {
                        double tprecios = precios[j]; 
                        precios[j] = precios[j + 1 ]; 
                        precios [j + 1 ] = tprecios; 

                        string tcodigos = codigos[j];
                        codigos[j] = codigos[j+ 1 ]; 
                        codigos[j + 1] = tcodigos; 

                        string tnombres = nombres [j]; 
                        nombres[j] = nombres[j +1]; 
                        nombres[j +1] = tnombres; 

                        int tstock = stock [j]; 
                        stock[j] = stock[j +1]; 
                        stock[j+ 1 ] = tstock ;
  
                    }
                    
                }
            }
            Console.WriteLine(" los productos fueron ordenados por precio de mayor a menor "); 

        } 
             static void Resumen()
        {
            if (cantidad == 0 )
            {
                Console.WriteLine(" No  existe el producto en la bodega "); 
                return; 
            }
            int mayor = 0 ; 
            int menor = 0 ;
            double total = 0 ; 

            for ( int i = 0 ; i < cantidad ; i ++ )
            {
                total += precios[i] ; 
                if ( precios[i] > precios[mayor])
                {
                    mayor = i ; 
                }
                else if ( precios[i] < precios[menor])
                {
                    menor = i; 
                }

            }
            Console.WriteLine("-----RESUMEN DE LA BODEGA-------"); 
            Console.WriteLine("total de productos :" + cantidad ); 
            Console.WriteLine(" producto con mayor precio: " + nombres[mayor]); 
            Console.WriteLine(" producto con menos precio:"+ nombres[menor]); 
            Console.WriteLine(" total de precios: s/ " + total); 
        } 

    }

}
        // Declaramos que el presente trabajo fue desarrollado por los integrantes del equipo, sin generación de código, informe o solución mediante herramientas de inteligencia artificial generativa.
       //El historial de GitHub refleja nuestro proceso de trabajo y participación.

