// 3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

Console.WriteLine($"Digite aqui o nome do produto");
string produto = Console.ReadLine();

Console.WriteLine($"Quantos de {produto} você quer compra?");
int QuantProdut = int.Parse(Console.ReadLine());

double preçoUni = 35.50;
double total = preçoUni * QuantProdut;

static double Calc (double a, double b, double c)
{
    return (c-(a/100)*b);
}

if(QuantProdut <= 5)
{
    double desconto = 2;
    double totalaPagar = Calc(desconto,total,total);
    Console.WriteLine($" O produto em si custa {preçoUni} e de acordo com o a quantidade de {produto} que você quer, que é {QuantProdut}, o total fica {total}, mas com {desconto}% de desconto, o total a pagar fica {totalaPagar}");
}
else if(QuantProdut > 5 && QuantProdut <= 10)
{
    double desconto = 3;
    double totalaPagar = Calc(desconto,total,total);
    Console.WriteLine($" O produto em si custa {preçoUni} e de acordo com o a quantidade de {produto} que você quer, que é {QuantProdut}, o total fica {total}, mas com {desconto}% de desconto, o total a pagar fica {totalaPagar}");
}
else
{
    double desconto = 5;
    double totalaPagar = Calc(desconto,total,total);
    Console.WriteLine($" O produto em si custa {preçoUni} e de acordo com o a quantidade de {produto} que você quer, que é {QuantProdut}, o total fica {total}, mas com {desconto}% de desconto, o total a pagar fica {totalaPagar}");
}

