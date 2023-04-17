// 4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

int[] valores = new int [10];

for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i+1}° valor");
    valores[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($" O maior dos números digitados é {valores.Max()} e o menor é {valores.Min()}");
