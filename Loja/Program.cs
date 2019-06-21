
namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            Mercadoria m = new Mercadoria();
            System.Console.WriteLine("Entre com dados do produto : ");
            System.Console.WriteLine("Nome : ");
            m.Nome= System.Console.ReadLine();
            System.Console.WriteLine("Preço : ");
            m.Preco = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("quantidade em estoque");
            m.Quantidade = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("dados do Produto "+ m);
        }
    }
}
