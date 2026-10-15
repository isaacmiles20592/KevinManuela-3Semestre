using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args){
        //1 numero mayor a 100
        Console.WriteLine("-----------");
        int numero;
        Console.Write("1- Ingrese un numero entero: ");
        numero = int.Parse(Console.ReadLine());
        if (numero > 100) {
            Console.WriteLine("El numero es mayor que 100");
        }
        //2 Envio gratis
        Console.WriteLine("-----------");
        decimal monto;
        Console.Write("2 -Ingrese el monto de compra: ");
        monto = decimal.Parse(Console.ReadLine());
        if (monto >= 500) {
            Console.WriteLine("Tienes envio gratis");
        }
        Console.WriteLine($"Total: {monto}");
        //3 Multilplo de 5
        Console.WriteLine("-----------");
        int numero2;
        Console.Write("3- Ingrese un numero entero: ");
        numero2 = int.Parse(Console.ReadLine());
        if (numero2 % 5 == 0) {
            Console.WriteLine("El numero es multiplo de 5");
        }
        //4 Mayor de dos numeros
        Console.WriteLine("-----------");
        int numero3;
        int numero4;
        Console.Write("4- Ingrese un numero entero: ");
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
        Console.WriteLine("-----------");
        int numero5;
        Console.Write("5- Ingrese un numero entero");
        numero5 = int.Parse(Console.ReadLine());
        if (numero5 >= 0) {
            Console.WriteLine("El numero es positivo o cero");
        }
        else {
            Console.WriteLine("El numero es negativo");
        }
        //6 Saldo suficiente
        Console.WriteLine("-----------");
        decimal saldo;
        decimal monto2;
        Console.Write("6- Ingrese su saldo:");
        saldo = int.Parse(Console.ReadLine());
        Console.Write("Ingrese monto de compra: ");
        monto2 = int.Parse(Console.ReadLine());
        if (saldo >= monto2) {
            Console.WriteLine("Compra realizada");
            Console.WriteLine("saldo restante:" + (saldo - monto2));
        }
        else {
            Console.WriteLine("Saldo insuficiente");
        }
        //7 Calificacion con letra
        Console.WriteLine("-----------");
        float calificacion;
        Console.WriteLine("Ingrese su calificacion 1-100: ");
        calificacion = int.Parse(Console.ReadLine());
        if (calificacion < 0 || calificacion > 100) {
            Console.WriteLine("Calificacion no valida");
        }
        else if (calificacion >= 90) {
            Console.WriteLine("A");
        }
        else if (calificacion >= 80) {
            Console.WriteLine("B");
        }
        else if (calificacion >= 70) {
            Console.WriteLine("C");
        }
        else if (calificacion >= 60) {
            Console.WriteLine("D");
        }
        else if (calificacion >= 0) {
            Console.WriteLine("F");
        }
        //8 Dia de la semana
        Console.WriteLine("-----------");
        int dia;
        Console.WriteLine("ingrese un dia de la semana 1-7");
        dia = int.Parse(Console.ReadLine());
        if (dia > 7 || dia < 1) {
            Console.WriteLine("Numero no valido");
        }
        else if (dia == 1) {
            Console.WriteLine("Lunes");
        }
        else if (dia == 2) {
            Console.WriteLine("Martes");
        }
        else if (dia == 3) {
            Console.WriteLine("Miercoles");
        }
        else if (dia == 4) {
            Console.WriteLine("Jueves");
        }
        else if (dia == 5) {
            Console.WriteLine("Viernes");
        }
        else if (dia == 6) {
            Console.WriteLine("Sabado");
        }
        else if (dia == 7) {
            Console.WriteLine("Domingo");
        }
        //9 Clasificacion por temperatura
        Console.WriteLine("-----------");
        float temperatura;
        Console.WriteLine("Ingrese la temperatura");
        temperatura = float.Parse(Console.ReadLine());
        if (temperatura < 0){
            Console.WriteLine("Congelante");
        }
        else if (temperatura <= 14){
            Console.WriteLine("Frio");
        }
        else if (temperatura <= 24){
            Console.WriteLine("Templado");
        }
        else if (temperatura <= 34){
            Console.WriteLine("Caluroso");
        }
        else if (temperatura >= 35){
            Console.WriteLine(" Muy Caluroso");
        }
    
    }
} 
