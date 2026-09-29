using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // Datos
        int alturaRectangulo;
        int baseRectangulo;
        double radioCirculo;
        int ladoCuadrado;
        
        // Entrada de datos
        Console.WriteLine("- - - Area de rectangulo - - -");
        Console.Write("ingrese altura del rectangulo: ");
        alturaRectangulo = int.Parse(Console.ReadLine());
        Console.Write("ingrese base del rectangulo: ");
        baseRectangulo = int.Parse(Console.ReadLine());
        int areaRectangulo = (alturaRectangulo*baseRectangulo);
        Console.WriteLine("Su area es: " + areaRectangulo);
        
        Console.WriteLine("- - - Area de circulo - - -");
        Console.Write("ingrese radio del circulo: ");
        radioCirculo = double.Parse(Console.ReadLine());
        double areaCirculo = ((radioCirculo*radioCirculo)*3.1416);
        Console.WriteLine("El area de su circulo es: "+ areaCirculo);
        
        Console.WriteLine("- - - Area de cuadrado - - -");
        Console.Write("ingrese lado del cuadrado: ");
        ladoCuadrado = int.Parse(Console.ReadLine());
        int areaCuadrado = (ladoCuadrado*ladoCuadrado);
        Console.WriteLine("El area de su cuadrado es: "+ areaCuadrado);
    }
}
