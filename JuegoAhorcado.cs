using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Juego de ahorcado ===");
        bool salir = false;
        //juego
        while (!salir)
        {
            Console.Write("Ingrese la palabra a adivinar: ");
            string palabra = Console.ReadLine();
            if (palabra == null)
            {
                palabra = "";
            }
            palabra = palabra.Trim().ToLower();

            if (string.IsNullOrEmpty(palabra))
            {
                Console.WriteLine("La palabra a adivinar no puede estar vacía.");
                continue;
            }

            Console.Clear();

            char[] palabraArr = palabra.ToCharArray();
            char[] progreso = new char[palabraArr.Length];

            for (int i = 0; i < progreso.Length; i++)
            {
                progreso[i] = '_';
            }

            int vidas = 6;
            string letrasUsadas = "";
            //repetir intentos
            while (vidas > 0 && QuedanLetras(progreso))
            {
                Console.WriteLine("Palabra: " + string.Join(" ", progreso));
                Console.WriteLine("Vidas restantes: " + vidas);

                if (letrasUsadas.Length > 0)
                {
                    Console.WriteLine("Letras intentadas: " + letrasUsadas);
                }

                Console.Write("Ingrese una letra: ");
                string entrada = Console.ReadLine();
                if (entrada == null)
                {
                    entrada = "";
                }
                entrada = entrada.Trim().ToLower();

                if (entrada.Length != 1 || !char.IsLetter(entrada[0]))
                {
                    Console.WriteLine("Ingrese una sola letra válida.");
                    continue;
                }

                char intento = entrada[0];

                if (letrasUsadas.Contains(intento))
                {
                    Console.WriteLine("Ya se intento esa letra.");
                    continue;
                }

                letrasUsadas += intento + " ";

                bool acerto = false;
                for (int i = 0; i < palabraArr.Length; i++)
                {
                    if (palabraArr[i] == intento)
                    {
                        progreso[i] = intento;
                        acerto = true;
                        Console.WriteLine();
                    }
                }

                if (!acerto)
                {
                    vidas--;
                    Console.WriteLine("Incorrecto, quedan " + vidas + " vidas.");
                    Console.WriteLine();
                }
            }
            
            Console.WriteLine("Palabra: " + string.Join(" ", progreso));

            if (!QuedanLetras(progreso))
            {
                Console.WriteLine("Palabra adivinada");
            }
            else
            {
                Console.WriteLine("Ya no tienes vidas, la palabra era: " + palabra);
            }

            Console.Write("¿Desea jugar otra vez? (s/n): ");
            string respuesta = Console.ReadLine();
            if (respuesta == null)
            {
                respuesta = "";
            }
            respuesta = respuesta.Trim().ToLower();
            if (respuesta != "s")
            {
                salir = true;
            }
        }
    }

    static bool QuedanLetras(char[] progreso)
    {
        for (int i = 0; i < progreso.Length; i++)
        {
            if (progreso[i] == '_')
            {
                return true;
            }
        }

        return false;
    }
}
