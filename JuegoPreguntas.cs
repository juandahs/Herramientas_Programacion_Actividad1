using System;

namespace Actividad1
{
    internal class JuegoPreguntas
    {
        public JuegoPreguntas()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Bienvenido al Juego de preguntas");
            Console.WriteLine("********************************\n");

            // Instrucciones del juego
            Console.WriteLine("INSTRUCCIONES:\nEn un juego de preguntas a las que se responde Sí o No.");
            Console.WriteLine("Gana si responde correctamente las tres preguntas.");
            Console.WriteLine("Si responde mal una pregunta, se termina el juego.");
            
            Console.WriteLine("QUE COMIENCE EL JUEGO\n");
            string explicacionRespuestaIncorrecta = """
                    Cristóbal Colón llegó a América en 1492, pero no la 
                    descubrió en el sentido de encontrar un continente completamente desconocido.
                    América ya estaba habitada por diversas culturas indígenas antes de su llegada. Además,
                    el explorador vikingo Leif Erikson llegó a América del Norte antes que Colón.
                """;
            if (!ProcesarPregunta("¿Colón descubrió América?", "no", explicacionRespuestaIncorrecta))
            {
                Console.WriteLine("¡Fin del juego!");
                return;
            }

            explicacionRespuestaIncorrecta = """
                    La independencia de Colombia 
                    se logró a través de un proceso que comenzó en 1810 y culminó en 1819 con la
                    Batalla de Boyacá. Por lo tanto, no ocurrió en 1800.
                """;
            if (!ProcesarPregunta("¿La independencia de Colombia fue en el año 1800?", "no", explicacionRespuestaIncorrecta))
            {
                Console.WriteLine("¡Fin del juego!");
                return;
            }

            explicacionRespuestaIncorrecta = """
                    Metallica es una banda de 
                    rock estadounidense que se formó en Los Ángeles, California, en 1981. 
                    Han sido muy influyentes  en el género del heavy metal y el rock.
                """;
            if (!ProcesarPregunta("¿Metallica es un grupo de rock americano?", respuestaCorrecta: "si", explicacionRespuestaIncorrecta))
            {
                Console.WriteLine("¡Fin del juego!");
                return;
            }

            MostrarMensajeGanador();
        }

        private bool ProcesarPregunta(string pregunta, string respuestaCorrecta, string explicacionRespuestaIncorrecta)
        {
            Console.WriteLine(pregunta);
            string respuestaUsuario = Console.ReadLine();

            if (!respuestaUsuario.Equals(respuestaCorrecta, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("********************");
                Console.WriteLine("Respuesta incorrecta");
                Console.WriteLine("********************\n");

                Console.WriteLine($"La respuesta correcta es: {respuestaCorrecta}\n");
                Console.WriteLine("Explicación:");
                Console.WriteLine(explicacionRespuestaIncorrecta + "\n");
                return false;
            }

            return true;
        }

        private void MostrarMensajeGanador()
        {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("¡FELICIDADES, RESPONDIÓ TODAS LAS PREGUNTAS!");
            Console.WriteLine("******************************************* \n");

            Console.WriteLine("Presione cualquier tecla para volver al menú principal.");
            Console.ReadLine();
        }
    }
}
