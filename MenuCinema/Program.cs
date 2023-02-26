// See https://aka.ms/new-console-template for more information

using System;

string[] items = { "[1] Pipoca Grande: R$", "[2] Pipoca média: R$", "[3] Pipoca pequena: R$", "[4] Refrigerante grande:R$ ", "[5] Refrigerante médio:R$ ", "[6] Refrigerante pequeno:R$ ", "[7] Chocolate: R$" };

double totItem = 0;
double[] valor = { 7.43, 5.55, 4.51, 6.52, 5.25, 4.15, 6.64 };

double credito = 0;

string escolha = "";
string continuar = "";

static void menu(string[] items, string escolha, double[] valor)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("Tabela de preços");
    Console.WriteLine(items[0] + valor[0]);
    Console.WriteLine(items[1] + valor[1]);
    Console.WriteLine(items[2] + valor[2]);
    Console.WriteLine(items[3] + valor[3]);
    Console.WriteLine(items[4] + valor[4]);
    Console.WriteLine(items[5] + valor[5]);
    Console.WriteLine(items[6] + valor[6]);
    Console.WriteLine("------------------------");
    Console.Write("Insira o item desejado: ");
    escolha = Console.ReadLine();
}

do
{
    menu(items, escolha, valor);

    if (escolha == "1")
    {
        Console.WriteLine("Item adicionado!");
        totItem = totItem + valor[0];
    }
    else if (escolha == "2")
    {
        Console.WriteLine("Item adicionado!");
        totItem = totItem + valor[1];
    }
    else if (escolha == "3")
    {
        Console.WriteLine("Item adicionado!");
        totItem = totItem + valor[2];
    }
    else if (escolha == "4")
    {
        Console.WriteLine("Item adicionado!");
        totItem = totItem + valor[3];
    }
    else if (escolha == "5")
    {
        Console.WriteLine("Item adicionado!");
        totItem = totItem + valor[4];
    }
    else if (escolha == "6")
    {
        Console.WriteLine("Item adicionado!");
        totItem = totItem + valor[5];
    }
    else if (escolha == "7")
    {
        Console.WriteLine("Item adicionado!");
        totItem = totItem + valor[6];
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Opção inválida!");
        menu(items, escolha, valor);

    }

    Console.WriteLine("Deseja adicionar mais itens?");
    continuar = Console.ReadLine();
    Console.Clear();
    if (continuar != "sim" && continuar != "nao")
    {
        Console.WriteLine("Opção inválida!");
        Console.WriteLine("Deseja adicionar mais itens?");
        continuar = Console.ReadLine();
        Console.Clear();
    }

} while (continuar == "sim");

Console.WriteLine("O valor total foi de R$" + string.Format("{0:0.00}", totItem));
Console.WriteLine("Insira a forma de pagamento: débito, crédito ou dinheiro");
string forma = Console.ReadLine();

switch (forma)
{
    case "débito":
        Console.WriteLine("insira o cartão na máquina");
        Console.WriteLine("Pagamento aprovado");
        break;

    case "crédito":
        Console.WriteLine("Deseja parcelar?");
        string parc = Console.ReadLine();
        if (parc == "sim")
        {
            Console.WriteLine("Quantidade de parcelas:  (max 10)");
            double parcela = Convert.ToInt32(Console.ReadLine());
            credito = totItem / parcela;
            Console.WriteLine($"O parcelamento ficou num total de {parcela}", string.Format("{0:0.00}", credito));
        }
        else if (parc == "nao")
        {
            Console.WriteLine("Insira o cartão");
            Console.WriteLine("Pagamento aprovado");
        }
        break;

    case "dinheiro":

        Console.WriteLine("Pague ao lado");
        break;

    default:

        Console.WriteLine("Método de pagamento inválido");

        break;
}

Console.WriteLine("Tenha uma ótima sessão!");

Console.ReadKey();
