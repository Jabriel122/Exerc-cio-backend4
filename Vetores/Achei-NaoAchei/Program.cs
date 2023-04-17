﻿// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

string[] nomes = new string[10];

for (var i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i+1}° nome");
    nomes[i] = Console.ReadLine();
}

Console.WriteLine($"Agora digite um nome de alguma pessoa que você digitou, assim o programa irá procurar esse nome");
bool Achei = nomes.Contains(Console.ReadLine());


if (Achei == true)
{
    Console.WriteLine($"Achei");
}
else
{
    Console.WriteLine($"Não achei");
}

