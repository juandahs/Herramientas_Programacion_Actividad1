/*

 * En una llantera se ha establecido una promoción de las llantas marca Ponchadas, dicha
 * promoción consiste en lo siguiente: Si se compran menos de cinco llantas el precio es de
 * $300 cada una, de $250 si se compran de 5 a 10 y de $200 si se compran más de 10. Obtener
 * la cantidad de dinero que una persona tiene que pagar por cada una de las llantas que compra
 * y la que tiene que pagar por el total de la compra. 
 
 */

namespace Actidad1;

public class Llantera
{
    public Llantera()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("Bienvenido a la llantera del SENA");
        Console.WriteLine("*********************************\n");

        Console.WriteLine("Ingrese el número de llantas 'Ponchadas' a comprar");

        //Se controla error de la conversión entrada por el usuario.
        if (!int.TryParse(Console.ReadLine(), out int cantidadLlantas))
            cantidadLlantas = 0;

        //Se valida la cantidad ingresada
        if (cantidadLlantas == 0)
        {
            Program.MostrarError("La cantidad de llantas no es válida.");
            return;
        }

        
        //Menos de 5 llantas
        if (cantidadLlantas < 5)
        {
            int valorUndLlanta = 300;
            Console.WriteLine($"El valor unitario de la llanta es de {valorUndLlanta}");
            Console.WriteLine($"El valor total para {cantidadLlantas} es de {valorUndLlanta * cantidadLlantas}");
            return;
        }
        

        //Entre 5 y menos de 10 llantas
        if (cantidadLlantas >= 5 && cantidadLlantas < 10)
        {
            int valorUndLlanta = 250;
            Console.WriteLine($"El valor unitario de la llanta es de {valorUndLlanta}");
            Console.WriteLine($"El valor total para {cantidadLlantas} es de {valorUndLlanta * cantidadLlantas}");
            return;
        }

        //Más de 10 llantas
        if (cantidadLlantas > 10)
        {
            int valorUndLlanta = 200;
            Console.WriteLine($"El valor unitario de la llanta es de {valorUndLlanta}");
            Console.WriteLine($"El valor total para {cantidadLlantas} es de {valorUndLlanta * cantidadLlantas}");
            return;
        }

    }
}

