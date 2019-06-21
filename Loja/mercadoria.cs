
namespace Loja
{
    class Mercadoria

    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome + " $ " + Preco;
        }



    }
}
