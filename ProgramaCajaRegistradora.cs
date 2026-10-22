
using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== CAJA REGISTRADORA =====");
        Console.WriteLine("1. Calcular cambio en billetes y monedas");
        Console.WriteLine("2. Aplicar descuento por tipo de cliente");
        Console.WriteLine("3. Validar fecha de entrega");
        Console.WriteLine("4. Verificar folio capicúa");
        Console.WriteLine("5. Redondear precio y diferencia de inventario");
        Console.WriteLine("6. Salir");
        Console.Write("Elige una opcion: ");
        int opcion = int.Parse(Console.ReadLine());

        int precio;
        int pago;

        switch (opcion)
        {
            case 1:
                Console.WriteLine("===== Calcular cambio =====");
                Console.Write("Ingrese el precio: ");
                precio = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el pago: ");
                pago = int.Parse(Console.ReadLine());

                if (precio == pago)
                {
                    Console.WriteLine("Pago exacto, no hay cambio");
                }
                else if (precio > pago)
                {
                    Console.WriteLine("Pago insuficiente, falta $" + (precio - pago));
                }
                else
                {
                    int cambio = pago - precio;
                    Console.WriteLine($"=== Cambio: {cambio} ===");

                    if (cambio % 200 >= 0)
                    {
                        Console.WriteLine((cambio / 200) + " Billete de 200");
                        cambio = cambio - ((cambio / 200) * 200);
                    }
                    if (cambio % 100 >= 0)
                    {
                        Console.WriteLine((cambio / 100) + " Billete de 100");
                        cambio = cambio - ((cambio / 100) * 100);
                    }
                    if (cambio % 50 >= 0)
                    {
                        Console.WriteLine((cambio / 50) + " Billete de 50");
                        cambio = cambio - ((cambio / 50) * 50);
                    }
                    if (cambio % 20 >= 0)
                    {
                        Console.WriteLine((cambio / 20) + " Billete de 20");
                        cambio = cambio - ((cambio / 20) * 20);
                    }
                    if (cambio % 2 >= 0)
                    {
                        Console.WriteLine((cambio / 2) + " Moneda de 2");
                        cambio = cambio - ((cambio / 2) * 2);
                    }
                    if (cambio % 1 >= 0)
                    {
                        Console.WriteLine((cambio / 1) + " Moneda de 1");
                        cambio = cambio - ((cambio / 1) * 1);
                    }
                }
                break;

            case 2:
                Console.WriteLine("===== Aplicar descuento =====");
                Console.Write("Ingrese el subtotal: ");
                double subtotal = double.Parse(Console.ReadLine());

                Console.WriteLine("Tipos de cliente:");
                Console.WriteLine(" E/e = Estudiante");
                Console.WriteLine(" D/d = Docente");
                Console.WriteLine(" G/g = General");
                Console.Write("Ingrese tipo de cliente: ");
                char tipoCliente = char.Parse(Console.ReadLine());

                Console.WriteLine("¿Tiene credencial? S/N");
                char credencial = char.Parse(Console.ReadLine());
                bool tieneCredencial = false;

                if (credencial == 'S' || credencial == 's')
                {
                    tieneCredencial = true;
                }

                int descuento = 0;

                switch (tipoCliente)
                {
                    case 'E':
                    case 'e':
                        descuento = 15;
                        tipoCliente = 'E';
                        break;

                    case 'D':
                    case 'd':
                        descuento = 10;
                        tipoCliente = 'D';
                        break;

                    case 'G':
                    case 'g':
                        descuento = 0;
                        tipoCliente = 'G';
                        break;

                    default:
                        Console.WriteLine("Tipo de cliente no valido");
                        break;
                }

                if ((subtotal >= 500 && tieneCredencial) || tipoCliente == 'D')
                {
                    descuento += 5;
                }

                double total = subtotal - (subtotal * (descuento / 100.0));
                Console.WriteLine($"Subtotal {subtotal}, Tipo {tipoCliente}, credencial {credencial}");
                Console.WriteLine($"Descuento {descuento}% --> " + (subtotal * (descuento / 100.0)) + $"$, Total {total}$");
                break;

            case 3:
                Console.WriteLine("===== Validar fecha de entrega =====");
                Console.Write("Ingrese el dia: ");
                int dia = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el mes: ");
                int mes = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el año: ");
                int anio = int.Parse(Console.ReadLine());

                bool bisiesto = false;

                if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
                {
                    bisiesto = true;
                }

                int diasMax = 0;

                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        diasMax = 31;
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        diasMax = 30;
                        break;

                    case 2:
                        if (bisiesto)
                        {
                            diasMax = 29;
                        }
                        else
                        {
                            diasMax = 28;
                        }
                        break;
                }

                if (mes <= 12 && dia <= diasMax)
                {
                    if (bisiesto)
                    {
                        Console.WriteLine(dia + "/" + mes + "/" + anio + " Fecha Valida, año bisiesto");
                    }
                    else
                    {
                        Console.WriteLine(dia + "/" + mes + "/" + anio + " Fecha Valida, año no bisiesto");
                    }
                }
                else
                {
                    if (bisiesto)
                    {
                        Console.WriteLine(dia + "/" + mes + "/" + anio + " Fecha Invalida, año bisiesto");
                    }
                    else
                    {
                        Console.WriteLine(dia + "/" + mes + "/" + anio + " Fecha Invalida, año no bisiesto");
                    }
                }
                break;

            case 4:
                Console.WriteLine("===== Verificar folio capicua =====");
                Console.Write("Ingrese el folio (4 digitos): ");
                int folio = int.Parse(Console.ReadLine());

                if (folio < 1000 || folio > 9999)
                {
                    Console.WriteLine("Folio invalido");
                }
                else
                {
                    int digito1 = folio / 1000;
                    int digito2 = (folio / 100) % 10;
                    int digito3 = (folio / 10) % 10;
                    int digito4 = folio % 10;

                    if (digito1 == digito4 && digito2 == digito3)
                    {
                        Console.WriteLine(folio + " Es capicua");
                        int suma = digito1 + digito2 + digito3 + digito4;
                        long producto = (long)digito1 * digito2 * digito3 * digito4;
                        Console.WriteLine("La suma de digitos es: " + suma);
                        Console.WriteLine("El producto de digitos es: " + producto);

                        if (suma % 2 == 0)
                        {
                            Console.WriteLine("La suma es par");
                        }
                        else
                        {
                            Console.WriteLine("La suma es impar");
                        }
                    }
                }
                break;

            case 5:
                Console.WriteLine("===== Redondear precio y diferencia de inventario =====");

                Console.Write("Ingrese un precio positivo: ");
                double precioOriginal = double.Parse(Console.ReadLine());

                if (precioOriginal <= 0)
                {
                    Console.WriteLine("El precio debe ser positivo");
                }
                else
                {
                    int precioRedondeado = (int)(precioOriginal + 0.5);
                    double diferenciaPrecio = precioRedondeado - precioOriginal;

                    Console.WriteLine("Precio original: " + precioOriginal);
                    Console.WriteLine("Precio redondeado: " + precioRedondeado);

                    if (diferenciaPrecio > 0)
                    {
                        Console.WriteLine("Se agrego: " + diferenciaPrecio);
                    }
                    else if (diferenciaPrecio < 0)
                    {
                        Console.WriteLine("Se descarto: " + (diferenciaPrecio * -1));
                    }
                    else
                    {
                        Console.WriteLine("No hubo diferencia");
                    }
                }

                Console.WriteLine("===== Diferencia de inventario =====");

                Console.Write("Ingrese las piezas esperadas: ");
                int esperadas = int.Parse(Console.ReadLine());

                Console.Write("Ingrese las piezas contadas: ");
                int contadas = int.Parse(Console.ReadLine());

                int diferencia = contadas - esperadas;

                if (diferencia == 0)
                {
                    Console.WriteLine("Inventario correcto");
                }
                else if (diferencia < 0)
                {
                    Console.WriteLine("Faltan " + (diferencia * -1) + " piezas");
                }
                else
                {
                    Console.WriteLine("Sobran " + diferencia + " piezas");
                }
                break;

            case 6:
                Console.WriteLine("Gracias por usar la caja registradora");
                break;

            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }
}
