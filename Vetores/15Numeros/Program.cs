// 7 - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

int[] numeros = new int[15];


for (var i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite {i+1}° número");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (var i = 14; i >= 0; i--)
{
    Console.WriteLine($"numeros:{numeros[i]}");
}



