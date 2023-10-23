//Un proveedor de equipos de sonido ofrece un descuento del 10% sobre el precio sin IVA,
//de algún aparato si este cuesta $200000 o más. Además, independientemente de esto, ofrece
//un 5% de descuento si la marca es NOSY. Determinar cuánto pagara, con IVA incluido, un
//cliente cualquiera por la compra de su aparato. IVA=19%.

namespace Actividad1
{
    internal class EquiposSonido
    {
        public EquiposSonido()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Bienvenido a Equipos de sonido");
            Console.WriteLine("******************************\n");

            //Se pide el precio de venta del equipo
            double precioVentaSinDescuento = -1;
            while (precioVentaSinDescuento <= 0) 
            {
                Console.WriteLine("Ingrese el precios de venta sin IVA");

                if (!double.TryParse(Console.ReadLine(), out precioVentaSinDescuento))
                    precioVentaSinDescuento = -1;
            }

            Console.WriteLine("Ingrese la marca del producto: ");
            string marca = Console.ReadLine();

            //Se asigna el descuento de la marca
            double precioVenta = precioVentaSinDescuento    ;
            if (marca == "NOSY")
                precioVenta = precioVentaSinDescuento - (precioVentaSinDescuento * 0.05);

            //Se asigna descuento del precio.
            if (precioVentaSinDescuento > 200000)
                precioVenta = precioVenta - (precioVenta * 0.10);

            Console.WriteLine("***************************************");
            Console.WriteLine("         DETALLES DE LA FACTURA        ");
            Console.WriteLine("***************************************");
            //Se imprime los valores:
            Console.WriteLine($"El precio de venta del equipo de marca {marca} es de: ${precioVentaSinDescuento}");
            //Se imprime la difernecia si hay descuentos
            if (precioVenta != precioVentaSinDescuento)
                Console.WriteLine($"El precio de venta fue de ${precioVenta} teniendo una ahorro de ${precioVentaSinDescuento - precioVenta} ");

            var Iva = precioVenta * 0.19;
            Console.WriteLine($"El IVA es de : ${Iva}");
            Console.WriteLine($"El total a pagar es de: $ {precioVenta + Iva}");           
        }
    }
}
