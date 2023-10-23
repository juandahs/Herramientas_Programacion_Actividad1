using Actividad1;

namespace Actidad1;

public static class Program
{
    public static void Main()
    {
        Menu();
    }

    private static void Menu()
    {
        //Siempre que inicia el menú se limpia la pantalla.
        Console.Clear();

        //Mensaje de bienvenida
        Console.WriteLine("***********************************");
        Console.WriteLine("Bienvenido a  la actividad numero 1");
        Console.WriteLine("***********************************");
        
        int opcion = 0;
        while (opcion == 0)
        {
            //Se muestran las opciones.
            Console.WriteLine("1. Fabrica de computadoras.");
            Console.WriteLine("2. Llantera.");
            Console.WriteLine("3. Juego de preguntas.");
            Console.WriteLine("4. Proveedor de equipos de sonidos.");
            Console.WriteLine("5. Fruteria.");
            Console.WriteLine("6. Numero medio.\n");

            Console.WriteLine("Ingrese el numero del ejercicio que desea ejecutar o presione 0 para salir");
            
            //Se controla error de la conversión entrada por el usuario.
            if (!int.TryParse(Console.ReadLine(), out opcion))
                opcion = 99;

            switch (opcion)
            {
                //La opción 0 es para salir.
                case 0:
                    Console.WriteLine("Muchas gracias por usar nuestros servicios");
                    Environment.Exit(0);
                    break;
                case 1:
                    //Se limpia la pantalla
                    Console.Clear();
                    //Se inicia el ejercicio uno
                    _ = new FabricaComputadoras();            
                    break;
                case 2:
                    //Se limpia la pantalla
                    Console.Clear();
                    //Se inicia el ejercicio dos
                    _ = new Llantera();
                    break;
                case 3:
                    //Se limpia la pantalla
                    Console.Clear();
                    //Se inicia el ejercicio dos
                    _ = new JuegoPreguntas();
                    break;
                case 4:
                    //Se limpia la pantalla
                    Console.Clear();
                    //Se inicia el ejercicio dos
                    _ = new EquiposSonido();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    MostrarError("La opción ingresada no es permida.");
                    Menu();
                    break;
            }
            
            //Siempre que termine de hacer un ejercicio se redirije al menú.
            Console.WriteLine("Presione una tecla para volver al menú principal.");
            Console.ReadLine();
            Menu();
        }
    }


    public static void MostrarError(string mensaje) 
    {
        //Se limpia la pantalla
        Console.Clear();
        //Se muestra mensaje de error.
        Console.WriteLine("*****************************************************");
        Console.WriteLine("**********             ¡ERROR!            ***********");
        Console.WriteLine("*****************************************************");

        Console.WriteLine(mensaje);
        Console.WriteLine("Precione una tecla para volver al menu, e intente nuevamente.");
        //Se espera a que el usario interacture;
        Console.ReadLine();
    }
}
