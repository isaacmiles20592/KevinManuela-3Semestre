Random rd = new Random();
int numero1 = rd.Next();
int numero2 = rd.Next();
int numero3 = rd.Next();
int numero4 = rd.Next();
int numero5 = rd.Next();

Console.WriteLine("=== Numeros generados ===");
Console.WriteLine("numero 1: " + numero1);
Console.WriteLine("numero 2: " + numero2);
Console.WriteLine("numero 3: " + numero3);
Console.WriteLine("numero 4: " + numero4);
Console.WriteLine("numero 5: " + numero5);

int mayor = numero1;
int segundo = numero2;
int tercero = numero3;
int cuarto = numero4;
int menor = numero5;

for (int i = 0; i < 4; i++)
{
    if (mayor < segundo)
    {
        int temp = mayor;
        mayor = segundo;
        segundo = temp;
    }

    if (segundo < tercero)
    {
        int temp = segundo;
        segundo = tercero;
        tercero = temp;
    }

    if (tercero < cuarto)
    {
        int temp = tercero;
        tercero = cuarto;
        cuarto = temp;
    }

    if (cuarto < menor)
    {
        int temp = cuarto;
        cuarto = menor;
        menor = temp;
    }
}

Console.WriteLine();
Console.WriteLine("Numero mayor: " + mayor);
Console.WriteLine("Segundo: " + segundo);
Console.WriteLine("Tercero: " + tercero);
Console.WriteLine("Cuarto: " + cuarto);
Console.WriteLine("Numero menor: " + menor);
