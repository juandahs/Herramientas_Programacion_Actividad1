/*
 * 
 * En una fábrica de computadoras se planea ofrecer a los clientes un descuento que
 * dependerá del número de computadoras que compre. Si las computadoras son menos de
 * cinco se les dará un 10% de descuento sobre el total de la compra; si el número de
 * computadoras es mayor o igual a cinco, pero menos de diez se le otorga un 20% de
 * descuento; y si son 10 o más se les da un 40% de descuento. El precio de cada computadora
 * es de $11,000. 
 * 
 */

namespace Actidad1;

public class FabricaComputadoras
{
    public FabricaComputadoras()
    {
        Console.WriteLine("***************************************");
        Console.WriteLine("Bienvenido a la fabrica de computadores");
        Console.WriteLine("***************************************\n");

        Console.WriteLine("Ingrese el número de computadoras a comprar");
        
        //Se controla error de la conversión entrada por el usuario.
        if (!int.TryParse(Console.ReadLine(), out int cantidadComputadores))
            cantidadComputadores = 0;

        //Se valida la cantidad ingresada
        if (cantidadComputadores == 0)
        {
            Program.MostrarError("La cantidad ingresada de computadores no es válido.");
            return;
        }

        //Se establece el valor de los computadores
        const double valorComputador = 11000;

        //Descuento del 10
        if (cantidadComputadores < 5)
        {
            Console.WriteLine($"El valor total para {cantidadComputadores} es de {valorComputador - (valorComputador * 0.10)}");
            return;
        }

        //Descuento del 20
        if (cantidadComputadores >= 5 && cantidadComputadores < 10)
        {
            Console.WriteLine($"El valor total para {cantidadComputadores} es de {valorComputador - (valorComputador * 0.20)}");
            return;
        }
        //Descuento del 40
        if (cantidadComputadores > 10)
        {
            Console.WriteLine($"El valor total para {cantidadComputadores} es de {valorComputador - (valorComputador * 0.40)}");
            return;
        }

    }
}

