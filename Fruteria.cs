// Una frutería ofrece las manzanas con descuento según la   siguiente tabla: 
// 0-2          0%
// 2.01 -5      10%
//5.01 - 10     15%
// 10.01 >      20%



namespace Actividad1
{
    internal class Fruteria
    {       

        public Fruteria()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("     Bienvenido La fruteria   ");
            Console.WriteLine("******************************\n");

            Console.WriteLine("Tenemos SUPER DESCUENTOS en todas nuestras manzanas.");            
            
            Console.WriteLine("¿Cuantos kilos desea llevar");

            //Se valida que el dato sea ingresado correctamente
            if(!decimal.TryParse(Console.ReadLine(), out decimal kilos))
                kilos = 0;

            if (kilos <= 0)
            {
                Console.WriteLine("Cantidad invalida.");
                return;
            }
            
            //Se declara el valor del kilo para poder realizar calculos.
            //El ejercicio no plantea como hacerlo así que opte esta opción ya que mi fruteria es un autoservicio.
            const decimal valorKiloManzana = 2600;
            decimal total = kilos * valorKiloManzana; ;
            decimal descuento = 0;

            //Se calculan los descuentos
            if (kilos >2.01M && kilos <= 5) 
                descuento = total * 0.10M;            

            if (kilos > 5.01M && kilos <= 10) 
                descuento = total * 0.15M;                

            if (kilos > 10)
                descuento = total * 0.20M;                          

            //Se imprime la factura
            ImprimirFactura(total, descuento);

        }

        private void ImprimirFactura(decimal total, decimal descuento) 
        { 
            Console.WriteLine("*******************************");
            Console.WriteLine("              FACTURA          ");
            Console.WriteLine("*******************************");

            Console.WriteLine($"TOTAL MANZANAS: ${total}");
            Console.WriteLine($"DESCUENTO:  ${descuento}");
            Console.WriteLine($"TOTAL A PAGAR {total - descuento}");
        }
    }
}
