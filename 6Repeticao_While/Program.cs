using System;

Console.WriteLine("## Instrução While ##\n");

int numero;
int contador = 1;

Console.WriteLine("\nDigite um número maior que zero\t");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    //loop while
    Console.WriteLine($"\n## Tabuada do {numero} ##\n");
    while (contador < 11)
    {
        Console.WriteLine($"{numero} x {contador} = {numero*contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("\nNúmero deve ser maior que zero!");
}
Console.WriteLine("\nFim do Processamento!");
Console.ReadKey();