using System;

Console.WriteLine("Primeiro Número:");
int v1 = int.Parse(Console.ReadLine());

Console.WriteLine("Segundo Número:");
int v2 = int.Parse(Console.ReadLine());

Console.WriteLine("Terceiro Número:");
int v3 = int.Parse(Console.ReadLine());

int Maior = v1;

if (v2 > Maior)
{
    Maior = v2;
}
if (v3 > Maior)
{
    Maior = v3;
}

Console.WriteLine("O maior número é:" + Maior);
Console.WriteLine("Programa Finalizado");

   


