//Integrantes: Randy Adair Rojas Jaimes
//Kevin Isaac Manuela Hernandez 
//Video de funcionamiento https://youtube.com/shorts/9Sz4rVF7KPw?feature=share
using System;
	class Program
	{
		public static void Main(string[] args)
		{
		//Declarar e inicalizar variables
        int ventasRealizadas = 0;
        int ventasCanceladas = 0;
        int productosVendidos = 0;
        int descuentos = 0;

        int efectivo = 0;
        int tarjeta = 0;
        int transferencia = 0;
        
        double totalDia = 0;
        double ventaMayor = 0;
        int numeroMayor = 0;
        //imprime la bienvenida y pide la cantidad de ventas
        Console.WriteLine("===== SISTEMA DE CAJA =====");
        Console.WriteLine("Bienvenido a la tienda");
        Console.WriteLine("¿Cuantas ventas se registraran hoy?");
        int ventas = int.Parse(Console.ReadLine());
        
        //Ejecuta la parte principal del programa si ventas es mayor a 0
        if (ventas > 0) {
        	
        // Ciclo de ventas, se repite la cantidad de veces que ingreso el usuario (ventas)
        for (int i = 1; i <= ventas; i++)
        {
            Console.WriteLine("===== VENTA " + i + " =====");
            int cantidadProductos;
            int piezas;
            int piezasVenta = 0;

            double precio;
            double importe;
            double subtotal = 0;
            double iva;
            double total;
            double descuento = 0;
            double pagar;

            Console.WriteLine("Cuantos productos tiene la venta?");
            cantidadProductos = int.Parse(Console.ReadLine());
            
            if (cantidadProductos > 0) {
            	Console.WriteLine();
                Console.WriteLine("===== TICKET DE VENTA " + i + " =====");

                //Bucle de captura de productos, se ejecuta (cantidadProductos) veces
                for (int j = 1; j <= cantidadProductos; j++)
                {
                    string nombre;

                    Console.WriteLine();
                    Console.WriteLine("Producto " + j);

                    Console.WriteLine("Nombre del producto:");
                    nombre = Console.ReadLine();

                    Console.WriteLine("Precio unitario:");
                    precio = double.Parse(Console.ReadLine());

                    Console.WriteLine("Cantidad de piezas:");
                    piezas = int.Parse(Console.ReadLine());
                    
					//Calcula y suma el importe del producto al sutotal, suma el total de las piezas vendidas 
                    if (precio <= 0 || piezas <= 0)
                    {
                        Console.WriteLine("Producto invalido, no se tomara en cuenta");
                    }
                    else
                    {
                        importe = precio * piezas;
                        subtotal = subtotal + importe;
                        piezasVenta = piezasVenta + piezas;

                        Console.WriteLine();
                        Console.WriteLine("Nombre: " + nombre);
                        Console.WriteLine("Cantidad: " + piezas);
                        Console.WriteLine("Precio unitario: $" + precio.ToString("F2"));
                        Console.WriteLine("Importe: $" + importe.ToString("F2"));
                    }
                }

                // Calculos del Total con iva y descuento si es mas de 1000
                iva = subtotal * 0.16;
                total = subtotal + iva;
				
                if (total > 1000)
                {
                    descuento = total * 0.10;
                    descuentos++;
                }

                pagar = total - descuento;

                //Pide forma de pago 
                int formaPago;

                Console.WriteLine();
                Console.WriteLine("===== FORMA DE PAGO =====");
                Console.WriteLine("1. Efectivo");
                Console.WriteLine("2. Tarjeta");
                Console.WriteLine("3. Transferencia");
                Console.WriteLine("Elige una opcion:");
                formaPago = int.Parse(Console.ReadLine());

                string pago;
                
				//Alterna entre la forma de pago ingresada, cualquier numero fuera de rango se registra como efectivo
                switch (formaPago)
                {
                    case 1:
                        pago = "Efectivo";
                        efectivo++;
                        break;

                    case 2:
                        pago = "Tarjeta";
                        tarjeta++;
                        break;

                    case 3:
                        pago = "Transferencia";
                        transferencia++;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida, se registrara en efectivo");
                        pago = "Efectivo";
                        efectivo++;
                        break;
                }

                // Imprime el Ticket final (de la venta)
                Console.WriteLine();
                Console.WriteLine("===== RESUMEN DEL TICKET =====");
                Console.WriteLine("Numero de venta: " + i);
                Console.WriteLine("Subtotal: $" + subtotal.ToString("F2"));
                Console.WriteLine("IVA (16%): $" + iva.ToString("F2"));
                Console.WriteLine("Total: $" + total.ToString("F2"));
                Console.WriteLine("Descuento: $" + descuento.ToString("F2"));
                Console.WriteLine("Total a pagar: $" + pagar.ToString("F2"));
                Console.WriteLine("Forma de pago: " + pago);

                // Acumulador de ventas, total de productos vendidos y total del dia
                ventasRealizadas++;
                productosVendidos = productosVendidos + piezasVenta;
                totalDia = totalDia + pagar;

                if (pagar > ventaMayor || ventasRealizadas == 1)
                {
                    ventaMayor = pagar;
                    numeroMayor = i;
                }
            }
            else {
            	Console.WriteLine("Venta cancelada");
                ventasCanceladas++;
            }
        }

        //Revisa si hubo al menos una venta para calcular el promedio
        double promedio = 0;

        if (ventasRealizadas > 0)
        {
            promedio = totalDia / ventasRealizadas;
        }
        //Imprime el resumen del día
        Console.WriteLine();
        Console.WriteLine("===== RESUMEN DEL DIA =====");

        Console.WriteLine("Ventas realizadas: " + ventasRealizadas);
        Console.WriteLine("Ventas canceladas: " + ventasCanceladas);
        Console.WriteLine("Productos vendidos: " + productosVendidos);
        Console.WriteLine("Total vendido en el dia: $" + totalDia.ToString("F2"));
        Console.WriteLine("Venta mas alta: $" + ventaMayor.ToString("F2"));
        Console.WriteLine("Numero de venta: " + numeroMayor);
        Console.WriteLine("Promedio por venta: $" + promedio.ToString("F2"));
        Console.WriteLine("Ventas con descuento: " + descuentos);

        Console.WriteLine();
        Console.WriteLine("===== FORMAS DE PAGO =====");
        Console.WriteLine("Efectivo: " + efectivo);
        Console.WriteLine("Tarjeta: " + tarjeta);
        Console.WriteLine("Transferencia: " + transferencia);

        Console.WriteLine();
        Console.WriteLine("Gracias por utilizar el sistema de caja");
        }
        else {
        	//Termina el programa si ventas no es mayor a 0
        	Console.WriteLine("Error: la cantidad debe ser mayor a cero");
        }  
	}
  }
