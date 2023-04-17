// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

static double Calc (double a, double b, double c)
{
    return (c-(a/100)*b);
}
Console.WriteLine(@$"
        Ola, Nos imforme que tipo de recarga no seu carro você gostária?

    (g) - Gasolina
    (a) - Álcool
");
char op = char.Parse(Console.ReadLine().ToLower());

switch(op)
{
    case 'g':
        Console.WriteLine($"Quantos liquidos de Gasolina você quer?");
        float QuantGasolina = float.Parse(Console.ReadLine());

        if (QuantGasolina <= 20)
        {
            double porcDecon = 4;
            double calc3 = Math.Round(5.30*QuantGasolina, 2);
            double resultado = Calc(calc3 ,porcDecon, calc3);

            Console.WriteLine($"O custo ficou {resultado}, deixando claro o preço cheio foi {calc3} mas com menos de 20L de gasolina você ganha {porcDecon}% de desconto");
        }
        else
        {
            double porcDecon = 6;
            double calc3 = Math.Round(4.90*QuantGasolina, 2);
            double resultado = Calc( calc3 ,porcDecon, calc3);

            Console.WriteLine($"O custo ficou {resultado}, deixando claro o preço cheio foi {calc3} mas com mais de 20L de Gasolina você ganha {porcDecon}% de desconto");
        }
        
        break;
    case 'a':
        Console.WriteLine($"Quantos liquidos de Álcool você quer?");
        float QuantAlcool = float.Parse(Console.ReadLine());
        
        if (QuantAlcool <= 20)
        {
            double porcDecon = 3;
            double calc3 = Math.Round(4.90*QuantAlcool, 2);
            double resultado = Calc( calc3 ,porcDecon, calc3);

            Console.WriteLine($"O custo ficou {resultado}, deixando claro o preço cheio foi {calc3} mas com menos de 20L de alcool você ganha {porcDecon}% de desconto");
        }
        else
        {
            double porcDecon = 5;
            double calc3 = Math.Round(4.90*QuantAlcool, 2);
            double resultado = Calc(calc3 , porcDecon, calc3);

            Console.WriteLine($"O custo ficou {resultado}, deixando claro o preço cheio foi {calc3} mas com menos de 20L de alcool você ganha {porcDecon}% de desconto");
        }
        
        break;

    default:
    Console.WriteLine($"Informo o produto errado");
    break;
}
