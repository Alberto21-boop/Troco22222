using System.Globalization;
namespace Troco;

public class Program
{
    static void Main(string[] args)
    {
        //Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia.
        //Oprograma deve ler o preço unitario do produto, a quantidade de unidades compradas deste produto,
        //e o valor em dinheiro dado pelo cliente(suponha que haja dinheiro suficiente).
        //Seu programa deve mostrar o valor do troco a ser devolvido ao cliente.

        CultureInfo CI = CultureInfo.InvariantCulture;

        double Preco = 0;
        double quantidade = 0;
        double pagamento = 0;
        double troco = 0;
        double compra = 0;


        Console.WriteLine("Entre com o valor unitario do produto:");
        Console.Write("Valor unitario = R$ ");
        Preco = double.Parse(Console.ReadLine());
        
        Console.WriteLine();
        
        Console.WriteLine("Entre com a quantidade comprada:");
        Console.Write("Quantidade comprada = ");
        quantidade = double.Parse(Console.ReadLine());

        compra = quantidade * Preco;

        Console.WriteLine();

        Console.WriteLine("O valor da compra foi de = R$" + compra.ToString("C") + " Reais");

        Console.WriteLine();

        Console.WriteLine("Entre com o valor que cliente deu como pagamento ?");
        Console.Write("Pagamento = ");
        pagamento = double.Parse(Console.ReadLine());

        troco = pagamento - compra;

        Console.WriteLine();

        Console.WriteLine("O seu troco é de = R$" + troco.ToString("C") + " Reais");
    }
}