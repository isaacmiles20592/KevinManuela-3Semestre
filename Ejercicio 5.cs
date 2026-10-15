using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        //1 numero mayor a 100
        int numero;
        Console.Write("1- Ingrese un numero entero: ");
        numero = int.Parse(Console.ReadLine());
        if (numero > 100) {
            Console.WriteLine("El numero es mayor que 100");
        }
        //2 Envio gratis
        decimal monto;
        Console.Write("2 -Ingrese el monto de compra: ");
        monto = decimal.Parse(Console.ReadLine());
        if (monto >= 500) {
            Console.WriteLine("Tienes envio gratis");
        }
        Console.WriteLine($"Total: {monto}");
        //3 Multilplo de 5
        int numero2;
        Console.WriteLine("3- Ingrese un numero entero: ");
        numero2 = int.Parse(Console.ReadLine());
        if (numero2 % 5 == 0) {
            Console.WriteLine("El numero es multiplo de 5");
        }
        //4 Mayor de dos numeros
        int numero3;
        int numero4;
        Console.WriteLine("4- Ingrese un numero entero: ");
        numero3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero entero: ");
        numero4 = int.Parse(Console.ReadLine());
        if (numero3 > numero4) {
            Console.WriteLine($"El numero mayor es: {numero3}");
        }
        else {
            Console.WriteLine($"El numero mayor es: {numero4}");
        }
        //5 Positivo o negativo
        int numero5;
        Console.WriteLine("5- Ingrese un numero entero");
        numero5 = int.Parse(Console.ReadLine());
        if (numero5 >= 0) {
            Console.WriteLine("El numero es positivo o cero");
        }
        else {
            Console.WriteLine("El numero es negativo");
        }
        //6 Saldo suficiente
        decimal saldo;
        decimal monto2;
        Console.WriteLine("Ingrese su saldo:");
        saldo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese monto de compra: ");
        monto2 = int.Parse(Console.ReadLine());
        if (saldo >= monto2) {
            Console.WriteLine("Compra realizada");
            Console.WriteLine($"saldo restante {monto2}");
        }
        else {
            Console.WriteLine("Saldo insuficiente");
        }
        
    }
} 
