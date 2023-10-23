using System;
using System.Linq;
using System.Collections.Generic;

namespace Actidad1;

public class FabricaComputadoras 
{         
       public  FabricaComputadoras()
	   {
	   	Console.WriteLine("***************************************");
		   Console.WriteLine("Bienvenido a la fabrica de computadores");
		   Console.WriteLine("***************************************\n");
		   
		   
		   Console.WriteLine("Ingrese el número de computadoras a comprar");
		   if(!int.TryParse(Console.ReadLine(), out int cantidadComputadores))
		   {
		   	cantidadComputadores= 0;
		   }
		   
		   //Se valida la cantidad ingresada
		   if (cantidadComputadores == 0){
		   	Console.WriteLine("La cantidad ingresada de computadores no es válido. ");
			   return;
		  
		   }
		   
		   //Se establece elnvalor de los computadores
		   const double valorComputador = 11000;
		   
		   //Descuento del 10
	       if(cantidadComputadores < 5){
		   		Console.WriteLine($"El valor total para {cantidadComputadores} es de {valorComputador - (valorComputador * 0.10)}");
		   }
		   
		   //Descuento del 20
		   if(cantidadComputadores >= 5 || cantidadComputadores < 10){
		   		Console.WriteLine($"El valor total para {cantidadComputadores} es de {valorComputador - (valorComputador * 0.20)}");
		   }
		   
		   //Descuento del 40
		   if(cantidadComputadores > 10){
		   		Console.WriteLine($"El valor total para {cantidadComputadores} es de {valorComputador - (valorComputador * 0.40)}");
		   }
		  
	   }
}

