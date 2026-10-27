using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)   {
        //tablas de multiplicar
        for(int i = 1; i <= 10; i++) {
            Console.WriteLine("== Tabla del " + i + " ==");
            for (int j = 1; j <= 10; j++) {
                Console.WriteLine(i + " * " + j + " = " + (i * j));
            }
            Console.WriteLine();
        }
        //0 - 100 par impar 
        for (int i = 0; i <= 100; i++) {
            if (i % 2 == 0) {
                Console.WriteLine(i + " es Par");
            }
            else {
                Console.WriteLine(i + " es Impar");
            }
        }
        // imprimir un cuadrado 
        for (int i = 0; i < 3; i++) {
            
            for (int j = 0; j < 3; j++) {
                Console.Write("*")
        }
            Console.WriteLine()
    }
    
}
