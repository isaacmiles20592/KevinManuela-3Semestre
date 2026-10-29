using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args) {
        //Reportes de la tiendita
        Console.WriteLine("=== REPORTES DE LA TIENDITA ===");
        Console.WriteLine("1. Tabla de precios por cantidad");
        Console.WriteLine("2. Ventas de la semana");
        Console.WriteLine("3. Total de piezas en promocion");
        Console.WriteLine("4. Salir");
        Console.Write("Elige una opcion: ");
        int opcion = int.Parse(Console.ReadLine());
        switch (opcion) {
            case 1:
                Console.WriteLine("== Tabla de Precios ==");
                Console.Write("Ingrese precio unitario: ");
                double precioUnitario = double.Parse(Console.ReadLine());
                for (double i = 1.0; i <= 10.0; i++) {
                    if (i > 5) {
                        
                        Console.Write(i + " pieza (s) = $" + (i * precioUnitario - ((i * precioUnitario) / 10)));
                        Console.WriteLine("(Con descuento)");
                    }
                    else {
                        Console.WriteLine(i + " pieza (s) = $" + (i * precioUnitario));
                    }
                }
            break;
            
            case 2:
                Console.WriteLine("== Ventas de la semana ==");
                double mayor = 0.0;
                double cuenta = 0.0;
                double dia = 0.0;
                int diaVenta = 0;
                int masDeMil = 0;
                for (int i = 1; i <= 7; i++)
                {
                    Console.Write("Ingrese venta del dia " + i + ":");
                    dia = double.Parse(Console.ReadLine());
                    if (dia > mayor) {
                        mayor = dia;
                        diaVenta = i;
                    }
                    if (dia > 1000) {
                        masDeMil += 1;
                    }                 
                    
                     cuenta += dia;
                }
                Console.WriteLine("Venta total de la semana: $" + cuenta);
                    Console.WriteLine("Dia con mas ventas: " + diaVenta + "cantidad: " + mayor);
                    Console.WriteLine("Promedio de venta por dia: " + (cuenta / 7));
                Console.WriteLine("Dias con ventas de mas de $1000: " + masDeMil);
                break;
            
            case 3:
                Console.Write("Ingrese un numero entero 1 - 20:");
                int numero = int.Parse(Console.ReadLine());
                long producto = 1;
                int suma = 0;
                int diasPares = 0;
                int diasImpares = 0;
                if (numero > 20 || numero < 1) {
                    Console.WriteLine("Numero invalido");
                }
                for (int i = 1; i <= numero; i++) {
                    producto = producto * i;
                    suma = suma + i;
                    if (i % 2 == 0) {
                        diasPares += 1;
                    }
                    else {
                        diasImpares += 1;
                    }
                    Console.WriteLine("Dia " + i + ": se regalaron " + i + " pieza (s)"); 
                }
                Console.WriteLine("Piezas regaladas: " + suma);
                Console.WriteLine("Producto: " + producto);
                Console.WriteLine("Dias pares: " + diasPares);
                Console.WriteLine("Dias impares: " + diasImpares);
                break;
            
            case 4:
                Console.WriteLine("Muchas gracias por usar los reportes de la tiendita");
            break;
            
            default:
                Console.WriteLine("Opcion no valida");
            break;
        }
    }
    
}
