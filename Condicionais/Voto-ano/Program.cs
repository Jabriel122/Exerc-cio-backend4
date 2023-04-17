// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

// Entrada

int anoatual = 2023;

static int Soma(int a, int b)
{
    return a - b;
}

Console.WriteLine($"Olá, para sabermos se você pode votar ou não precisamos que nos informe o ano que nasceu. Digite aqui:");
int AnoQueNAsceu = int.Parse(Console.ReadLine());

while (AnoQueNAsceu > 2023 || AnoQueNAsceu < 1910)
{
    Console.WriteLine($"Valor inválido digite um ano válido");
    AnoQueNAsceu = int.Parse(Console.ReadLine());
}

static void BarraCarregamento(string texto, int Ponto, int Tempo)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.Write(texto);

    for (var i = 0; i < Ponto; i++)
    {
        Console.Write($".");
        Thread.Sleep(Tempo);
    }
    Console.ResetColor();
}

BarraCarregamento("Carregando", 8, 300);
Console.WriteLine($"");

int calculo = Soma(anoatual, AnoQueNAsceu);

if( calculo < 18 && calculo > 15)
{
    Console.WriteLine($"Você não precisa votar se quiser, pois você tem {calculo} anos");
}

else if( calculo <=15)
{
    Console.WriteLine($"Você não pode votar pois tem {calculo} anos");
}

else
{
    Console.WriteLine($"Pode votar, pois tem {calculo} anos");
}




