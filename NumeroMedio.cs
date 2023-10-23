using System.Timers;

namespace Actividad1
{
    internal class NumeroMedio
    {
        public NumeroMedio()
        {

            Console.WriteLine("Ingrese tres números diferentes:");

            // Crear un conjunto para almacenar los números
            List<int> numeros = new();

            while (numeros.Count < 3)
            {
                Console.Write($"Número {numeros.Count + 1}: ");

                if (int.TryParse(Console.ReadLine(), out int numero))
                    numeros.Add(numero);
            }

            Console.WriteLine($"El número medio es: {EncontrarNumeroMedio(numeros)}");
        }


        private double EncontrarNumeroMedio(List<int> numeros)
        {
            double max = numeros.Max();
            double min = numeros.Min();
            //Se obtiene el número medio
            return numeros.FirstOrDefault(num => num != min && num != max);

        }

    }
}
