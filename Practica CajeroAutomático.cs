using System;
namespace HelloWorld;

class Program
{
    static void Main(string[] args) 
    {
        //Cajero automatico
        int opcion = 0;
        while (opcion != 6) 
        {
            //Bienvenida y Menú
            Console.WriteLine("===== CAJERO AUTOMÁTICO =====");
            Console.WriteLine("1. Convertir numero de cuenta a binario");
            Console.WriteLine("2. Depositar billetes");
            Console.WriteLine("3. Validar NIP");
            Console.WriteLine("4. Analizar numero de cuenta");
            Console.WriteLine("5. Decodificar mensaje ASCII");
            Console.WriteLine("6. Salir");
            Console.WriteLine("Ingrese una opcion");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            switch (opcion) 
            {
                case 1: 
                    //Convertir a binario
                    int numDeCuenta;
                    do {
                        Console.WriteLine("=== Convertir numero de cuenta a binario ===");
                        Console.Write("Ingrese su numero de cuenta: ");
                        numDeCuenta = int.Parse(Console.ReadLine());
                        
                        if (numDeCuenta <= 0) {
                            Console.WriteLine("Numero invalido, intente de nuevo");
                        }
                    } while (numDeCuenta <= 0);
                        
                    string numBinario = "";
                    
                    while (numDeCuenta > 0) {
                        
                        if (numDeCuenta % 2 == 0) {
                            numBinario += 0;
                        } else {
                            numBinario += 1;
                        }
                        
                    numDeCuenta /= 2;
                    }
                    Console.Write("Su numero a binario es: ");
                    Console.WriteLine(numBinario);
                    Console.WriteLine();
                    break;
                    
                case 2:
                    //Llevar cuenta de billetes
                    Console.WriteLine("=== Depositar billetes ===");
                    Console.WriteLine("Billetes aceptados: 20, 50, 100, 200, 500, 1000");
                    Console.WriteLine("Ingrese 0 para terminar");
                    int cuenta = 0;
                    int billete;
                    int aceptados = 0;
                    do {
                        Console.Write("Ingrese su billete: ");
                        billete = int.Parse(Console.ReadLine());
                        switch (billete) {
                        case 0:
                            break;
                            
                        case 20:
                            cuenta += 20;
                            aceptados++;
                            break;
                                
                        case 50:
                            cuenta += 50;
                            aceptados++;
                            break;
                                
                        case 100:
                            cuenta += 100;
                            aceptados++;
                            break;
                                
                        case 200:
                            cuenta += 200;
                            aceptados++;
                            break;
                                
                        case 500:
                            cuenta += 500;
                            aceptados++;
                            break;
                           
                        case 1000:
                            cuenta += 1000;
                            aceptados++;
                            break;
                            
                        default:
                            Console.WriteLine("Billete inválido, se rechaza");
                            break;
                            
                        }
                        
                    } while (billete != 0);
                    Console.WriteLine();
                    Console.WriteLine("Billetes aceptados: " + aceptados);
                    Console.WriteLine("Total depositado: " + cuenta);
                    Console.WriteLine();
                    break;
                    
                case 3:
                    //Validar NIP
                    Console.WriteLine("=== Validar NIP ===");
                    int intentos = 3;
                    int nip;
                    while (intentos != 0) {
                        Console.Write("Ingrese su NIP (4 dígitos): ");
                        bool numeroValido = int.TryParse(Console.ReadLine(), out nip);
                        if (numeroValido) {
                            if (nip == 1234) {
                                Console.WriteLine("Acceso concedido en el intento " + intentos);
                                break;
                            } else {
                                intentos--;
                                Console.WriteLine("NIP incorrecto, te quedan " + (intentos) + " intentos");
                                continue;
                            }
                        }
                        intentos--;
                        Console.WriteLine("Dato inválido, quedan " + (intentos) + " intentos");
                    }
                    Console.WriteLine();
                    break;
                    
                case 4:
                    // Analizar numero de cuenta
                    Console.WriteLine("=== Analizar número de cuenta ===");
                    Console.Write("Ingrese un número positivo: ");
                    int numero = int.Parse(Console.ReadLine());
                    
                    while (numero < 1) {
                        Console.WriteLine("El número debe ser positivo");
                        Console.Write("Ingrese un número positivo: ");
                        numero = int.Parse(Console.ReadLine());
                    } 
                    
                    int original = numero;
                    int digitos = 0;
                    int suma = 0;
                    int invertido = 0;
                    int temporal = numero;

                    while (temporal > 0) {
                        int digito = temporal % 10;               
                        suma += digito;                       
                        invertido = invertido * 10 + digito;  
                        digitos++;                            
                        temporal /= 10;                           
                    }

                    string parImparSuma = (suma % 2 == 0) ? "par" : "impar";
                    bool esCapicua = (original == invertido);

                    Console.WriteLine("Cantidad de dígitos: " + digitos);
                    Console.WriteLine("Suma = " + suma + " (" + parImparSuma + ")");
                    Console.WriteLine("Invertido = " + invertido);
                    
                    if (esCapicua) {
                        Console.WriteLine("Es capicúa");
                    } else {
                        Console.WriteLine("No es capicúa");
                    }
                    Console.WriteLine();
                    break;
                    
                case 5:
                    //Codigo ASCII
                    Console.WriteLine("=== Decodificar Mensaje ASCII ===");
                    Console.WriteLine("Ingrese 0 Para terminar ");
                    int numeroAscii = 1;
                    char letraActual;
                    string mensaje = "";
                    int codigoAceptados = 0;
                    int sumaCodigos = 0;
                    
                    while (numeroAscii != 0) {
                        Console.Write("Ingrese un numero entre 32 y 126: ");
                        numeroAscii = int.Parse(Console.ReadLine());
                        
                        if (numeroAscii > 32 && numeroAscii < 126) {
                            letraActual = (char)numeroAscii;
                            mensaje += letraActual;
                            sumaCodigos += numeroAscii;
                            codigoAceptados++;
                            Console.Write(letraActual + " --> ");
                            
                            //Clasifica el caracter
                            if (numeroAscii >= 48 && numeroAscii < 58) {
                                Console.WriteLine("Número");
                            } else if (numeroAscii >= 65 && numeroAscii < 91) {
                                Console.WriteLine("Mayúscula");
                            } else if (numeroAscii >= 97 && numeroAscii < 123) {
                                Console.WriteLine("Minúscula");
                            } else {
                                Console.WriteLine("Símbolo");
                            }
                            
                        } else if (numeroAscii != 0) {
                            Console.WriteLine("Código no válido, se rechaza");
                        } else if (codigoAceptados == 0) {
                            Console.WriteLine("No se ingreso ningun código válido");
                            break;
                        }
                    }
                    Console.WriteLine("El mensaje es: " + mensaje);
                    Console.WriteLine("Caracteres aceptados: " + codigoAceptados);
                    Console.WriteLine("Promedio de códigos: " + ((double)sumaCodigos / codigoAceptados));
                    Console.WriteLine();
                    break;
                    
                case 6:
                    //Salir
                    break;
                    
                default:
                    Console.WriteLine();
                    Console.WriteLine("Opcion no válida");
                    break;
            }
        }
        Console.ReadKey(true);
    }
}
