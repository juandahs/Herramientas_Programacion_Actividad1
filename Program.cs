namespace Actidad1;

public static class Program
{
    public static void Main()
    {
        Menu();
    }

    public static void Menu()
    {
        Console.WriteLine("***********************************");
        Console.WriteLine("Bienvenido a  la actividad numero 1");
        Console.WriteLine("***********************************");

        int opcion = 0;

        while (opcion == 0)
        {

            Console.WriteLine("1. Fabrica.de computadoras ");
            Console.WriteLine("2. Llantera.");
            Console.WriteLine("3. Juego de preguntas.");
            Console.WriteLine("4. Proveedor de equipos de sonidos.");
            Console.WriteLine("5. Fruteria.");
            Console.WriteLine("6. Numero medio.");
            Console.WriteLine("Ingrese el numero del ejercicio que desea ejecutar o presione 0 para salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    //Se limpia la pantallaxaa
                    Console.Clear();
                    //Se inicia el ejercicio uno
                    FabricaComputadoras fabricaComputadoras = new FabricaComputadoras();

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    opcion = Convert.ToInt32(Console.ReadLine());
                    break;


            }



        }

    }

}
